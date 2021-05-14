using FluentAssertions;
using Kpi.MetaUa.ClientTests.Model.Domain.Search;
using TechTalk.SpecFlow;

namespace Kpi.MetaUa.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Search")]
    public class SearchDefinition
    {
        private readonly ISearchContext _searchContext;

        public SearchDefinition(
            ISearchContext searchContext)
        {
            _searchContext = searchContext;
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
            _searchContext.Search();
        }

        [Then(@"I see '(.*)' search results")]
        public void ThenISeeSearchResults(
            string text)
        {
            _searchContext.SearchResultStatisticsText().Should().BeEquivalentTo(
                text);
        }
    }
}