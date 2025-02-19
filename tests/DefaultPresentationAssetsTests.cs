using Data;
using Unmanaged.Tests;

namespace DefaultPresentationAssets.Tests
{
    public abstract class DefaultPresentationAssetsTests : UnmanagedTests
    {
        static DefaultPresentationAssetsTests()
        {
            EmbeddedResourceRegistry.Load<DefaultPresentationAssetsDataBank>();
        }
    }
}