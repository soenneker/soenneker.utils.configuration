using Soenneker.Utils.Configuration.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Utils.Configuration.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class ConfigurationUtilTests : HostedUnitTest
{
    private readonly IConfigurationUtil _util;

    public ConfigurationUtilTests(Host host) : base(host)
    {
        _util = Resolve<IConfigurationUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
