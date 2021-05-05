using Kpi.MetaUa.ClientTests.Model.Domain.Run;

namespace Kpi.MetaUa.ClientTests.Platform.Configuration.Run
{
    public interface IRunSettings
    {
        SeleniumGrid SeleniumGrid { get; set; }

        RunType RunType { get; set; }
    }
}
