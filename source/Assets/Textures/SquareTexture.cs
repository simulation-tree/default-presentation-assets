using Data;

namespace DefaultPresentationAssets
{
    public readonly struct SquareTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/Square.png";
    }
}