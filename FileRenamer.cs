/*
 * 
 * This file is part of the Premiere Pro Project Setup project.
 *
 * Written by: Nicholas Stein
 * Date: 2024-05-15
 * 
 * Purpose: This file contains the FileRenamer class which recursively renames files in a directory by replacing "_Default" with the project name.
 * 
 * Change log:
 * 
 * Date           Programmer          Change
 * 2024-05-15   Nicholas Stein      Added the ProjectSubFoldersFactory class.
 * 
 */
namespace Premiere_Pro_Project_Setup
{
    /// <summary>
    /// Provides methods for renaming files in a directory and its subdirectories.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the FileRenamer class with the specified project name.
    /// </remarks>
    /// <param name="projectName">The name of the Premier Pro project.</param>
    internal class FileRenamer(string projectName)
    {
        private readonly string projectName = projectName;

        /// <summary>
        /// Renames all files in the specified directory and its subdirectories that contain "_Default" in their names.
        /// </summary>
        /// <param name="dir">The directory to rename files in.</param>
        public void RenameProjectFiles(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Name.Contains("_Default"))
                {
                    RenameFile(file);
                }
            }

            // Recursively copy subfolders
            foreach (DirectoryInfo folder in dir.GetDirectories())
            {
                RenameProjectFiles(folder);
            }
        }

        /// <summary>
        /// Renames the specified file by replacing "_Default" in its name with the project name.
        /// </summary>
        /// <param name="file">The file to rename.</param>
        private void RenameFile(FileInfo file)
        {
            string newFilePath = file.FullName.Replace("_Default", $"_{projectName}");
            File.Copy(file.FullName, newFilePath, true);
            File.Delete(file.FullName);
        }
    }
}
