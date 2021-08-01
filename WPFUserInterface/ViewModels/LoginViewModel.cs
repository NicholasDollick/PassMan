using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFUserInterface.Helpers;
using WPFUserInterface.Models;
using WPFUserInterface.Views;
using System.Linq;

namespace WPFUserInterface.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        //login command will be defined as a RelayCommand, canExecute tells the command if it can go ahead with the action
        private ICommand _loginCommand;
        private bool _canExecute;

        //username string should be bound to LoginView
        private string _username;

        public LoginViewModel()
        {
            //canExecute = false disables the loginbutton, this will change with implemented input validation
            _canExecute = true;
            LoginCommand = new RelayCommand(AttemptLogin, param => this._canExecute);
            CreateAccountCommand = new RelayCommand(ChangePageToRegistration, param => true);

            this._username = "";
        }


        /// <summary>
        ///     This function gets called by the LoginCommand property bound to the Login button
        /// </summary>
        /// <param name="parameter">Should hold the Passwordbox button. Do not store password, simply pass it to validation authentication.</param>
        public void AttemptLogin(object parameter)
        {
            var passwordBox = parameter as PasswordBox;

            if (ValidateLogin(this.Username, passwordBox.Password))
            {
                if (AuthenticateCredentials(this.Username, passwordBox.Password))
                {
                    ChangePageToVaultView(null);
                }
                else
                {
                    Username = "";
                    passwordBox.Password = "";
                    MessageBox.Show("Invalid username or password, try again.", "Authentication Failure", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
            }
            else
            {
                Username = "";
                passwordBox.Password = "";
                MessageBox.Show("Invalid username or password, try again.", "Invalid Failure", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }


        /// <summary>
        ///     Validates input for username and password fields
        /// </summary>
        /// <param name="username">From Username Field</param>
        /// <param name="pwd">From PasswordBox</param>
        /// <returns>
        ///     Result of validation
        /// </returns>
        private bool ValidateLogin(string username, string pwd)
        {
            //return true; // for demo
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(pwd))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        ///     Authenticates user's credentials
        /// </summary>
        /// <param name="username">From Username field</param>
        /// <param name="password">From Password field</param>
        /// <returns>Authenticates credentials</returns>
        private bool AuthenticateCredentials(string username, string pwd)
        {
            bool authenticate = false;


            using (QNTMDBEntities db = new QNTMDBEntities())
            {
                var selectedUser = (from u in db.Users select u).Where(u => u.username == this.Username).FirstOrDefault();
                if (selectedUser != null)
                {
                    // sends the entered password to be validated against the hash that is stored in db
                    if (CryptUtils.validatePassword(pwd, selectedUser.password))
                    {
                        authenticate = true;
                    }
                }
            }

            return authenticate;
        }

        public void ChangePageToRegistration(object param)
        {
            ChangePageEventArgs args = new ChangePageEventArgs();
            args.NextPage = typeof(RegistrationPageView);
            OnChangePage(args);
        }
        public void ChangePageToVaultView(object param)
        {
            ChangePageEventArgs args = new ChangePageEventArgs();
            args.NextPage = typeof(GeneratorPageView);
            OnChangePage(args);
        }

        #region Props
        /// <summary>
        /// Setters and Getters for the properties
        /// </summary>
        public string Username
        {
            get
            {
                return this._username;
            }

            set
            {
                this._username = value;
                OnPropertyChanged(Username);
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return this._loginCommand;
            }

            set
            {
                this._loginCommand = value;
            }
        }
        public ICommand CreateAccountCommand { get; set; }
        #endregion
    }
}
