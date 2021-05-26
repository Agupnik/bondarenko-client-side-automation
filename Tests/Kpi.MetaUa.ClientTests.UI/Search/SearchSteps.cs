using System;
using Kpi.MetaUa.ClientTests.Model.Domain.Search;
using Kpi.MetaUa.ClientTests.Platform.Configuration.Environment;
using Kpi.MetaUa.ClientTests.Platform.Factory;
using Kpi.MetaUa.ClientTests.UI.Login;
using IWebDriver = Kpi.MetaUa.ClientTests.Model.Platform.Drivers.IWebDriver;

namespace Kpi.MetaUa.ClientTests.UI.Search
{
    public class SearchSteps : StepsBase, ISearchSteps
    {
        public SearchSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
        }

        private SearchElement SearchElement => 
            PageFactory.Get<LoginPage>(WebDriver).SearchElement;

        private SearchPage SearchPage => 
            PageFactory.Get<SearchPage>(WebDriver);

        public void SetValue(string value)
        {
            SearchElement.SearchTextBox.SetText(value);
        }

        public void Search()
        {
            SearchElement.SearchButton.Click();
        }

        public string SearchResultStatisticsText()
        {
            SwitchToNewTab();
            var searchStatistic = SearchPage.SearchResultStatisticsText.GetText().Trim();
            return searchStatistic.Substring(
                0,
                searchStatistic.LastIndexOf(
                    ":",
                    StringComparison.Ordinal));
        }
    }
}
