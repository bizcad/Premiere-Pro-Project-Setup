namespace Premiere_Pro_Project_Setup
{
    public partial class Form1 : Form
    {
        private const string projectsFolder = @"E:\Adobe\PremierPro\";
        string projectName = string.Empty;

        public Form1()
        {
            InitializeComponent();
            this.textBoxProjectName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxProjectName_KeyDown);

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreateProjectStructureFromTemplate();
            Thread.Sleep(1000);
            Close();
        }

        private void CreateProjectStructureFromTemplate()
        {
            if (textBoxProjectName.Text.Trim().Length > 0)
            {
                projectName = textBoxProjectName.Text;
                string projectFolder = $"{projectsFolder}{FileDateFactory.Create(DateTime.Now, false)}_{projectName}";
                DirectoryInfo projectInfo = new(projectFolder);
                if (projectInfo.Exists)
                {
                    DialogResult result = MessageBox.Show("Should I Delete the project?", "Project Exists", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(projectInfo.FullName, true);
                    }
                }
                DirectoryInfo templateInfo = CheckTemplate("ProjectTemplate");
                FolderCopier.CopyFolder(templateInfo.FullName, projectInfo.FullName);
                AutoClosingMessageBox.Show("Project Created", "Success", 1000);
            }
        }

        private static DirectoryInfo CheckTemplate(string templateName)
        {
            DirectoryInfo templateInfo = new(Path.Combine(projectsFolder, templateName));
            if (!templateInfo.Exists)
            {
                templateInfo = Directory.CreateDirectory(templateInfo.FullName);
            }
            var list = ProjectSubFoldersFactory.Create();
            foreach (var item in list)
            {
                string directoryName = Path.Combine(templateInfo.FullName, item.Name);
                if (!Directory.Exists(directoryName))
                {
                    _ = Directory.CreateDirectory(directoryName);
                }                
            }
            return templateInfo;
        }
        private void TextBoxProjectName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the ding sound
                CreateProjectStructureFromTemplate();
                Thread.Sleep(1000);
                Close();
            }
        }
    }
}
