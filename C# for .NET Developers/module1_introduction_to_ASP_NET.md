# Introduction to ASP.NET

## Intorduction to .NET Core and its features

**Introduction To .NET Core**
- .NET Core is an open-source, cross platform that runs on Windows, MacOS, and Linux OS.
- It is a subset of the larger .NET Framework
- It was Introduced by Microsoft in 2016 as a successor to the .NET Framework.
- .NET Core is written from scratch to make it modular, lightweight, fast.
- It has core features that are required to run a basic .NET Core app.
- It also includes rich set of APIs and framework, such as ASP.NET Core for building web applications.

**Why .NET Core?**
- Cross Platform:
Easier for developers to create applications that can be used on multiple platforms.
- Performance:
.NET Core is designed to work well in cloud environments.
- Modern Development:
.NET Core provides developers with modern development tools and techniques, like support for async programming and the ability to use lightweight editors like VSCode.

**Features Of.NET Core**
1. Open-source
2. Cross-Platform
3. Modular Architecture
4. Support Multiple Languages
5. Consistent
6. CLI Tools
7. Flexible Deployment
8. Compatability


## Difference Berween .NET Framework and .NET Core

**.NET Core**
- *Open source* - .NET Core is an open source.
- *Cross-Plaform* - Compatible with Windows, Linux, and Mac OS
- *Application Models* - Does not support desktop applications
- *Performance* - Offers high performance and acalability.
- *Security* - Does not have features like Code Access Security.

**.NET Framework**
- *Open source* - Contain components are open source.
- *Cross-Plaform* - Compatible with the windows OS.
- *Application Models* - Support desktop and web applications
- *Performance* - Less effective in comparision to .NET
- *Security* - Code accedd security feature in present

## Setting up a development environment with VS code
- Install .NET (https://dotnet.microsoft.com/)

Check 
`dotnet`
`dotnet --version`

Commands:
- `dotnet new list`
- `dotnet new console -n coreConsoleProject`
- `dotnet build`
- `dotnet run`


## Introduction to .NET CLI
- .NET CLI is a new cross-platform tool.
- CLI tool is used for creating, restoring packages, building, and publishing .NET applications
- It supports installation of packages.
- It support various commands that can be used to ceate, build and run .NET Core projects.
- It can also be used to manage dependencies, including adding, removing and updating packages.
- It can be easly automated and integrated into build and deployment pipelines.

## .NET CLI Command Structure

`dotnet <command> <argument> <option>`

- All the commands start with driver named dotnet.
- The driver starts the execution of the specified command.
- After dotnet, we can supply command (also known as verb) to perform a specific action.
- Each command can be followed by arguments and options.


## .NET CLI Commands
- Type `dotnet -help` will list all the commands the tool is offering:

**Commands:**
- **new** - Ininialize .NET projects.
- **restore** - Restore dependencies apecified in the .NET project.
- **build** - Builds a .NET project.
- **publish** - Pubilshes a .NET project for deployment (including the runtime).
- **run** - Complies and immediately executes a .NET project.
- **test** - Runs unit tests the using the test runner specified in the project.
- **pack** - Create a NuGet package.
- **migrate** - Migrates a project.json based project to a msbuild based project
- **clean** - Clean build output(s).
- **sln** - Modify solution (SLN) files.

**Project Modification Commands:**
- **add** - Add items to the project
- **remove** - Remove items from the project
- **list** - List items in the project

**Advanced Commands:**
- **nuget** - Provide additional NuGet commands.
- **msbuild** - Runs Microsoft Build Engine (MS Buils)
- **vstest** - Runs Microsoft Test Execution Command Line Tool.

Example:
`dotnet new web --name=coreWebProject`
`dotnet build`


## .NET Core Platform

**.NET COre Platform Composition**
The .NET Core Framework composed of the following parts:
- **CLI Tools:** A set of tools for development and deployment.
- **Roslyn:** Language Compiler for C# and Visual  Basic.
- **CoreFX:** Set of framework libraries.
- **CoreCLR:** A JIT based CLR (Command Language Runtime).

**.NET Core Language Compilers**
- The Compilers included in .NET Core are responding for translating code.
- Translated code written in C#, F#, and Visual Basic into Intermediate Language (IL) code.
- IL is a low-level language that can be executed by the .NET runtime.
- Roslyn language compiler is used for C# and Visual Basic.
- F# Comiler (fsc.exe) is used to compile F# code.

**.NET Core CLR**
- CoreCLR is the .NET runtime (i.e., execution engine) used in .NET Core.
- It is responsible for compiling and executing .NET Core applications.
- Provides features like garbage collection, just-in-time (JIT) coompilation, and exception handling.
- One of the benefits of CoreCLR is its performance.
- It is optimized for modern hardware.
- It is lightweight and modular, it used less resources than the full .NET Framework.

**.NET CoreFX**
- CoreFX is foundation set of libraries that provides functionality to .NET Core applications.
- It provides a wide range of libraries.
- Those libraries provides functionality such as file I/O, networking, and collections.
- It is modular so that developers can choose the libraries that are needed for the application.

## Demo: Building a baasic .NET Core console application
`dotnet new console --name=coreConsoleApplication`
`dotnet build`
`dotnet run`
