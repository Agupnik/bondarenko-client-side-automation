using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.Login
{
    public class LoginFormElement : HtmlElement
    {
        [FindBy(How.XPath, ".//input[@id='login-field']")]
        public HtmlTextBox LoginTextBox { get; set; }

        [FindBy(How.XPath, ".//input[@id='pass-field']")]
        public HtmlTextBox PasswordTextBox { get; set; }

        [FindBy(How.XPath, ".//input[@id='loginbtnua']")]
        public HtmlButton LoginButton { get; set; }

        [FindBy(How.XPath, ".//font")] 
        public HtmlLabel ErrorMessage { get; set; }
    }
}
