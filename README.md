# Mini-Discord-Bot
This is Bot project created for an discord server . 
 using .Net core and DSharpPlus Dependencies


## Installing

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

Fork it on your gihub

Add the DSharpPlus API packages

```
dotnet add package DSharpPlus
dotnet add package DSharpPlus.CommandsNext
dotnet add package DSharpPlus.Interactivity
```

And also add some Microsoft's Configuration libraries

```
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Binder
dotnet add package Microsoft.Extensions.Configuration.Json
```
Lastly add config.json file on you project before running .Place these code inside file and replace values related to your application.

```
{
  "discord": {
    "token": "BOT TOKEN HERE",
    "appId": "CLIENT ID HERE",
    "appSecret": "CLIENT SECRET HERE",
    "CommandPrefix":  "/"  //It can be changed according to your choice or leave it as it is.
  }
}
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

### Prerequisites

Code Editors like Visual Studio ,VS Code ,or other.
Basic knowledge of C#
.Net sdk 

## Built With

* [Visual Studio Code](https://code.visualstudio.com/) - The Code Editor used
* [Nuget Gallery](https://www.nuget.org/packages) - Dependency Management
* [.Net Core](https://dotnet.microsoft.com/download/dotnet-core) - The framework Used
* [D# plus](https://dsharpplus.emzi0767.com/index.html) - Discord Api

## Versioning

[SemVer](http://semver.org/) is used for versioning. For the versions available, see the [tags on this repository](https://github.com/Parzival69/Mini-Discord-Bot/tags). 

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details

## Acknowledgments

* [Blog I referenced](https://www.lchant.com/Blog/creating-a-discord-bot-with-cnet-core-and-dsharpplus) - Lachlan Chant

