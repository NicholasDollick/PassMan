using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFUserInterface.Helpers;
using WPFUserInterface.Models;
using WPFUserInterface.Views;

namespace WPFUserInterface.ViewModels
{
    class ApplicationViewModel : BaseViewModel
    {
        private MainWindow mainNavWindow;
        private PageCollection PageCollection;
        private Type currentViewModel;

        /// <summary>
        ///     Constructor. 
        ///         Takes in the main window object as argument. This implementation breaks MVVM standards, 
        ///         but gives a clean navigation approach.
        /// </summary>
        /// <param name="MainWin">our application's main window</param>
        public ApplicationViewModel(MainWindow MainWin)
        {
            this.mainNavWindow = MainWin;

            // this is where the startup proceedure begins to happen

            PageCollection = new PageCollection();
            if (PageCollection.LoginView == null)
            {
                PageCollection.LoginView = (mainNavWindow.Content as LoginPageView);
            }
            currentViewModel = typeof(LoginPageView);

            //Set the event handler "ChangePage" on the current ViewModel to trigger a navigation to another view via "PageChanged" method
            ((LoginViewModel)PageCollection.LoginView.DataContext).ChangePage += PageChanged;

            Application.Current.Dispatcher.Invoke(
                (Action)(() =>
            {
                PageCollection.LoginView.Visibility = Visibility.Visible;
            }));
        }

        private void PageChanged(object sender, ChangePageEventArgs e)
        {
            ClearNavigationHistory();

            if (e.NextPage == typeof(RegistrationPageView))
            {
                if (PageCollection.RegistrationView == null)
                {
                    PageCollection.RegistrationView = new RegistrationPageView();
                    (PageCollection.RegistrationView.DataContext as RegistrationViewModel).ChangePage += PageChanged;
                }
                this.MainNavWindow.Navigate(PageCollection.RegistrationView);
                currentViewModel = e.NextPage;
            }
            if (e.NextPage == typeof(LoginPageView))
            {
                if (PageCollection.LoginView == null)
                {
                    PageCollection.LoginView = new LoginPageView();
                    (PageCollection.LoginView.DataContext as LoginViewModel).ChangePage += PageChanged;
                }
                this.MainNavWindow.Navigate(PageCollection.LoginView);
                currentViewModel = e.NextPage;
            }
            else if (e.NextPage == typeof(MainChatPageView))
            {
                if (PageCollection.MainChatView == null)
                {
                    PageCollection.MainChatView = new MainChatPageView();
                    ((MainChatPageViewModel)PageCollection.MainChatView.DataContext).ChangePage += PageChanged;
                }
                this.MainNavWindow.Navigate(PageCollection.MainChatView);
                currentViewModel = e.NextPage;
                ((MainChatPageViewModel)PageCollection.MainChatView.DataContext).LoadViewModel(e);
            }
            else if (e.NextPage == typeof(VaultPageView))
            {
                if (PageCollection.VaultView == null)
                {
                    PageCollection.VaultView = new VaultPageView();
                    ((VaultPageViewModel)PageCollection.VaultView.DataContext).ChangePage += PageChanged;
                }
                this.MainNavWindow.Navigate(PageCollection.VaultView);
                currentViewModel = e.NextPage;
                ((VaultPageViewModel)PageCollection.VaultView.DataContext).LoadViewModel(e);
            }
            else if (e.NextPage == typeof(GeneratorPageView))
            {
                if (PageCollection.GeneratorView == null)
                {
                    PageCollection.GeneratorView = new GeneratorPageView();
                    ((GeneratorPageViewModel)PageCollection.GeneratorView.DataContext).ChangePage += PageChanged;
                }
                this.MainNavWindow.Navigate(PageCollection.GeneratorView);
                currentViewModel = e.NextPage;
                ((GeneratorPageViewModel)PageCollection.GeneratorView.DataContext).LoadViewModel(e);
            }
            //else if(e.NextPage == typeof(ManageLibraryView))
            //{
            //    if(PageCollection.ManageLibraryView == null)
            //    {
            //        PageCollection.ManageLibraryView = new ManageLibraryView();
            //        ((ManageLibraryViewModel)PageCollection.ManageLibraryView.DataContext).ChangePage += PageChanged;
            //    }
            //    this.MainNavWindow.Navigate(PageCollection.ManageLibraryView);
            //    currentViewModel = e.NextPage;
            //    ((ManageLibraryViewModel)PageCollection.ManageLibraryView.DataContext).LoadViewModel(e);
            //}
        }

        public void ClearNavigationHistory()
        {
            if (!this.MainNavWindow.CanGoBack && !this.MainNavWindow.CanGoForward)
            {
                return;
            }

            var entry = this.MainNavWindow.RemoveBackEntry();
            while (entry != null)
            {
                entry = this.MainNavWindow.RemoveBackEntry();
            }

        }

        #region Properties
        public MainWindow MainNavWindow
        {
            get
            {
                return this.mainNavWindow;
            }
            set
            {
                this.mainNavWindow = value;
            }
        }
        #endregion
    }
}
