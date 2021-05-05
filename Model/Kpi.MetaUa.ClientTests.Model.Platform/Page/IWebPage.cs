using Kpi.MetaUa.ClientTests.Model.Platform.Element;

namespace Kpi.MetaUa.ClientTests.Model.Platform.Page
{
    public interface IWebPage : ISearchable, INative
    {
        string Address { get; set; }

        string Title { get; set; }

        void Open();

        void Refresh();
    }
}
