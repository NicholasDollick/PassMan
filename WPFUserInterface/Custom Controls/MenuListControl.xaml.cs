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

namespace WPFUserInterface.Custom_Controls
{
    /// <summary>
    /// Interaction logic for MenuListControl.xaml
    /// </summary>
    public partial class MenuListControl : UserControl
    {
        public MenuListControl()
        {
            InitializeComponent();
        }

        public ICommand ButtonClick
        {
            get { return (ICommand)GetValue(ButtonClickedProperty); }
            set { SetValue(ButtonClickedProperty, value); }
        }

        public static readonly DependencyProperty ButtonClickedProperty = DependencyProperty.Register(
            "ButtonClick", typeof(ICommand),
            typeof(MenuListControl)
            );

        public MenuItem Test
        {
            get { return (MenuItem)GetValue(TestProperty); }
            set { SetValue(TestProperty, value); }
        }

        public static readonly DependencyProperty TestProperty = DependencyProperty.Register(
            "Test", typeof(MenuItem),
            typeof(MenuListControl)
            );

    }
}
