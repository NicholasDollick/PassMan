using WPFUserInterface.Views;

namespace WPFUserInterface.Models
{
    class PageCollection
    {
        private LoginPageView _loginPage;
        private RegistrationPageView _registrationPage;
        private MainChatPageView _mainChatPage;


        public PageCollection() { }


        public LoginPageView LoginView { get => _loginPage; set => _loginPage = value; }
        public RegistrationPageView RegistrationView { get => _registrationPage; set => _registrationPage = value; }
        public MainChatPageView MainChatView { get => _mainChatPage; set => _mainChatPage = value; }
    }
}
