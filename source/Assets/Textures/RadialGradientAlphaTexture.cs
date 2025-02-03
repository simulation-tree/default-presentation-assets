using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RadialGradientAlphaTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/RadialGradientAlpha.png";
    }
}