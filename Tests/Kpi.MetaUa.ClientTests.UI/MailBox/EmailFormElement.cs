using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class EmailFormElement : HtmlElement, IEmailFormElement
    {
        [FindBy(How.XPath, "//*[@id='b3_cnt']/div[1]/center[2]/div")]
        private HtmlLabel ErrorMessage { get; set; }

        [FindBy(How.XPath, "//*[@id='send_to']")]
        private HtmlTextBox SendToTextBox { get; set; }

        [FindBy(How.XPath, "//*[@id='subject']")]
        private HtmlTextBox SubjectTextBox { get; set; }

        [FindBy(How.XPath, "//*[@id='body']")] 
        private HtmlTextBox BodyTextBox { get; set; }

        [FindBy(How.XPath, "//*[@id='hc_b3']/div[1]/div[1]/input[2]")]
        private HtmlButton Send { get; set; }

        public string GetErrorMessage()
        {
            return ErrorMessage.GetText().Trim();
        }

        public void SetReceiver(string receiver)
        {
            SendToTextBox.SetText(receiver);
        }

        public void SetSubject(string subject)
        {
            SubjectTextBox.SetText(subject);
        }

        public void SetBody(string emailBody)
        {
            BodyTextBox.SetText(emailBody);
        }

        public void SendEmail()
        {
            Send.Click();
        }
    }
}
