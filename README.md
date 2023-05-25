# ReactiveCommand.SourceGenerator

[![NuGet](https://img.shields.io/nuget/v/ReactiveCommand.SourceGenerator.svg)](https://www.nuget.org/packages/ReactiveCommand.SourceGenerator/)

ReactiveCommandAttribute is a convenient Source Generator library designed to enhance your development experience with the ReactiveUI library by automating the creation of ReactiveCommands.

The centerpiece of the package is the `ReactiveCommand` attribute. When attached to a method within your partial ViewModel class, this attribute triggers a build step that automatically extends the class with the corresponding ReactiveCommand properties and an initializer function.

## Installation
Installing PropertyChanged.SourceGenerator into your project is straightforward. You'll need to have .NET Core installed on your system to begin.

Simply add the `PropertyChanged.SourceGenerator` NuGet package to your project using either the .NET CLI or the NuGet Package Manager.

## Quick Start
```csharp
public partial class MyViewModel : ReactiveObject
{
    public MyViewModel() 
    {
        InitializeCommands();
    }
    
    [ReactiveCommand]
    public void DoStuff()
    {
        Console.WriteLine("Stuff!");
    }
    
    [ReactiveCommand]
    public int ParseStringAsInt(string str) => int.Parse(str);
}
```

Generated code:
```csharp
public partial class MyViewModel
{
    public ReactiveCommand<Unit, Unit> DoStuffCommand { get; private set; }
    public ReactiveCommand<string, int> ParseStringAsIntCommand { get; private set; }

    internal void InitializeCommands() 
    {
        DoStuffCommand = ReactiveCommand.Create(DoStuff);
        ParseStringAsIntCommand = ReactiveCommand.Create<string, int>(ParseStringAsInt);
    }
}
```
