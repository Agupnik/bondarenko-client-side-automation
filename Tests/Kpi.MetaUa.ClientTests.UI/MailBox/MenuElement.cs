using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class MenuElement : HtmlElement
    {
        [FindBy(How.XPath, ".//a[@id='id_send_email']")]
        public HtmlButton WriteEmailButton { get; set; }
    }
}
