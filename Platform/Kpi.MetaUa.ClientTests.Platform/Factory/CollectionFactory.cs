using System;
using Kpi.MetaUa.ClientTests.Model.Platform.Element;
using Kpi.MetaUa.ClientTests.Model.Platform.Locator;
using Kpi.MetaUa.ClientTests.Platform.Element;

namespace Kpi.MetaUa.ClientTests.Platform.Factory
{
    internal static class CollectionFactory
    {
        internal static IHtmlElementsCollection<THtmlElement> Create<THtmlElement>(
            INative parent,
            Locator locator)
            where THtmlElement : IHtmlElement, new() =>
            new HtmlElementsCollection<THtmlElement>(parent, locator);

        internal static object Create(Type type, INative parent, Locator locator)
        {
            var concreteType = typeof(HtmlElementsCollection<>)
                .MakeGenericType(type.GetGenericArguments());
            return Activator.CreateInstance(concreteType, parent, locator);
        }
    }
}
