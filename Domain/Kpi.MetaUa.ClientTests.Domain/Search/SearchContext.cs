using Kpi.MetaUa.ClientTests.Model.Domain.Search;

namespace Kpi.MetaUa.ClientTests.Domain.Search
{
    public class SearchContext : ISearchContext
    {
        private readonly ISearchSteps _searchSteps;

        public SearchContext(
            ISearchSteps searchSteps)
        {
            _searchSteps = searchSteps;
        }

        public void OpenAndSetValue(string value)
        {
            _searchSteps.OpenMainView();
            _searchSteps.SetValue(value);
        }

        public void Search()
        {
            _searchSteps.Search();
        }

        public string SearchResultStatisticsText()
        {
            return _searchSteps.SearchResultStatisticsText().Substring(
                0, _searchSteps.SearchResultStatisticsText().LastIndexOf(":"));
        }
    }
}
