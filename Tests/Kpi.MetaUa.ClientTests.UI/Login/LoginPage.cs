using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Page;
using Kpi.MetaUa.ClientTests.UI.Search;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.Login
{
    public class LoginPage : WebPage
    {
        public LoginPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, ".//form[@id='loginForm']")]
        public LoginFormElement LoginForm { get; set; }

        [FindBy(How.XPath, ".//form[@id='meta-search']")]
        public SearchElement SearchElement { get; set; }
    }
}
