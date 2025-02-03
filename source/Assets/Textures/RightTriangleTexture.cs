using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RightTriangleTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/RightTriangle.png";
    }
}