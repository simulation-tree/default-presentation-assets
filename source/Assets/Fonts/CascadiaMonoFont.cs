using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CascadiaMonoFont : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Fonts/CascadiaMono.ttf";
    }
}
