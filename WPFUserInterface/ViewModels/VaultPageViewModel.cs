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
    class VaultPageViewModel : BaseViewModel
    {
        public ICommand GoToGeneratorCommand { get; set; }
        public VaultPageViewModel()
        {
            GoToGeneratorCommand = new RelayCommand(ChangePageToGenerator, param => true);
        }


        public override void LoadViewModel(ChangePageEventArgs args)
        {

        }

        private void ChangePageToGenerator(object obj)
        {
            ChangePageEventArgs args = new ChangePageEventArgs();
            args.NextPage = typeof(GeneratorPageView);
            OnChangePage(args);
        }

    }
}
