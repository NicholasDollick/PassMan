using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUserInterface.ViewModels;

namespace WPFUserInterface.Helpers
{
    class PopupWindowFactory
    {
        //public void CreateNewEntityPopup()
        //{
        //    AddItemPrompt window = new AddItemPrompt()
        //    {
        //        DataContext = new AddItemPromptViewModel(),
        //    };
        //    window.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        //    window.Show();
        //}
        public void CreateNewEntityPopup(ICommand cmd)
        {
            AddItemPrompt window = new AddItemPrompt()
            {
                DataContext = new AddItemPromptViewModel(cmd),
            };
            window.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }
}
