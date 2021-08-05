using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFUserInterface.Helpers;
using WPFUserInterface.Models;

namespace WPFUserInterface.ViewModels
{
    class AddItemPromptViewModel : BaseViewModel
    {
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
                        // this needs a userid
                        userId = SessionInfo.CurrentUserID,
                        name = Name,
                        url = Url,
                        note = Notes,
                        username = Username,
                        password = CryptUtils.EncryptWithWindowsAcc(password)
                    };

                    db.Entries.Add(toAdd);
                    db.SaveChanges();
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


    #region Props
    public ICommand AddNewEntryCommand { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }
        #endregion
    }
}
