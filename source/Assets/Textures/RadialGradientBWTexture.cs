using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RadialGradientBWTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/RadialGradientBW.png";
    }
}