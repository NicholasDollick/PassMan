
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using WPFUserInterface.ViewModels;

namespace WPFUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error opening program!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InitAfterLoad()
        {
            this.DataContext = new ApplicationViewModel(this);
        }

        private void QNTMWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() => InitAfterLoad()), DispatcherPriority.ContextIdle, null);
        }

        protected override void OnClosed(EventArgs args)
        {
            base.OnClosed(args);
            //System.Windows.Application.Current.Shutdown();
        }

        private void QNTMWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("If you close QNTM, any unsaved test results will be lost.", "Attention!", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

            if (res == MessageBoxResult.OK)
            {

            }
            if (res == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void NavigationWindow_Deactivated(object sender, EventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
