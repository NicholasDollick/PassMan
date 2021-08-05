using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public VaultPageViewModel() : base()
        {
            GoToGeneratorCommand = new RelayCommand(ChangePageToGenerator, param => true);
            AddNewEntryCommand = new RelayCommand(AddNewEntry, param => true);
            RefreshItems = new RelayCommand(test, param => true);
            SelectedEntryChanged = new RelayCommand(OnSelectedEntryChanged, param => true);
        }

        private void OnSelectedEntryChanged(object obj)
        {
            if (SelectedItem == null)
                return;

            RefreshList(SelectedItem as VaultItem);
        }

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
                                EntryVisibility = "Collapsed"
                            }
                            );
                    }

                }
            }
        }

        public override void LoadViewModel(ChangePageEventArgs args)
        {
            VaultItems = new ObservableCollection<VaultItem>();
            using (QNTMDBEntities db = new QNTMDBEntities())
            {
                var entries = (from e in db.Entries select e).Where(u => u.userId == SessionInfo.CurrentUserID);
                foreach(var item in entries)
                {
                    VaultItems.Add(
                        new VaultItem()
                        {
                            Username = item.username,
                            EntryName = item.name,
                            EntryVisibility = "Collapsed"
                        }
                        );
                }
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
                //value.EntryVisibility = "Visible";
                //var x = VaultItems.Where(i => i == value).FirstOrDefault();
                //x.EntryVisibility = "Visible";
                SetField(ref this._selectedItem, value, "SelectedItem");
            }
        }

        #endregion

    }
}
