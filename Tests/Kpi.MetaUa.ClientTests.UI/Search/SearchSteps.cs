using Kpi.MetaUa.ClientTests.Model.Domain.Search;
using Kpi.MetaUa.ClientTests.Platform.Configuration.Environment;
using Kpi.MetaUa.ClientTests.Platform.Factory;
using Kpi.MetaUa.ClientTests.UI.Login;
using IWebDriver = Kpi.MetaUa.ClientTests.Model.Platform.Drivers.IWebDriver;

namespace Kpi.MetaUa.ClientTests.UI.Search
{
    public class SearchSteps : StepsBase, ISearchSteps
    {
        private readonly IWebDriver _webDriver;

        public SearchSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
            : base(webDriver, environmentConfiguration)
        {
            _webDriver = webDriver;
        }

        private SearchElement SearchElement => PageFactory.Get<LoginPage>(_webDriver).SearchElement;

        private SearchPage SearchPage => PageFactory.Get<SearchPage>(_webDriver);

        public void SetValue(string value)
        {
            SearchElement.SetValue(value);
        }

        public void Search()
        {
            SearchElement.Search();
        }

        public string SearchResultStatisticsText()
        {
            SwitchToNewTab();
            return SearchPage.SearchResultStatisticsText.GetText().Trim();
        }
    }
}
