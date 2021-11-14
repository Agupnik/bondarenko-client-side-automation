using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class EmailFormElement : HtmlElement
    {
        [FindBy(How.XPath, "//div[@id='b3_cnt']//center//div")]
        public HtmlLabel ErrorMessage { get; set; }

        [FindBy(How.XPath, "//textarea[@id='send_to']")]
        public HtmlTextBox SendToTextBox { get; set; }

        [FindBy(How.XPath, "//input[@id='subject']")]
        public HtmlTextBox SubjectTextBox { get; set; }

        [FindBy(How.XPath, "//textarea[@id='body']")] 
        public HtmlTextBox BodyTextBox { get; set; }

        [FindBy(How.XPath, "//input[contains(@class, 'panel_submit')][@name='send']")]
        public HtmlButton SendButton { get; set; }
    }
}
