using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CircleTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/Circle.png";
    }
}