using Kpi.MetaUa.ClientTests.Model.Platform.WebElements;
using Kpi.MetaUa.ClientTests.Platform.Element;

namespace Kpi.MetaUa.ClientTests.Platform.WebElements
{
    public class HtmlCheckElement : HtmlElement, IHtmlCheckbox
    {
        public void Check()
        {
            if (!IsChecked())
            {
                Click();
            }
        }

        public void Uncheck()
        {
            if (IsChecked())
            {
                Click();
            }
        }

        public void SetValue(bool value)
        {
            if (IsChecked() != value)
            {
                Click();
            }
        }

        public bool IsChecked() => HasClass("checked");
    }
}
