using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class MailBoxHeader : HtmlElement
    {
        [FindBy(How.XPath, ".//span")] 
        public HtmlLabel UserLogin { get; set; }
    }
}
