using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CircleWithOutlineTexture : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Textures/CircleWithOutline.png";
    }
}