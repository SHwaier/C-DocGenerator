namespace CSharp_DocGenerator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows users to browse for a C# file to use for documentation generation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "C# Files|*.cs";
                    ofd.Title = "Select a C# file";
                    ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            inputTxtField.Text = ofd.FileName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while selecting the file.\n\nDetails: {ex.Message}", "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred with the file dialog.\n\nDetails: {ex.Message}", "Open Dialog Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exports the generated documentation to a markdown or html file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Markdown Files|*.md|HTML Files|*.html";
                    saveFileDialog.Title = "Save documentation";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        string extension = Path.GetExtension(filePath);

                        try
                        {
                            // Attempt to parse methods from the input text
                            var methods = DocumentationParser.ParseMethods(inputTxtField.Text);

                            if (extension == ".md")
                            {
                                // Try writing Markdown documentation
                                var markdownDocumentation = DocumentationFormatter.ToMarkdown(methods);
                                File.WriteAllText(filePath, markdownDocumentation);
                            }
                            else if (extension == ".html")
                            {
                                // Try writing HTML documentation
                                var htmlDocumentation = DocumentationFormatter.ToHtml(methods);
                                File.WriteAllText(filePath, htmlDocumentation);
                            }
                            
                            MessageBox.Show("Documentation exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (UnauthorizedAccessException ex)
                        {
                            MessageBox.Show($"Access denied to the specified path. Please check your permissions.\n\nDetails: {ex.Message}", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show($"An I/O error occurred while trying to save the file.\n\nDetails: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An unexpected error occurred while exporting.\n\nDetails: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    saveFileDialog.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred with the save dialog.\n\nDetails: {ex.Message}", "Save Dialog Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
