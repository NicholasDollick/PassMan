using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFUserInterface.Views
{
    /// <summary>
    /// Interaction logic for CustomNavigationMenu.xaml
    /// </summary>
    public partial class CustomNavigationMenu : UserControl
    {
        public CustomNavigationMenu()
        {
            InitializeComponent();
        }

        #region Intro
        public static readonly DependencyProperty IntroProperty =
            DependencyProperty.Register(
                "Intro",
                typeof(ICommand),
                typeof(CustomNavigationMenu),
                new UIPropertyMetadata(null));
        public ICommand Intro
        {
            get
            {
                return (ICommand)GetValue(IntroProperty);
            }
            set
            {
                SetValue(IntroProperty, value);
            }
        }
        #endregion

    }
}
