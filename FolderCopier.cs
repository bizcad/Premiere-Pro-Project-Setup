/*
 * 
 * This file is part of the Premiere Pro Project Setup project.
 *
 * Written by: Nicholas Stein
 * Date: 2024-05-15
 * 
 * Purpose: This file contains the ProjectSubFoldersFactory class, 
 * which creates a list of DirectoryInfo objects, each representing a subfolder for a project.
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
    /// Provides a method for copying a folder and its contents.
    /// </summary>
    public static class FolderCopier
    {
        /// <summary>
        /// Copies the specified source folder and its contents to the specified destination folder.
        /// If the destination folder does not exist, it is created.
        /// </summary>
        /// <param name="sourceFolder">The path of the folder to copy.</param>
        /// <param name="destinationFolder">The path to where the folder should be copied.</param>
        public static void CopyFolder(string sourceFolder, string destinationFolder)
        {
            // Create destination folder if it does not exist
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            // Copy files
            foreach (string file in Directory.GetFiles(sourceFolder))
            {
                string fileName = Path.GetFileName(file);
                string destinationFile = Path.Combine($"{destinationFolder}\\", fileName);
                File.Copy(file, destinationFile, true);
            }

            // Recursively copy subfolders
            foreach (string folder in Directory.GetDirectories(sourceFolder))
            {
                string folderName = Path.GetFileName(folder);
                string myDestinationFolder = Path.Combine(destinationFolder, folderName);
                CopyFolder(folder, myDestinationFolder);
            }
        }
    }
}
