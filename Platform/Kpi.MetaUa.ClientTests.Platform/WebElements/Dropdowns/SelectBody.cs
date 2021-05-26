using System.Linq;
using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.MetaUa.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectBody : HtmlElement
    {
        public SelectOption[] SelectOptions =>
            FindAll<SelectOption>(new Locator(How.XPath, ".//et-select-body-option"))
                .ToArray();
    }
}
