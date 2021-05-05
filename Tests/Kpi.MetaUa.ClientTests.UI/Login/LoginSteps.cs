using Kpi.MetaUa.ClientTests.Model.Domain.Login;
using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Platform.Configuration.Environment;
using Kpi.MetaUa.ClientTests.Platform.Factory;

namespace Kpi.MetaUa.ClientTests.UI.Login
{
    public class LoginSteps : StepsBase, ILoginSteps
    {
        private readonly IWebDriver _webDriver;

        public LoginSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }

        private LoginFormElement LoginForm => PageFactory.Get<LoginPage>(_webDriver).LoginForm;

        public void SetLogin(string login)
        {
            LoginForm.SetLogin(login);
        }

        public void SetPassword(string password)
        {
            LoginForm.SetPassword(password);
        }

        public void Login()
        {
            LoginForm.Login();
        }

        public string GetErrorMessage()
        {
            return LoginForm.ErrorMessage.GetText().Trim();
        }
    }
}
