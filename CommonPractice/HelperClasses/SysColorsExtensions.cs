using System.Collections.Generic;
using System.ComponentModel;
using nf = CommonPractice.BaseNotifyClasses;

namespace CommonPractice.HelperClasses
{
    public static class SysColorsExtensions
    {
        /// <summary>
        /// Add or append list of ColorItem to the current list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="colorItemList"></param>
        public static void AddColors(this BindingList<nf.ColorItem> sender, List<nf.ColorItem> colorItemList)
        {
            foreach (var colorItem in colorItemList)
            {
                var item = sender.AddNew();
                item.Name = colorItem.Name;
                item.Color = colorItem.Color;
            }
        }
    }
}
