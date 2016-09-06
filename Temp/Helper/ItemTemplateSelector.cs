using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temp.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Temp.Helper
{
    public class ItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SectionsTemplate { get; set; }
        public DataTemplate ItemTextTemplate { get; set; }
    
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            // logic to select templete is here.
            var flipViewItem = item as Object;
            if (flipViewItem.GetType().Name == "Item")
            {
                var currentItem = item as Item;
                if (currentItem.item_type == "text")
                {
                    return ItemTextTemplate;
                }
            }
            return SectionsTemplate;
        }
    }
}