
*WPF graphical issue test case*

Small program, one button, clicking on it only changes its text.
Window is intentionally small, it does not happen if the button in question is bigger.

Graphical glitch (as in GraphicalIssue.png) occurs after clicking the button or mouseover/out. (Probably only after mouseout)

I added my full dxdiag.txt for reference.

Drivers are all newest (just installed the 5950X yesterday), but i went the 'i dont have time to reinstall win10 and all my tools route'.

Also, another of my work projects has graphical issues. I have a animated color in the window and some usercontrols which bind to this color (as a warning signal).
There i don't have to mouseover at all, the controls which are bound to the animated color are just botched. Mouseover there restores them for 1 frame, then they go back to distorted.

VS 2019 version is 16.8.2

VS 2019 info:

Microsoft Visual Studio Community 2019
Version 16.8.2
VisualStudio.16.Release/16.8.2+30717.126
Microsoft .NET Framework
Version 4.8.03752

Installed Version: Community

Visual C++ 2019   00435-60000-00000-AA778
Microsoft Visual C++ 2019

ASP.NET and Web Tools 2019   16.8.553.28003
ASP.NET and Web Tools 2019

ASP.NET Core Razor Language Services   16.1.0.2052803+84e121f1403378489b842e1797df2f3f5a49ac3c
Provides languages services for ASP.NET Core Razor.

ASP.NET Web Frameworks and Tools 2019   16.8.553.28003
For additional information, visit https://www.asp.net/

Automatic Versions   2.0.48
Provides tools for managing assembly versions.

Azure App Service Tools v3.0.0   16.8.553.28003
Azure App Service Tools v3.0.0

Azure Functions and Web Jobs Tools   16.8.553.28003
Azure Functions and Web Jobs Tools

C# Tools   3.8.0-5.20567.16+53c5d7d3cf13d88978744a32a27c5f8350a8400a
C# components used in the IDE. Depending on your project type and settings, a different version of the compiler may be used.

Common Azure Tools   1.10
Provides common services for use by Azure Mobile Services and Microsoft Azure Tools.

GitHub.VisualStudio   2.11.106.19330
A Visual Studio Extension that brings the GitHub Flow into Visual Studio.

IntelliCode Extension   1.0
IntelliCode Visual Studio Extension Detailed Info

JetBrains ReSharper 2020.2.4   Build 202.0.20200925.65451
JetBrains ReSharper package for Microsoft Visual Studio. For more information about ReSharper, visit http://www.jetbrains.com/resharper. Copyright © 2020 JetBrains, Inc.

Microsoft Azure Tools   2.9
Microsoft Azure Tools for Microsoft Visual Studio 2019 - v2.9.30924.1

Microsoft Continuous Delivery Tools for Visual Studio   0.4
Simplifying the configuration of Azure DevOps pipelines from within the Visual Studio IDE.

Microsoft JVM Debugger   1.0
Provides support for connecting the Visual Studio debugger to JDWP compatible Java Virtual Machines

Microsoft Library Manager   2.1.113+g422d40002e.RR
Install client-side libraries easily to any web project

Microsoft MI-Based Debugger   1.0
Provides support for connecting Visual Studio to MI compatible debuggers

Microsoft Visual C++ Wizards   1.0
Microsoft Visual C++ Wizards

Microsoft Visual Studio Tools for Containers   1.1
Develop, run, validate your ASP.NET Core applications in the target environment. F5 your application directly into a container with debugging, or CTRL + F5 to edit & refresh your app without having to rebuild the container.

Microsoft Visual Studio VC Package   1.0
Microsoft Visual Studio VC Package

NuGet Package Manager   5.8.0
NuGet Package Manager in Visual Studio. For more information about NuGet, visit https://docs.nuget.org/

ProjectServicesPackage Extension   1.0
ProjectServicesPackage Visual Studio Extension Detailed Info

SQL Server Data Tools   16.0.62010.06180
Microsoft SQL Server Data Tools

Test Adapter for Boost.Test   1.0
Enables Visual Studio's testing tools with unit tests written for Boost.Test.  The use terms and Third Party Notices are available in the extension installation directory.

Test Adapter for Google Test   1.0
Enables Visual Studio's testing tools with unit tests written for Google Test.  The use terms and Third Party Notices are available in the extension installation directory.

TypeScript Tools   16.0.21016.2001
TypeScript Tools for Microsoft Visual Studio

Visual Basic Tools   3.8.0-5.20567.16+53c5d7d3cf13d88978744a32a27c5f8350a8400a
Visual Basic components used in the IDE. Depending on your project type and settings, a different version of the compiler may be used.

Visual F# Tools   16.8.0-beta.20507.4+da6be68280c89131cdba2045525b80890401defd
Microsoft Visual F# Tools

Visual Studio Code Debug Adapter Host Package   1.0
Interop layer for hosting Visual Studio Code debug adapters in Visual Studio

Visual Studio Container Tools Extensions   1.0
View, manage, and diagnose containers within Visual Studio.

Visual Studio Tools for CMake   1.0
Visual Studio Tools for CMake

Visual Studio Tools for Containers   1.0
Visual Studio Tools for Containers
