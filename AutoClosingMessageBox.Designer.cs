namespace Premiere_Pro_Project_Setup
{
    partial class AutoClosingMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMessage = new Label();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMessage.AutoSize = true;
            labelMessage.CausesValidation = false;
            labelMessage.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(149, 25);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(56, 18);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "label1";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AutoClosingMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(381, 68);
            Controls.Add(labelMessage);
            Name = "AutoClosingMessageBox";
            Text = "AutoClosingMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
    }
}