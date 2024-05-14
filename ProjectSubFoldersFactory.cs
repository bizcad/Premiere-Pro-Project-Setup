using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premiere_Pro_Project_Setup
{
    public static class ProjectSubFoldersFactory
    {
        public const string folders = "Footage,Audio,Graphics,Music,Photos,Documents,Premiere,AE,Exports";

        private const char zero = '0'; 
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
