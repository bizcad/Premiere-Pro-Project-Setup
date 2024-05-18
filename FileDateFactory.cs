/*
 * 
 * This file is part of the Premiere Pro Project Setup project.
 *
 * Written by: Nicholas Stein
 * Date: 2024-05-15
 * 
 * Purpose: This file contains the FileDateFactory class which 
 * create a date string in the format YYYYMMDD[_HHMMSS] from a DateTime object.
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
    /// <summary>
    /// Provides a factory for creating date strings for file names.
    /// </summary>
    public static class FileDateFactory
    {
        private const char zero = '0';
        private const char underscore = '_';

        /// <summary>
        /// Creates a date string in the format YYYYMMDD[_HHMMSS] from a DateTime object.
        /// </summary>
        /// <param name="dt">The DateTime object to convert to a string.</param>
        /// <param name="includeHMS">Whether to include the hour, minute, and second in the date string.</param>
        /// <returns>A date string in the format YYYYMMDD[_HHMMSS].</returns>
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

