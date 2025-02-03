using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CheckerboardTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/Checkerboard.png";
    }
}