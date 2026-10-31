using Soenneker.TypesafeAi.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.TypesafeAi.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TypesafeAiOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ITypesafeAiOpenApiHttpClient _httpclient;

    public TypesafeAiOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ITypesafeAiOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
