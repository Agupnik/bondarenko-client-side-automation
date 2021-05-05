using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class MenuElement : HtmlElement, IMenuElement
    {
        [FindBy(How.XPath, ".//a[@id='id_send_email']")]
        private HtmlButton SearchHtmlTextBox { get; set; }

        public void SendEmailButtonClick()
        {
            SearchHtmlTextBox.Click();
        }
    }
}
