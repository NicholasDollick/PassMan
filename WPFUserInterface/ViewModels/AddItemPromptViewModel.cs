using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            var passwords = (object[])param;
            if (string.IsNullOrEmpty(Username))
                return;
            try
            {

                using (QNTMDBEntities db = new QNTMDBEntities())
                {
                    Entry toAdd = new Entry()
                    {
                        name = Name,
                        url = Url,
                        note = Notes,
                        username = Username,
                        //password = CryptUtils.CreatePBKDF2Hash((passwords[0] as PasswordBox).Password)
                    };

                    db.Entries.Add(toAdd);
                    db.SaveChanges();
                }
                //if ((passwords[0] as PasswordBox).Password.Equals((passwords[1] as PasswordBox).Password))
                //{
                //    // do the register thing


                //    //MessageBox.Show("User Added! :D");
                //    // redirect to smething here
                //    //ChangePageToLogin(null);
                //}
                //else
                //{
                //    //Username = "";
                //    //(passwords[0] as PasswordBox).Password = "";
                //    //(passwords[1] as PasswordBox).Password = "";
                //    //MessageBox.Show("These dont match yo");
                //}

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
