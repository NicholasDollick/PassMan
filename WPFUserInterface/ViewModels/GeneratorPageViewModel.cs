using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUserInterface.Helpers;
using WPFUserInterface.Views;

namespace WPFUserInterface.ViewModels
{
    class GeneratorPageViewModel : BaseViewModel
    {
        public GeneratorPageViewModel()
        {
            GoToVaultCommand = new RelayCommand(ChangePageToVault, param => true);
        }

        public override void LoadViewModel(ChangePageEventArgs args)
        {

        }

        private void ChangePageToVault(object obj)
        {
            ChangePageEventArgs args = new ChangePageEventArgs();
            args.NextPage = typeof(VaultPageView);
            OnChangePage(args);
        }

        public ICommand GoToVaultCommand { get; set; }
    }
}
