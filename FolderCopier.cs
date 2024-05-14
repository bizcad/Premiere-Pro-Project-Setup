using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premiere_Pro_Project_Setup
{
    public static class FolderCopier
    {
        public static void CopyFolder(string sourceFolder, string destinationFolder)
        {
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            foreach (string file in Directory.GetFiles(sourceFolder))
            {
                string fileName = Path.GetFileName(file); 
                string destinationFile = Path.Combine($"{destinationFolder}\\", fileName);
                File.Copy(file, destinationFile, true);
            }

            foreach (string folder in Directory.GetDirectories(sourceFolder))
            {
                string folderName = Path.GetFileName(folder);
                string myDestinationFolder = Path.Combine(destinationFolder, folderName);
                CopyFolder(folder, myDestinationFolder);
            }
        }
    }
}
