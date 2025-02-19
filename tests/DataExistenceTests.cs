using Data;

namespace DefaultPresentationAssets.Tests
{
    public class DataExistenceTests : DefaultPresentationAssetsTests
    {
        [Test]
        public void VerifyTexturesExist()
        {
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<CheckerboardTexture>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<CircleTexture>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<TriangleTexture>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<SquareTexture>()), Is.True);
        }

        [Test]
        public void VerifyModelsExist()
        {
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<CubeModel>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<SphereModel>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<QuadModel>()), Is.True);
        }

        [Test]
        public void VerifyFontsExist()
        {
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<CascadiaMonoFont>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<RobotoFont>()), Is.True);
        }

        [Test]
        public void VerifyShadersExist()
        {
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<TextFragmentShader>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<TextVertexShader>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<UnlitTexturedFragmentShader>()), Is.True);
            Assert.That(EmbeddedResourceRegistry.Contains(EmbeddedResource.GetAddress<UnlitTexturedVertexShader>()), Is.True);
        }
    }
}