using Kpi.MetaUa.ClientTests.Model.Domain.Search;

namespace Kpi.MetaUa.ClientTests.Domain.Search
{
    public class SearchContext : ISearchContext
    {
        private readonly ISearchSteps _searchSteps;

        public SearchContext(ISearchSteps searchSteps)
        {
            _searchSteps = searchSteps;
        }

        public void OpenAndSetValue(string value)
        {
            _searchSteps.OpenMainView();
            _searchSteps.SetValue(value);
        }
    }
}
