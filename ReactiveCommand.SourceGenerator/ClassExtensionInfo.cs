using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ReactiveCommand.SourceGenerator;

internal class ClassExtensionInfo
{
    public string ClassNamespace { get; set; }
    public string ClassName { get; set; }
    public  ClassDeclarationSyntax  DeclarationSyntax { get; set; }
    public List<CommandExtensionInfo> CommandExtensionInfos { get; set; } = new();
}