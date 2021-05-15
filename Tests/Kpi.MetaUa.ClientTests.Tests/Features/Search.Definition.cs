using FluentAssertions;
using Kpi.MetaUa.ClientTests.Model.Domain.Search;
using TechTalk.SpecFlow;

namespace Kpi.MetaUa.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Search")]
    public class SearchDefinition
    {
        private readonly ISearchContext _searchContext;
        private readonly ISearchSteps _searchSteps;

        public SearchDefinition(
            ISearchContext searchContext,
            ISearchSteps searchSteps)
        {
            _searchContext = searchContext;
            _searchSteps = searchSteps;
        }

        [Given(@"I have (.*) as search query text")]
        public void GivenIHaveAsSearchQueryText(
            string text)
        {
            _searchContext.OpenAndSetValue(
                text);
        }

        [When(@"I searching")]
        public void WhenISearching()
        {
            _searchSteps.Search();
        }

        [Then(@"I see '(.*)' search results")]
        public void ThenISeeSearchResults(
            string text)
        {
            _searchContext.GetSearchResultStatisticsText().Should().BeEquivalentTo(
                text);
        }
    }
}