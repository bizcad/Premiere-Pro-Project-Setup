using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premiere_Pro_Project_Setup
{
    public static class FileDateFactory
    {
        private const char zero = '0';
        private const char underscore = '_';
        public static string Create(DateTime dt, bool includeHMS)
        {
            StringBuilder sb = new();
            sb.Append(dt.Year);
            if (dt.Month < 10)
                _ = sb.Append(zero);
            sb.Append(dt.Month);

            if (dt.Day < 10)
                _ = sb.Append(zero);
            sb.Append(dt.Day);

            if (includeHMS)
            {
                sb.Append(underscore);
                if (dt.Hour < 10)
                    _ = sb.Append(zero);
                sb.Append(dt.Hour);
                if (dt.Minute < 10)
                    _ = sb.Append(zero);
                sb.Append(dt.Minute);
                if (dt.Second < 10)
                    _ = sb.Append(zero);
                sb.Append(dt.Second);
            }
            return sb.ToString();
        }
    }
}
