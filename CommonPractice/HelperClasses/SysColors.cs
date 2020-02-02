using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using CommonPractice.BaseNotifyClasses;

namespace CommonPractice.HelperClasses
{
    public class SysColors
    {
        /// <summary>
        /// Get a full list of colors available
        /// </summary>
        /// <returns></returns>
        public static List<Color> ColorStructToList()
        {

            return typeof(Color)
                .GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | 
                               BindingFlags.Public)
                .Select(c => (Color)c.GetValue(null, null))
                .ToList();

        }
        /// <summary>
        /// Get colors beginning with one or more characters
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static List<ColorItem> ColorsBeginningWith(string sender)
        {

            return ColorStructToList()
                .Where(color => color.Name.StartsWith(sender))
                .Select(color => new ColorItem() {Name = color.Name, Color = color}).ToList();

        }
    }
}
