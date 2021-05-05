using Kpi.MetaUa.ClientTests.Model.Domain.UserInfo;
using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Platform.Factory;
using Kpi.MetaUa.ClientTests.UI.MailBox;

namespace Kpi.MetaUa.ClientTests.UI.UserInfo
{
    public class UserInfoSteps : IUserInfoSteps
    {
        private readonly IWebDriver _webDriver;

        public UserInfoSteps(
            IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private MailBoxPage MailBoxPage => PageFactory.Get<MailBoxPage>(_webDriver);

        public string GetUserLogin()
        {
            return MailBoxPage.Header.UserLogin.GetText().Trim();
        }
    }
}
