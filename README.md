# LibrarySystem

LibrarySystem is a lightweight .NET 8 application for managing a library's catalog, patrons, and loans. It provides core functionality to add and manage books, register patrons, and track checkouts and returns. The project is intended as a starter template for building a full-featured library management system.

## Features
- Manage books (add, update, remove, list)
- Manage patrons (register, update, list)
- Track loans and returns
- Simple, extensible architecture targeting .NET 8

## Technology
- .NET 8
- C#
- Designed to work with any relational database or in-memory store (depending on project configuration)

## Prerequisites
- .NET 8 SDK: https://dotnet.microsoft.com/
- Visual Studio 2022/2026 or VS Code (recommended)

## Getting Started
1. Clone the repository
   - git clone https://github.com/CodedByWaheed/LibrarySystem
2. Open the solution in Visual Studio or use the command line
   - dotnet restore
   - dotnet build
   - dotnet run --project LibrarySystem

Note: If the solution contains multiple projects (API, UI, tests), run or launch the appropriate startup project.

## Running Tests
If the repository includes tests:
- dotnet test

## Contributing
Contributions are welcome. Please open issues or pull requests. Follow existing code style and add tests for new behavior.

## License
This project is provided under the MIT License unless otherwise noted in project files.

## Description
This repository contains a sample Library Management application built on .NET 8. It is suitable as a foundation for learning, prototyping, or as a starting point for a production system after adding authentication, persistence, and business rules. The code is organized to make it straightforward to extend with a web UI, REST API, or database-backed repository implementations.
