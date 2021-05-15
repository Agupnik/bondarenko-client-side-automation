using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class InboxElement : HtmlElement
    {
        [FindBy(How.XPath, "//tr[not(@id='offer_row')][2]/td[5]/a")]
        public HtmlLabel LastMailTitle { get; set; }
    }
}
