using System;
using System.IO;

namespace MC2OverflowCheck
{
    class CheckZip
    {

        public enum EvalResult {
            Optimized, // non-ZIP assets file
            Valid, // MC2-compatible ZIP file
            Incompatible, // valid ZIP file, but breaks MC2's ZIP file handling
            Invalid, // not a valid ZIP file
            Unsafe, // causes buffer overflow in MC2
        }

        public static EvalResult Check(String path) => Check(File.OpenRead(path));

        public static EvalResult Check(Stream file)
        {
            byte[] data = new byte[46];

            // Check for optimized archive before running test
            file.Seek(0, SeekOrigin.Begin);
            int read = file.Read(data, 0, 4);
            if (read != 4) return EvalResult.Invalid;
            else if (data[0] == 'D' && data[1] == 'A' && data[2] == 'V' && data[3] == 'E') return EvalResult.Optimized;
            else if (data[0] == 'D' && data[1] == 'a' && data[2] == 'v' && data[3] == 'e') return EvalResult.Optimized;

            file.Seek(-22, SeekOrigin.End);
            read = file.Read(data, 0, 22);
            if (read != 22 || data[0] != 'P' || data[1] != 'K' || data[2] != 5 || data[3] != 6) return EvalResult.Invalid;

            if (FromLittle16(data, 4) != FromLittle16(data, 6)) return EvalResult.Incompatible;
            UInt16 count = FromLittle16(data, 8);
            if (count != FromLittle16(data, 10)) return EvalResult.Incompatible;
            long offset = FromLittle32(data, 16);

            for (UInt16 i = 0; i < count; ++i)
            {
                file.Seek(offset, SeekOrigin.Begin);
                read = file.Read(data, 0, 46);
                if (read != 46 || data[0] != 'P' || data[1] != 'K' || data[2] != 1 || data[3] != 2) return EvalResult.Invalid;

                UInt16 nameLen = FromLittle16(data, 28);
                UInt16 extraLen = FromLittle16(data, 30);
                UInt16 commentLen = FromLittle16(data, 32);
                if (nameLen >= 0x100 || extraLen > 0x100 || commentLen > 0x100) return EvalResult.Unsafe;

                UInt16 compression = FromLittle16(data, 10);
                if (compression != 0 && compression != 8) return EvalResult.Incompatible;
                UInt32 compressedSize = FromLittle32(data, 20);
                UInt32 uncompressedSize = FromLittle32(data, 24);
                if (compression == 0 && compressedSize != uncompressedSize) return EvalResult.Invalid;
                else if (compression == 8 && compressedSize >= uncompressedSize) return EvalResult.Incompatible;

                long localOffset = FromLittle32(data, 42);
                file.Seek(localOffset, SeekOrigin.Begin);
                read = file.Read(data, 0, 30);
                if (read != 30 || data[0] != 'P' || data[1] != 'K' || data[2] != 3 || data[3] != 4) return EvalResult.Invalid;
                else if (FromLittle16(data, 26) != nameLen) return EvalResult.Invalid;
                else if (FromLittle16(data, 28) != 0) return EvalResult.Incompatible;

                offset += 46 + nameLen + extraLen + commentLen;
            }

            // MC2 handles the end of central directory strangly, so here's a check to make sure it won't get confused
            file.Seek(offset, SeekOrigin.Begin);
            read = file.Read(data, 0, 4);
            if (read < 4 || (data[0] == 'P' && data[1] == 'K' && data[2] == 1 && data[3] == 2)) return EvalResult.Incompatible;

            return EvalResult.Valid;
        }

        private static UInt32 FromLittle32(byte[] value, int startIndex)
        {
            UInt32 result = BitConverter.ToUInt32(value, startIndex);
            if (BitConverter.IsLittleEndian)
            {
                return result;
            }
            else
            {
                return (UInt32)(((result >> 24) & 0x000000FF) | ((result >> 8) & 0x0000FF00) |
                                 ((result << 8) & 0x00FF0000) | ((result << 24) & 0xFF000000));
            }
        }

        private static UInt16 FromLittle16(byte[] value, int startIndex)
        {
            UInt16 result = BitConverter.ToUInt16(value, startIndex);
            if (BitConverter.IsLittleEndian)
            {
                return result;
            }
            else
            {
                return (UInt16)(((result >> 8) & 0x00FF) | ((result << 8) & 0xFF00));
            }
        }

    }
}
