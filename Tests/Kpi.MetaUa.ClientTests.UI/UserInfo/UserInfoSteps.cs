using Kpi.MetaUa.ClientTests.Model.Domain.UserInfo;
using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Platform.Configuration.Environment;
using Kpi.MetaUa.ClientTests.Platform.Factory;
using Kpi.MetaUa.ClientTests.UI.MailBox;

namespace Kpi.MetaUa.ClientTests.UI.UserInfo
{
    public class UserInfoSteps : StepsBase, IUserInfoSteps
    {
        public UserInfoSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private MailBoxPage MailBoxPage => 
            PageFactory.Get<MailBoxPage>(WebDriver);

        public string GetUserLogin()
        {
            return MailBoxPage.Header.UserLogin.GetText().Trim();
        }
    }
}
