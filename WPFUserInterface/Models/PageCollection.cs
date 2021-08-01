using WPFUserInterface.Views;

namespace WPFUserInterface.Models
{
    class PageCollection
    {
        private LoginPageView _loginPage;
        private RegistrationPageView _registrationPage;
        private MainChatPageView _mainChatPage;
        private VaultPageView _vaultPage;
        private GeneratorPageView _passGenPage;
        


        public PageCollection() { }


        public LoginPageView LoginView { get => _loginPage; set => _loginPage = value; }
        public RegistrationPageView RegistrationView { get => _registrationPage; set => _registrationPage = value; }
        public MainChatPageView MainChatView { get => _mainChatPage; set => _mainChatPage = value; }
        public VaultPageView VaultView { get => _vaultPage; set => _vaultPage = value; }
        public GeneratorPageView GeneratorView { get => _passGenPage; set => _passGenPage = value; }
    }
}
