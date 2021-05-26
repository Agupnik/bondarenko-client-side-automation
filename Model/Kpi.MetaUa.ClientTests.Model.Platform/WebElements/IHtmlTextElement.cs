using Kpi.MetaUa.ClientTests.Model.Platform.Element;

namespace Kpi.MetaUa.ClientTests.Model.Platform.WebElements
{
    public interface IHtmlTextElement : IHtmlElement
    {
        void SetText(string text);

        string GetValue();

        string GetPlaceholder();
    }
}
