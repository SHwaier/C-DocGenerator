namespace CSharp_DocGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputTxtField = new TextBox();
            inputBrowseBtn = new Button();
            label1 = new Label();
            label3 = new Label();
            exportBtn = new Button();
            SuspendLayout();
            // 
            // inputTxtField
            // 
            inputTxtField.Location = new Point(12, 74);
            inputTxtField.Name = "inputTxtField";
            inputTxtField.Size = new Size(410, 23);
            inputTxtField.TabIndex = 0;
            // 
            // inputBrowseBtn
            // 
            inputBrowseBtn.Location = new Point(428, 74);
            inputBrowseBtn.Name = "inputBrowseBtn";
            inputBrowseBtn.Size = new Size(75, 23);
            inputBrowseBtn.TabIndex = 2;
            inputBrowseBtn.Text = "Browse";
            inputBrowseBtn.UseVisualStyleBackColor = true;
            inputBrowseBtn.Click += inputBrowseBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Input File";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(355, 25);
            label3.TabIndex = 7;
            label3.Text = "Generate C# Documentation With Ease";
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(12, 114);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(491, 23);
            exportBtn.TabIndex = 8;
            exportBtn.Text = "Export";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 181);
            Controls.Add(exportBtn);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(inputBrowseBtn);
            Controls.Add(inputTxtField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "C# Doc Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTxtField;
        private Button inputBrowseBtn;
        private Label label1;
        private Label label3;
        private Button exportBtn;
    }
}
