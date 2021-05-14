using Kpi.MetaUa.ClientTests.Model.Domain.SendEmail;
using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Platform.Configuration.Environment;
using Kpi.MetaUa.ClientTests.Platform.Factory;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class SendEmailSteps : StepsBase, ISendEmailSteps
    {
        private readonly IWebDriver _webDriver;

        public SendEmailSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }

        private MailBoxPage MailBoxPage => PageFactory.Get<MailBoxPage>(_webDriver);

        public void OpenEmailForm()
        {
            MailBoxPage.Menu.SendEmailButtonClick();
        }

        public void SetReceiver(
            string receiver)
        {
            MailBoxPage.EmailForm.SetReceiver(
                receiver);
        }

        public void SetSubject(
            string subject)
        {
            MailBoxPage.EmailForm.SetSubject(
                subject);
        }

        public void SetBody(
            string body)
        {
            MailBoxPage.EmailForm.SetBody(
                body);
        }

        public string GetLastEmailTitle()
        {
            return MailBoxPage.Inbox.GetLastMailTitle();
        }

        public string GetErrorMessage()
        {
            return MailBoxPage.EmailForm.GetErrorMessage();
        }

        public void SendEmail()
        {
            MailBoxPage.EmailForm.SendEmail();
        }
    }
}
