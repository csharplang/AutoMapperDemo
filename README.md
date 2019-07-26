# Auto Mapper Demo
AutoMapper is a simple little library built to solve a deceptively complex problem


## Create Project with .NET CLI
```bash 

dotnet new sln -n AutoMapperDemo
dotnet new mvc -n AutoMapperDemo
dotnet sln AutoMapperDemo.sln add AutoMapperDemo/AutoMapperDemo.csproj


dotnet build
dotnet run
dotnet watch run

Publish and run:
dotnet publish -o ./publish
dotnet AutoMapperDemo.dll
```

## Auto Mapper Nuget
- Install-Package AutoMapper -Version 8.1.1
- Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 6.1.1

## Auto Mapper C# Code
```csharp
services.AddAutoMapper(typeof(Startup));

public UserProfile()
    {
        CreateMap<User, UserViewModel>();
    }

public IActionResult Index()
    {
        var user = new User
        {
            Id = 1,
            FirstName = "R M Shahidul Islam",
            LastName = "Shahed",
            EmailAddress = "dev@gmail.com"
        };

        UserViewModel viewModel = _mapper.Map<UserViewModel>(user);
        return View(viewModel);
    }
```

## .NET
- [Download .Net Core](https://dotnet.microsoft.com/download)
- [VS Code](https://code.visualstudio.com/)
- dotnet --version

