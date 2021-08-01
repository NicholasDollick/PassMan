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
        private string _pass;
        private int _passLength;
        public GeneratorPageViewModel()
        {
            GoToVaultCommand = new RelayCommand(ChangePageToVault, param => true);
        }

        public override void LoadViewModel(ChangePageEventArgs args)
        {
            GeneratePassword();
        }

        private void ChangePageToVault(object obj)
        {
            ChangePageEventArgs args = new ChangePageEventArgs();
            args.NextPage = typeof(VaultPageView);
            OnChangePage(args);
        }

        // this should eventually take in the pass length lol
        private void GeneratePassword()
        {
            Password = PasswordUtils.GenerateStringPass(10, "all");
        }

        #region Props
        public ICommand GoToVaultCommand { get; set; }
        public ICommand CopyPasswordCommand { get; set; }
        public ICommand ReGenerateCommand { get; set; }
        public string Password
        { 
            get
            {
                return this._pass;
            }
            set
            {
                _pass = value;
                OnPropertyChanged(Password);
            }
        }
        public int PasswordLength
        {
            get
            {
                return this._passLength;
            }
            set
            {
                _passLength = value;
                OnPropertyChanged(Password);
            }
        }
        #endregion
    }
}
