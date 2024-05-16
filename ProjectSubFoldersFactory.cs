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
using System.Text;

namespace Premiere_Pro_Project_Setup
{
    public static class ProjectSubFoldersFactory
    {

        /// <summary>
        /// The folders are separated by commas
        /// </summary>
        public const string folders = "Footage,Audio,Graphics,Music,Photos,Documents,Premiere,AE,Exports";
        
        private const char zero = '0';

        /// <summary>
        /// Creates a list of DirectoryInfo objects, each representing a subfolder for a project.
        /// </summary>
        /// <returns>A list of DirectoryInfo objects representing the project subfolders.</returns>
        public static List<DirectoryInfo> Create()
        {
            int counter = 0;
            List<DirectoryInfo> list = [];
            foreach (var folder in folders.Split(','))
            {
                StringBuilder sb = new();
                if (counter++ < 10)
                    _ = sb.Append(zero);
                sb.Append(counter);
                sb.Append(' ');
                sb.Append(folder);
                DirectoryInfo directoryInfo = new (sb.ToString());
                list.Add (directoryInfo);
            }
            return list;
        }
    }
}
