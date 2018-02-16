# Midnight Club 2 Overflow Checker

This program checks .zip and .dat files to see if they will overflow the
buffers in Midnight Club 2 for loading game assets. The buffer overflow in
Midnight Club 2 can be used to run malicious code on your system. This program
can be used to safely scan any mod files before loading them into the game.

## Running

### Requirements

This program requires .NET to run. .NET 2.0 or higher is required.
.NET 4.0 or higher is recommended. [Mono](http://mono-project.com/)
may be used instead.

### Usage

Once you open the program, click the "Choose Zip" and select the file
you want to test in the file dialog. Once the file is selected, the
text below the button will show the file path, and the result of the scan.

## How to build:

### Requirements:

Requires Visual Studio 2017 Update 5. Alternatives for Mono should also work.

### Building

Open MC2OverflowCheck.sln or MC2OverflowCheck/MC2OverflowCheck.csproj 
and build. This project has no external dependencies.

## Licence:

This application is licensed under the MIT Licence.

```
Copyright (c) 2018 LRFLEW and Krutonium


Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
