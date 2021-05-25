using Kpi.MetaUa.ClientTests.Model.Platform.Drivers;
using Kpi.MetaUa.ClientTests.Platform.Configuration.Environment;

namespace Kpi.MetaUa.ClientTests.UI
{
    public class StepsBase
    {
        private protected readonly IWebDriver WebDriver;
        private readonly IEnvironmentConfiguration _environmentConfiguration;

        protected StepsBase(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
        {
            WebDriver = webDriver;
            _environmentConfiguration = environmentConfiguration;
        }

        public void OpenMainView() =>
            WebDriver.Get(_environmentConfiguration.EnvironmentUri);

        protected void SwitchToNewTab() =>
            WebDriver.SwitchToNewTab();
    }
}
