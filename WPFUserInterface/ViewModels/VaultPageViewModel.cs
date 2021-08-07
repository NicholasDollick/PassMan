using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFUserInterface.Helpers;
using WPFUserInterface.Models;
using WPFUserInterface.Views;

namespace WPFUserInterface.ViewModels
{
    class VaultPageViewModel : BaseViewModel
    {
        private ObservableCollection<VaultItem> items;
        private ICommand selectedEntryChanged;
        private object _selectedItem;
        private string _searchTerm;

        public VaultPageViewModel() : base()
        {
            GoToGeneratorCommand = new RelayCommand(ChangePageToGenerator, param => true);
            AddNewEntryCommand = new RelayCommand(AddNewEntry, param => true);
            RefreshItems = new RelayCommand(test, param => true);
            SelectedEntryChanged = new RelayCommand(OnSelectedEntryChanged, param => true);
            OpenURLCommand = new RelayCommand(OpenURL, param => true);
            CopyURLCommand = new RelayCommand(CopyURL, param => true);
            CopyUsernameCommand = new RelayCommand(CopyUsername, param => true);
            CopyPasswordCommand = new RelayCommand(CopyPassword, param => true);
            RevealPasswordCommand = new RelayCommand(ShowPassword, param => true);
            DetailsInfoVis = "Hidden";
            PasswordVisibility = "Collapsed";
            PasswordBoxVisibility = "Visible";
            Password = "";
            //SearchTerm = "";
        }

        public override void LoadViewModel(ChangePageEventArgs args)
        {
            VaultItems = new ObservableCollection<VaultItem>();
            using (QNTMDBEntities db = new QNTMDBEntities())
            {
                var entries = (from e in db.Entries select e).Where(u => u.userId == SessionInfo.CurrentUserID);
                foreach (var item in entries)
                {
                    VaultItems.Add(
                        new VaultItem()
                        {
                            Username = item.username,
                            EntryName = item.name,
                            Password = item.password,
                            URL = item.url,
                            Note = item.note,
                            EntryVisibility = "Collapsed"
                        }
                        );
                }
            }
        }

        private void OnSelectedEntryChanged(object obj)
        {
            if (SelectedItem == null)
                return;

            var item = SelectedItem as VaultItem;
            var passBox = obj as PasswordBox;
            RefreshList(item);
            DetailsInfoVis = "Visible";
            OnPropertyChanged("DetailsInfoVis");
            EntryName = item.EntryName;
            EntryUrl = item.URL;
            EntryNotes = item.Note;
            EntryUsername = item.Username;
            passBox.Password = CryptUtils.DecryptWithWindowsAcc(item.Password);
            OnPropertyChanged("EntryName");
            OnPropertyChanged("EntryUrl");
            OnPropertyChanged("EntryNotes");
            OnPropertyChanged("EntryUsername");
        }

        // TODO: rename this lol
        private void test(object obj)
        {
            VaultItems = new ObservableCollection<VaultItem>();
            using (QNTMDBEntities db = new QNTMDBEntities())
            {
                var entries = (from e in db.Entries select e).Where(u => u.userId == SessionInfo.CurrentUserID);
                foreach (var item in entries)
                {
                    VaultItems.Add(
                        new VaultItem()
                        {
                            Username = item.username,
                            EntryName = item.name,
                            Password = item.password,
                            URL = item.url,
                            Note = item.note,
                            EntryVisibility = "Collapsed"
                        }
                        );
                }
            }
        }

        private void RefreshList(VaultItem toChange)
        {
            VaultItems = new ObservableCollection<VaultItem>();
            using (QNTMDBEntities db = new QNTMDBEntities())
            {
                var entries = (from e in db.Entries select e).Where(u => u.userId == SessionInfo.CurrentUserID);
                foreach (var item in entries)
                {
                    if (item.name.Equals(toChange.EntryName) && item.username.Equals(toChange.Username))
                    {
                        VaultItems.Add(
                            new VaultItem()
                            {
                                Username = item.username,
                                EntryName = item.name,
                                Password = item.password,
                                URL = item.url,
                                Note = item.note,
                                EntryVisibility = "Visible"
                            }
                            );
                    }
                    else
                    {
                        VaultItems.Add(
                            new VaultItem()
                            {
                                Username = item.username,
                                EntryName = item.name,
                                Password = item.password,
                                URL = item.url,
                                Note = item.note,
                                EntryVisibility = "Collapsed"
                            }
                            );
                    }

                }
            }
        }

        private void ShowPassword(object obj)
        {
            if(PasswordVisibility.Equals("Visible"))
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
                Clipboard.SetText(EntryUsername);
            }
            catch { }
        }

        private void CopyURL(object obj)
        {
            try
            {
                Clipboard.SetText(EntryUrl);
            }
            catch { }
        }

        private void OpenURL(object obj)
        {
            try
            {
                var urlToOpen = "http://" + EntryUrl;
                var sInfo = new System.Diagnostics.ProcessStartInfo(urlToOpen)
                {
                    UseShellExecute = true,
                };
                System.Diagnostics.Process.Start(sInfo);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewEntry(object obj)
        {
            if(ApplicationViewModel.AddItemPopupManager != null || ApplicationViewModel.AddItemPopupManager.Count < 1)
            {
                PopupWindowFactory factory = new PopupWindowFactory();
                factory.CreateNewEntityPopup(RefreshItems);
            }
        }

        private void ChangePageToGenerator(object obj)
        {
            ChangePageEventArgs args = new ChangePageEventArgs();
            args.NextPage = typeof(GeneratorPageView);
            OnChangePage(args);
        }

        #region PROPS
        public ICommand GoToGeneratorCommand { get; set; }
        public ICommand AddNewEntryCommand { get; set; }
        public ICommand RefreshItems { get; set; }
        public ICommand OpenURLCommand { get; set; }
        public ICommand CopyURLCommand { get; set; }
        public ICommand CopyUsernameCommand { get; set; }
        public ICommand CopyPasswordCommand { get; set; }
        public ICommand RevealPasswordCommand { get; set; }
        public string DetailsInfoVis { get; set; }
        public string EntryName { get; set; }
        public string EntryUrl { get; set; }
        public string EntryUsername { get; set; }
        public string EntryPassword { get; set; }
        public string EntryNotes { get; set; }
        public string Password { get; set; }
        public string PasswordVisibility { get; set; }
        public string PasswordBoxVisibility { get; set; }
        public ObservableCollection<VaultItem> VaultItems
        {
            get => this.items;
            set
            {
                SetField(ref this.items, value, "VaultItems");

                if (value == null)
                    return;

                this.items.CollectionChanged += ((object sender, NotifyCollectionChangedEventArgs args) =>
                {
                    OnPropertyChanged("VaultItems");
                });
            }
        }
        public ICommand SelectedEntryChanged
        {
            get
            {
                return this.selectedEntryChanged;
            }
            set
            {
                this.selectedEntryChanged = value;
            }
        }

        public object SelectedItem
        {
            get
            {
                return this._selectedItem;
            }
            set
            {
                SetField(ref this._selectedItem, value, "SelectedItem");
            }
        }

        public string SearchTerm
        {
            get
            {
                return this._searchTerm;
            }
            set
            {
                if(_searchTerm != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        RefreshList(new VaultItem { EntryName = "", URL = "", Username = ""});
                    }
                    else
                    {
                        // apply the search filter here
                    }
                }
                _searchTerm = value;
                OnPropertyChanged("SearchTerm");
            }
        }

        #endregion

    }
}
