using System;

namespace Kpi.MetaUa.ClientTests.Model.Platform.Drivers
{
    public interface IWebDriver : IDisposable
    {
        void Get(string url);

        void Close();

        void Refresh();

        void SwitchToNewTab();
    }
}
