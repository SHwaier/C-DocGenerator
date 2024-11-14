using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public class DocumentationParser
{
    /// <summary>
    /// Uses a file path to parse a C# file and extract information about each method in the file
    /// </summary>
    /// <param name="filePath">The absolute location of the input file to be parsed</param>
    /// <returns>returns a list of MethodData that can be exported to different formats. Basically code documentation.</returns>
    public static List<MethodData> ParseMethods(string filePath)
    {
        var code = File.ReadAllText(filePath);
        var tree = CSharpSyntaxTree.ParseText(code);
        var root = tree.GetRoot();

        var methods = new List<MethodData>();

        // Visit each method declaration
        var methodDeclarations = root.DescendantNodes().OfType<MethodDeclarationSyntax>();
        foreach (var method in methodDeclarations)
        {
            // extract method data including name, parameters, and any comments
            var methodData = new MethodData
            {
                Name = method.Identifier.Text,
                Parameters = method.ParameterList.Parameters.Select(p => new ParameterData
                {
                    Name = p.Identifier.Text,
                    Type = p.Type.ToString()
                }).ToList(),
                Description = method.GetLeadingTrivia().ToString().Trim() // Extracts comments
            };

            methods.Add(methodData);
        }
        return methods;
    }

}/// <summary>
/// Used to store information about a method in a C# file
/// </summary>
public class MethodData
{
    public string Name { get; set; }
    public List<ParameterData> Parameters { get; set; }
    public string Description { get; set; }
}

/// <summary>
/// Used to store information about a parameter in a C# file
/// </summary>
public class ParameterData
{
    public string Name { get; set; }
    public string Type { get; set; }
}
