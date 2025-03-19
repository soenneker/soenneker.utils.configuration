using Soenneker.Utils.Configuration.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Utils.Configuration.Tests;

[Collection("Collection")]
public class ConfigurationUtilTests : FixturedUnitTest
{
    private readonly IConfigurationUtil _util;

    public ConfigurationUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IConfigurationUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
