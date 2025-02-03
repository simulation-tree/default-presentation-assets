using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CascadiaMonoFont : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Fonts/CascadiaMono.ttf";
    }
}
