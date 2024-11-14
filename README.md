# CSharp-DocGenerator
Takes in C# code, parses comments and relevant method documentation to generate a markdown/HTML file of the documentation.
# Install & Run
To try out the project yourself you'll need to make a local clone of the repository and run the C# Windows Forms application

# Why
Because if we already document our code properly why double the work and do that again but on a separaet documentation file? 
This simplifies that process

### More on how it works
Browses for c# files, takes them in.
Uses Roslyn which is Microsoft .NET compiler platform to parse all the code and generate a syntax tree.
From the root of the tree we start visiting each method declaration to extract those and their parameters and any comments.

Then from there it as simple as deciding on how to style the output, want html? then take the parsed data and output it into html formatted file, etc...