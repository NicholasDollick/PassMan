using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUserInterface.Helpers;

namespace WPFUserInterface.Models
{
    class MenuItems
    {

        public MenuItems()
        {
            this.MenuItemClicked = new RelayCommand(TestFunc, param => true);
        }

        private void TestFunc(object obj)
        {
            throw new NotImplementedException();
        }

        public string PathData { get; set; }
        public int ListItemHeight { get; set; }
        public bool IsItemSelected { get; set; }
        public ICommand MenuItemClicked { get; set; }
    }
}
