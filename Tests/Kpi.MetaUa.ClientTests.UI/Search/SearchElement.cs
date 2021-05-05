using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using Kpi.MetaUa.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.UI.Search
{
    public class SearchElement : HtmlElement, ISearchElement
    {
        [FindBy(How.XPath, ".//input[@id='id_search_in_ukraine']")]
        private HtmlTextBox SearchHtmlTextBox { get; set; }

        [FindBy(How.XPath, ".//span[@class='btn2']/input")]
        private HtmlButton SearchButton { get; set; }

        public void SetValue(string value)
        {
            SearchHtmlTextBox.SetText(value);
        }

        public void Search()
        {
            SearchButton.Click();
        }

        public void Search(string value)
        {
            SetValue(value);
            Search();
        }
    }
}
