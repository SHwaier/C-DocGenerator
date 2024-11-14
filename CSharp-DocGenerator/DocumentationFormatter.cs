using System.Text;

public class DocumentationFormatter
{
    public static string ToMarkdown(List<MethodData> methods)
    {
        var markdown = new StringBuilder();
        foreach (var method in methods)
        {
            markdown.AppendLine($"### {method.Name}");
            markdown.AppendLine(method.Description);
            markdown.AppendLine();

            if (method.Parameters.Any())
            {
                markdown.AppendLine("**Parameters:**");
                foreach (var param in method.Parameters)
                {
                    markdown.AppendLine($"- `{param.Name}` ({param.Type})");
                }
                markdown.AppendLine();
            }
            markdown.AppendLine("---");
        }
        return markdown.ToString();
    }
    public static string ToHtml(List<MethodData> methods)
    {
        var html = new StringBuilder();
        html.AppendLine("<html>");
        html.AppendLine("<head>");
        html.AppendLine("<style>");
        html.AppendLine("body { font-family: Arial, sans-serif; margin: 20px; line-height: 1.6; }");
        html.AppendLine("h1 { color: #4A90E2; }");
        html.AppendLine("h2 { color: #333; border-bottom: 1px solid #ddd; padding-bottom: 5px; }");
        html.AppendLine("p { color: #666; }");
        html.AppendLine("ul { list-style-type: none; padding: 0; }");
        html.AppendLine("li { padding: 5px 0; color: #333; }");
        html.AppendLine("hr { border: none; border-top: 1px solid #ddd; margin: 20px 0; }");
        html.AppendLine("</style>");
        html.AppendLine("</head>");
        html.AppendLine("<body>");
        html.AppendLine("<h1>Documentation</h1>");

        foreach (var method in methods)
        {
            html.AppendLine($"<h2>{method.Name}</h2>");
            html.AppendLine($"<p>{method.Description}</p>");

            if (method.Parameters.Any())
            {
                html.AppendLine("<h3>Parameters:</h3>");
                html.AppendLine("<ul>");
                foreach (var param in method.Parameters)
                {
                    html.AppendLine($"<li><b>{param.Name}</b>: <i>{param.Type}</i></li>");
                }
                html.AppendLine("</ul>");
            }
            html.AppendLine("<hr>");
        }

        html.AppendLine("</body>");
        html.AppendLine("</html>");
        return html.ToString();

    }
}

