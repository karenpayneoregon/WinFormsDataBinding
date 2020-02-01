using System;
using System.Linq;

namespace Example1Library.Extensions
{
    public static class StringExtension
    {
        public static string ProcessSpacings(this string line)
        {
            try
            {
                return string.Join(",", Array.ConvertAll(line.Split(','), 
                    field => field.Trim()).Select(items => $"{items}"));
            }
            catch (Exception)
            {
                return line;
            }
        }
    }
}
