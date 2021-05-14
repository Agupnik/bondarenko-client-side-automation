namespace Kpi.MetaUa.ClientTests.Model.Domain.Search
{
    public interface ISearchSteps
    {
        void SetValue(
            string value);

        void Search();

        string SearchResultStatisticsText();

        void OpenMainView();
    }
}
