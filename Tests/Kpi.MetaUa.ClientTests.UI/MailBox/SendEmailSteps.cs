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
            MailBoxPage.Menu.WriteEmailButton.Click();
        }

        public void SetReceiver(
            string receiver)
        {
            MailBoxPage.EmailForm.SendToTextBox.SetText(
                receiver);
        }

        public void SetSubject(
            string subject)
        {
            MailBoxPage.EmailForm.SubjectTextBox.SetText(
                subject);
        }

        public void SetBody(
            string body)
        {
            MailBoxPage.EmailForm.BodyTextBox.SetText(
                body);
        }

        public string GetLastEmailTitle()
        {
            return MailBoxPage.Inbox.LastMailTitle.GetText();
        }

        public string GetErrorMessage()
        {
            return MailBoxPage.EmailForm.ErrorMessage.GetText();
        }

        public void SendEmail()
        {
            MailBoxPage.EmailForm.SendButton.Click();
        }
    }
}
