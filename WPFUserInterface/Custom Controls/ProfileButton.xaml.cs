using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFUserInterface.Custom_Controls
{
    /// <summary>
    /// Interaction logic for ProfileButton.xaml
    /// </summary>
    public partial class ProfileButton : UserControl
    {
        public ProfileButton()
        {
            InitializeComponent();
        }

        public SolidColorBrush StrokeBrush
        {
            get { return (SolidColorBrush)GetValue(StrokeBrushProperty); }
            set { SetValue(StrokeBrushProperty, value); }
        }

        public static readonly DependencyProperty StrokeBrushProperty =
                DependencyProperty.Register("StrokeBrush", typeof(SolidColorBrush), typeof(ProfileButton));


        public bool IsOnline
        {
            get { return (bool)GetValue(IsOnlineProperty); }
            set { SetValue(IsOnlineProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOnlineProperty =
            DependencyProperty.Register("IsOnline", typeof(bool), typeof(ProfileButton));


        public string DisplayLetters
        {
            get { return (string)GetValue(LettersToDisplayProperty); }
            set { SetValue(LettersToDisplayProperty, value); }
        }

        public static readonly DependencyProperty LettersToDisplayProperty =
       DependencyProperty.Register("DisplayLetters", typeof(string), typeof(ProfileButton));


        public ImageSource ProfileImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ProfileImageSource", typeof(ImageSource), typeof(ProfileButton));
    }
}
