namespace Premiere_Pro_Project_Setup
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
            labelProjectName = new Label();
            textBoxProjectName = new TextBox();
            buttonCreate = new Button();
            SuspendLayout();
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Location = new Point(16, 24);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(79, 15);
            labelProjectName.TabIndex = 0;
            labelProjectName.Text = "Project Name";
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Location = new Point(124, 22);
            textBoxProjectName.Margin = new Padding(3, 2, 3, 2);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.PlaceholderText = "Project Name";
            textBoxProjectName.Size = new Size(419, 23);
            textBoxProjectName.TabIndex = 1;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(568, 24);
            buttonCreate.Margin = new Padding(3, 2, 3, 2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(82, 22);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += ButtonCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(681, 112);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxProjectName);
            Controls.Add(labelProjectName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProjectName;
        private TextBox textBoxProjectName;
        private Button buttonCreate;
    }
}
