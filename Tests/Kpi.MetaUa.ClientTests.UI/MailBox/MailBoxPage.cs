using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Page;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public class MailBoxPage : WebPage
    {
        public MailBoxPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, ".//div[@class='topMN']")]
        public MailBoxHeader Header { get; set; }

        [FindBy(How.XPath, "//div[@class='b_c']")]
        public InboxElement Inbox { get; set; }

        [FindBy(How.XPath, "//div[@class='left_panel_block']")]
        public MenuElement Menu { get; set; }

        [FindBy(How.XPath, "//div[@id='b3_cnt']")]
        public EmailFormElement EmailForm { get; set; }
    }
}
