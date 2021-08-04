using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

            PasswordLength = 8;
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
            Password = GenerateStringPass(PasswordLength, type);
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

        private string GenerateStringPass(int passLength, string passType)
        {
            string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "0123456789";
            string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
            string AllChar = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

            string useSet = string.Empty;

            // TODO: revisit what is considered to be readable chars...maybe ones you can easily say out loud?
            if (passType.Equals("all"))
                useSet = AllChar;
            else if (passType.Equals("read"))
                useSet = "QWERTYUIPASDFGHJKLZXCVBNMqwertyuiopasdfghjkzxcvbnm23456789!@#$%^&*()-_=+<,>.";
            else if (passType.Equals("simple"))
                useSet = CapitalLetters + SmallLetters;
            else
                return "";

            StringBuilder sb = new StringBuilder();
            for (int n = 0; n < passLength; n++)
            {
                sb = sb.Append(GenerateChar(useSet));
            }

            return sb.ToString();
        }

        private char GenerateChar(string availableChars)
        {
            var byteArray = new byte[1];
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            char c;
            do
            {
                provider.GetBytes(byteArray);
                c = (char)byteArray[0];

            } while (!availableChars.Any(x => x == c));

            return c;
        }

        #region Props
        public ICommand GoToVaultCommand { get; set; }
        public ICommand CopyPasswordCommand { get; set; }
        public ICommand ReGenerateCommand { get; set; }
        public bool IsUppercase { get; set; }
        public bool IsLowercase { get; set; }
        public bool IsNumbers { get; set; }
        public bool IsSymbols { get; set; }
        public bool IsDice
        {
            get
            {
                return this._isDice;
            }
            set
            {
                _isDice = value;
                OnPropertyChanged("IsDice");
                // change a visibility prop to hide the checkboxes for random string
            }
        }
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
