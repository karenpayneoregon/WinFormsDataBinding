using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommonPractice.BaseNotifyClasses;

namespace CommonPractice.HelperClasses
{
    public class SysColors
    {
        public static List<Color> ColorStructToList()
        {
            return typeof(Color)
                .GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
                .Select(c => (Color)c.GetValue(null, null))
                .ToList();
        }

        public static List<ColorItem> ColorsBeginningWithA()
        {
            return ColorStructToList()
                .Where(color => color.Name.StartsWith("A"))
                .Select(color => new ColorItem() {Name = color.Name, Color = color}).ToList();
        }
        public static List<ColorItem> ColorsBeginningWithB()
        {
            return ColorStructToList()
                .Where(color => color.Name.StartsWith("B"))
                .Select(color => new ColorItem() { Name = color.Name, Color = color }).ToList();
        }
    }
}
