# Calendarific SDK .NET

[Calendarific](https://calendarific.com/) API client wrapper for .NET projects

[![GitHub license](https://img.shields.io/github/license/guibranco/calendarific-sdk-dotnet)](https://github.com/guibranco/calendarific-sdk-dotnet)
[![Time tracker](https://wakatime.com/badge/github/guibranco/calendarific-sdk-dotnet.svg)](https://wakatime.com/badge/github/guibranco/calendarific-sdk-dotnet)

![API Client Boilerplate](https://raw.githubusercontent.com/guibranco/calendarific-sdk-dotnet/main/logo.png)

## CI/CD

| Build status | Last commit | Tests | Coverage | Code Smells | LoC | 
|--------------|-------------|-------|-------|-------|-------|
| [![Build status](https://ci.appveyor.com/api/projects/status/qnsxp59qjxj7v01b/branch/main?svg=true)](https://ci.appveyor.com/project/guibranco/calendarific-sdk-dotnet/branch/main) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/calendarific-sdk-dotnet/main)](https://github.com/guibranco/calendarific-sdk-dotnet) | [![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/guibranco/calendarific-sdk-dotnet/main?compact_message)](https://ci.appveyor.com/project/guibranco/calendarific-sdk-dotnet/branch/main/tests) | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet-dotnet&metric=coverage&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet) | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet-dotnet&metric=code_smells&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet) | [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet-dotnet&metric=ncloc&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet) | 

## Code Quality (main branch)

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/fc6a4a2383604ccdbe97abafac9cc33f)](https://www.codacy.com/gh/guibranco/calendarific-sdk-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=gguibranco/calendarific-sdk-dotnet&amp;utm_campaign=Badge_Grade)
[![Codacy Badge](https://app.codacy.com/project/badge/Coverage/fc6a4a2383604ccdbe97abafac9cc33f)](https://www.codacy.com/gh/guibranco/calendarific-sdk-dotnet/dashboard?utm_source=github.com&utm_medium=referral&utm_content=guibranco/calendarific-sdk-dotnet&utm_campaign=Badge_Coverage)

[![codecov](https://codecov.io/gh/guibranco/calendarific-sdk-dotnet/branch/main/graph/badge.svg)](https://codecov.io/gh/guibranco/calendarific-sdk-dotnet)
[![CodeFactor](https://www.codefactor.io/repository/github/guibranco/calendarific-sdk-dotnet/badge)](https://www.codefactor.io/repository/github/guibranco/calendarific-sdk-dotnet)

[![Maintainability](https://api.codeclimate.com/v1/badges/e6dc79615d2bc446f579/maintainability)](https://codeclimate.com/github/guibranco/calendarific-sdk-dotnet/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/e6dc79615d2bc446f579/test_coverage)](https://codeclimate.com/github/guibranco/calendarific-sdk-dotnet/test_coverage)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet)

[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_calendarific-sdk-dotnet&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_calendarific-sdk-dotnet-dotnet)

---

## Installation

### Github Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/calendarific-sdk-dotnet.svg?style=flat)](https://github.com/guibranco/calendarific-sdk-dotnet) [![Github All Releases](https://img.shields.io/github/downloads/guibranco/calendarific-sdk-dotnet/total.svg?style=flat)](https://github.com/guibranco/calendarific-sdk-dotnet)

Download the latest zip file from the [Release](https://github.com/guibranco/calendarific-sdk-dotnet/releases) page.

### Nuget package manager

[![PacakgeName NuGet Version](https://img.shields.io/nuget/v/Calendarific.svg?style=flat)](https://www.nuget.org/packages/Calendarific/)
[![PacakgeName NuGet Downloads](https://img.shields.io/nuget/dt/Calendarific.svg?style=flat)](https://www.nuget.org/packages/Calendarific/)

| Package | Version | Downloads |
|------------------|:-------:|:-------:|
| **Calendarific** | [![Calendarific NuGet Version](https://img.shields.io/nuget/v/Calendarific.svg?style=flat)](https://www.nuget.org/packages/Calendarific/) | [![Calendarific NuGet Downloads](https://img.shields.io/nuget/dt/Calendarific.svg?style=flat)](https://www.nuget.org/packages/Calendarific/) |

---

## Features

Implements all features of Calendarific API available at [Calendarific API Documentation](https://calendarific.com/api-documentation)

-  Feature #1
-  Feature #2
-  Feature #3
-  Feature #N

---

## Usage

```cs

//sample CSharp code showing how to use the lib
var client = new CalendarificClient();
client.CallSomeMethod();

```

---
