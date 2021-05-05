using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectOption : HtmlElement
    {
        [FindBy(How.XPath, ".//span")] 
        public HtmlLabel Name { get; set; }
    }
}
