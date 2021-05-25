using Kpi.MetaUa.ClientTests.Model.Domain.Login;
using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Platform.Configuration.Environment;
using Kpi.MetaUa.ClientTests.Platform.Factory;

namespace Kpi.MetaUa.ClientTests.UI.Login
{
    public class LoginSteps : StepsBase, ILoginSteps
    {
        public LoginSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private LoginFormElement LoginForm => 
            PageFactory.Get<LoginPage>(WebDriver).LoginForm;

        public void SetLogin(string login)
        {
            LoginForm.LoginTextBox.SetText(login);
        }

        public void SetPassword(string password)
        {
            LoginForm.PasswordTextBox.SetText(password);
        }

        public void Login()
        {
            LoginForm.LoginButton.Click();
        }

        public string GetErrorMessage()
        {
            return LoginForm.ErrorMessage.GetText().Trim();
        }
    }
}
