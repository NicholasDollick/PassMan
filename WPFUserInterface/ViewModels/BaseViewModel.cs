using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFUserInterface.Helpers;

namespace WPFUserInterface.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public delegate void EventHandler(object sender, ChangePageEventArgs p);
        public event EventHandler ChangePage;

        public BaseViewModel()
        {
            // Init of Inheritred Props

            /*
             * ex:
             * this.ManagePhotos = new RelayCommand(ChangePageToManagePhotos, param => true);
             */
            this.Test = new RelayCommand(TestCommandThing, param => true);
        }

        private void TestCommandThing(object obj)
        {
            MessageBox.Show("hello world");
        }

        protected virtual void OnChangePage(ChangePageEventArgs e)
        {
            EventHandler handler = ChangePage;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }

        public virtual void LoadViewModel(ChangePageEventArgs args)
        {
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #region ChangePage methods
        //public void ChangePageToIntro(object parameter)
        //{
        //    ChangePageEventArgs args = new ChangePageEventArgs();
        //    args.NextPage = typeof(IntroPage);
        //    args.StringProperties = new string[] { this.ActiveReport };
        //    OnChangePage(args);
        //}
        #endregion

        public ICommand Test { get; set; }

    }
}
