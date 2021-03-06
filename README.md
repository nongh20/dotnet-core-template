## .NET Core 3.0 Project Templates

Provides a good start for large scale projects.
Project architecture considers software concepts such as DDD, TDD, Solid etc.
Aims to provide microservice structure that includes independent modules.
Contains user modules basicly for now.

## Installation

- [Install Visual Studio Extension](https://marketplace.visualstudio.com/items?itemName=onka13.CoreTemplate)
- Open Visual Studio then create a new project.
- Select 'Onka Project' then type a project name.
- On next window clone [dotnet-common-project](https://github.com/onka13/dotnet-core-common) if not exists. Or manually run command `git clone https://github.com/onka13/dotnet-core-common.git`
- Create project
- Run `dotnet restore` 

Watch on Youtube [https://www.youtube.com/watch?v=hNpzdd9IwVg&list=PL5Eyzh8XRjPeTHVkzRKhcr7NQvzzOaHt5&index=1](https://www.youtube.com/watch?v=hNpzdd9IwVg&list=PL5Eyzh8XRjPeTHVkzRKhcr7NQvzzOaHt5&index=1)

[![Demo Video](http://i3.ytimg.com/vi/hNpzdd9IwVg/maxresdefault.jpg)](https://www.youtube.com/watch?v=hNpzdd9IwVg&list=PL5Eyzh8XRjPeTHVkzRKhcr7NQvzzOaHt5&index=1 "Demo Video")


***

- `/Projects/dotnet-common-project`
- `/Projects/your project`

# Structure of the project

- `/Application` - api, worker, console, web projects etc.
    - `XXX.Application.AllAPI` - api project, contains all modules
    - `XXX.Application.WorkerService` - background services project
- `/Modules` - contains modules    
    - `Account` - user module
        - `ModuleAccount` - module library for account module. Contains all models, repos and services
        - `ModuleAccountApi` - contains user based api routes
        - `ModuleAccount.Application.API` - api project, only contains ModuleAccountApi
    - `Admin` - admin module
        - `ModuleAdmin`
        - `ModuleAdminApi`
        - `ModuleAdmin.Application.API`
    - `Common` - shared module for modules
        - `ModuleCommon` - common module
        - `ModuleCommonApi`
        - `ModuleCommon.Application.API` - common based api project    
- `/Tests` - test project
    - `XXX.Tests.General` - unit test project

### Add New Module

- Create a solution folder under `Modules`
- Add a new project -> select 'ONKA .NET Core Module Template'
- Add a new project -> select 'ONKA .NET Core Module Template Api'
- Add a new project -> select 'ONKA .NET Core Module Template Application'

### Code generator

- Please check [NoDb-Core-Generator](https://github.com/onka13/NoDb-Core-Generator)

## Todo

- [ ] Create documentation
- [ ] Add more functionality for user module
- [x] Add a react js based admin ui panel
- [x] Code generator for modules

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
