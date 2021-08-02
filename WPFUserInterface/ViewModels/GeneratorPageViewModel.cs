using System;
using System.Windows;
using System.Windows.Input;
using WPFUserInterface.Helpers;
using WPFUserInterface.Views;

namespace WPFUserInterface.ViewModels
{
    class GeneratorPageViewModel : BaseViewModel
    {
        private string _pass;
        private int _passLength;
        private bool _isSimple, _isRead, _isAll, _isUpper, _isLower, _isNum, _isSymb;

        // these will have visibility strings to match...eventually
        private bool _isDice, _isString;
        public GeneratorPageViewModel()
        {
            GoToVaultCommand = new RelayCommand(ChangePageToVault, param => true);
            CopyPasswordCommand = new RelayCommand(CopyPassToClip, param => true);
            ReGenerateCommand = new RelayCommand(RegenPass, param => true);

            PasswordLength = 1;
            IsAll = true;
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

        private void GeneratePassword()
        {
            string type = String.Empty;
            // TODO: revisit what is considered to be readable chars...maybe ones you can easily say out loud?
            if (IsAll)
                type = "all";
            if (IsReadable)
                type = "read";
            if (IsSimple)
                type = "simple";

            // this eventually should have the option to modify the charsets are well
            Password = PasswordUtils.GenerateStringPass(PasswordLength, type);
        }

        private void RegenPass(object obj)
        {
            GeneratePassword();
        }

        private void CopyPassToClip(object param)
        {
            try
            {
                Clipboard.SetText(Password);
            }
            catch
            {
                MessageBox.Show("oops");
            }
        }

        #region Props
        public ICommand GoToVaultCommand { get; set; }
        public ICommand CopyPasswordCommand { get; set; }
        public ICommand ReGenerateCommand { get; set; }
        public bool IsUppercase { get; set; }
        public bool IsLowercase { get; set; }
        public bool IsNumbers { get; set; }
        public bool IsSymbols { get; set; }
        public bool IsSimple
        {
            get
            {
                return this._isSimple;
            }
            set
            {
                _isSimple = value;
                OnPropertyChanged("IsSimple");
                GeneratePassword();
            }
        }
        public bool IsReadable
        {
            get
            {
                return this._isRead;
            }
            set
            {
                _isRead = value;
                OnPropertyChanged("IsReadable");
                GeneratePassword();
            }
        }
        public bool IsAll
        {
            get
            {
                return this._isAll;
            }
            set
            {
                _isAll = value;
                OnPropertyChanged("IsAll");
                GeneratePassword();
            }
        }
        public string Password
        { 
            get
            {
                return this._pass;
            }
            set
            {
                _pass = value;
                OnPropertyChanged("Password");
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
                OnPropertyChanged("PasswordLength");
                GeneratePassword();
            }
        }
        #endregion
    }
}
