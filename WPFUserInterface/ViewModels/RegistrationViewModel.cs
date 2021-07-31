using System;
using System.Data.Entity.Validation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFUserInterface.Views;
using WPFUserInterface.Helpers;
using WPFUserInterface.Models;

namespace WPFUserInterface.ViewModels
{
    class RegistrationViewModel : BaseViewModel
    {
        //login command will be defined as a RelayCommand, canExecute tells the command if it can go ahead with the action
        private ICommand _registerCommand;
        private bool _canExecute;

        //username string should be bound to LoginView
        private string _username;
        public RegistrationViewModel()
        {
            _canExecute = true;
            RegisterCommand = new RelayCommand(AttemptRegister, param => this._canExecute);
            CreateAccountCommand = new RelayCommand(ChangePageToLogin, param => true);

            this._username = "";
        }

        private void AttemptRegister(object param)
        {
            // todo: maybe move this after validation
            var passwords = (object[])param;
            if (string.IsNullOrEmpty(Username))
                return;
            try
            {
                if((passwords[0] as PasswordBox).Password.Equals((passwords[1] as PasswordBox).Password))
                {
                    // do the register thing
                    using (QNTMDBEntities db = new QNTMDBEntities())
                    {
                        User userToAdd = new User()
                        {
                            username = Username,
                            password = CryptUtils.CreatePBKDF2Hash((passwords[0] as PasswordBox).Password)
                        };

                        db.Users.Add(userToAdd);
                        db.SaveChanges();
                    }

                    MessageBox.Show("User Added! :D");
                    // redirect to smething here
                    ChangePageToLogin(null);
                }
                else
                {
                    Username = "";
                    (passwords[0] as PasswordBox).Password = "";
                    (passwords[1] as PasswordBox).Password = "";
                    MessageBox.Show("These dont match yo");
                }
                   
            }
            catch (DbEntityValidationException x)
            {
                foreach (var errors in x.EntityValidationErrors)
                {
                    foreach (var validationError in errors.ValidationErrors)
                    {
                        MessageBox.Show(validationError.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.InnerException);
                return;
            }
        }

        private void ChangePageToLogin(object obj)
        {
            ChangePageEventArgs args = new ChangePageEventArgs();
            args.NextPage = typeof(LoginPageView);
            OnChangePage(args);
        }

        #region Props
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

        public ICommand RegisterCommand
        {
            get
            {
                return this._registerCommand;
            }

            set
            {
                this._registerCommand = value;
            }
        }
        public ICommand CreateAccountCommand { get; set; }
        #endregion
    }
}
