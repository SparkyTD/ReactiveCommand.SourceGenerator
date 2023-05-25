using System.Drawing;
using System.Reactive;
using ReactiveCommand.SourceGenerator.Attributes;
using ReactiveUI;

namespace Sandbox.Test;

public partial class Program
{
    public static void Main()
    {
        new Program().Init();
    }

    public void Init()
    {
        InitializeCommands();

        Console.Out.WriteLine(Test1Command);
        Console.Out.WriteLine(Test2Command);
        Console.Out.WriteLine(Test3AsyncCommand);
        Console.Out.WriteLine(Test4AsyncCommand);
        Console.Out.WriteLine(Test5StringToIntCommand);
        Console.Out.WriteLine(Test6ArgOnlyCommand);
    }

    [ReactiveCommand]
    public void Test1()
    {
    }

    [ReactiveCommand]
    public Rectangle Test2()
    {
        return default;
    }

    [ReactiveCommand]
    public async Task Test3Async() => await Task.Delay(0);

    [ReactiveCommand]
    public async Task<Rectangle> Test4Async() => default;
    
    [ReactiveCommand]
    public int Test5StringToInt(string str) => int.Parse(str);

    [ReactiveCommand]
    public void Test6ArgOnly(string str)
    {
        Console.Out.WriteLine($">>> {str}");
    }
}