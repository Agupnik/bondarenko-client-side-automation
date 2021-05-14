using Kpi.MetaUa.ClientTests.Model.Domain.Login;

namespace Kpi.MetaUa.ClientTests.Domain.Login
{
    public class LoginContext : ILoginContext
    {
        private readonly ILoginSteps _loginSteps;

        public LoginContext(
            ILoginSteps loginSteps)
        {
            _loginSteps = loginSteps;
        }

        public string GetErrorMessage()
        {
            return _loginSteps.GetErrorMessage();
        }

        public void OpenAndLogin(
            UserInformation user)
        {
            _loginSteps.OpenMainView();
            Login(user);
        }

        private void Login(
            UserInformation user)
        {
            _loginSteps.SetLogin(user.Login);
            _loginSteps.SetPassword(user.Password);
            _loginSteps.Login();
        }
    }
}
