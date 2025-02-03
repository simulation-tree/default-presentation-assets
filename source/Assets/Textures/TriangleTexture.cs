using Data;

namespace DefaultPresentationAssets
{
    public readonly struct TriangleTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/Triangle.png";
    }
}