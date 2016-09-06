using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp.Models
{
   public class Section
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public ObservableCollection<Item> items { get; set; } = new ObservableCollection<Item>();
    }
}
