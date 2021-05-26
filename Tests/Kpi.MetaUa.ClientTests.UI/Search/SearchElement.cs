using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.Search
{
    public class SearchElement : HtmlElement
    {
        [FindBy(How.XPath, ".//input[@id='id_search_in_ukraine']")]
        public HtmlTextBox SearchTextBox { get; set; }

        [FindBy(How.XPath, ".//span[@class='btn2']/input")]
        public HtmlButton SearchButton { get; set; }
    }
}
