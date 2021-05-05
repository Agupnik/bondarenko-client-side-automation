using System.Collections.Generic;

namespace Kpi.MetaUa.ClientTests.Model.Platform.Element
{
    public interface IHtmlElementsCollection<out THtmlElement> : IEnumerable<THtmlElement>
        where THtmlElement : IHtmlElement
    {
    }
}
