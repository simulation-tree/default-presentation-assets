using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RobotoFont : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Fonts/Roboto.ttf";
    }
}
