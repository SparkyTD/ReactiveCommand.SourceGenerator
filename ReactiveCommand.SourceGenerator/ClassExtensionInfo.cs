using System.Collections.Generic;

namespace ReactiveCommand.SourceGenerator;

internal class ClassExtensionInfo
{
    public string ClassNamespace { get; set; }
    public string ClassName { get; set; }
    public List<CommandExtensionInfo> CommandExtensionInfos { get; set; } = new();
}