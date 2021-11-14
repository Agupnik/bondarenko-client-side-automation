using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Page;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.Search
{
    public class SearchPage : WebPage
    {
        public SearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//div[@id='resInfo-0']")]
        public HtmlLabel SearchResultStatisticsText { get; set; }
    }
}
