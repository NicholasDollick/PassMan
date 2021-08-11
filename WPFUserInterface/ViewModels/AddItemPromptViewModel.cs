using System;
using System.Data.Entity.Validation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFUserInterface.Helpers;
using WPFUserInterface.Models;

namespace WPFUserInterface.ViewModels
{
    class AddItemPromptViewModel : BaseViewModel
    {
        ICommand _cmd;
        public AddItemPromptViewModel(ICommand cmd)
        {
            AddNewEntryCommand = new RelayCommand(AddNew, param => true);
            CopyUsernameCommand = new RelayCommand(CopyUsername, param => true);
            CopyPasswordCommand = new RelayCommand(CopyPassword, param => true);
            RevealPasswordCommand = new RelayCommand(ShowPassword, param => true);
            _cmd = cmd;
            PasswordVisibility = "Collapsed";
            PasswordBoxVisibility = "Visible";
            Password = "";
        }
        public AddItemPromptViewModel()
        {
            AddNewEntryCommand = new RelayCommand(AddNew, param => true);
        }

        private void AddNew(object param)
        {
            var password = (param as PasswordBox).Password;
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password))
                return;
            try
            {

                using (QNTMDBEntities db = new QNTMDBEntities())
                {
                    Entry toAdd = new Entry()
                    {
                        userId = SessionInfo.CurrentUserID,
                        name = Name,
                        url = Url,
                        note = Notes,
                        username = Username,
                        password = CryptUtils.EncryptWithWindowsAcc(password)
                    };

                    db.Entries.Add(toAdd);
                    db.SaveChanges();
                    _cmd.Execute(null);
                    ApplicationViewModel.AddItemPopupManager[0].Close();
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
        private void ShowPassword(object obj)
        {
            if (PasswordVisibility.Equals("Visible"))
            {
                Password = "";
                PasswordBoxVisibility = "Visible";
                PasswordVisibility = "Collapsed";
                OnPropertyChanged("PasswordBoxVisibility");
                OnPropertyChanged("PasswordVisibility");
                OnPropertyChanged("Password");
            }
            else
            {
                Password = (obj as PasswordBox).Password;
                PasswordBoxVisibility = "Collapsed";
                PasswordVisibility = "Visible";
                OnPropertyChanged("PasswordBoxVisibility");
                OnPropertyChanged("PasswordVisibility");
                OnPropertyChanged("Password");
            }
        }

        private void CopyPassword(object obj)
        {
            try
            {
                Clipboard.SetText((obj as PasswordBox).Password);
            }
            catch { }
        }

        private void CopyUsername(object obj)
        {
            try
            {
                Clipboard.SetText(Username);
            }
            catch { }
        }


        #region Props
        public ICommand AddNewEntryCommand { get; set; }
        public ICommand RevealPasswordCommand { get; set; }
        public ICommand CopyPasswordCommand { get; set; }
        public ICommand CopyUsernameCommand { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }
        public string PasswordVisibility { get; set; }
        public string PasswordBoxVisibility { get; set; }
        #endregion
    }
}
