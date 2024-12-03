using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CascadiaMonoFont : IDataReference
    {
        static CascadiaMonoFont()
        {
            EmbeddedAddress.Register<CascadiaMonoFont>();
        }

        readonly FixedString IDataReference.Value => "Assets/Fonts/CascadiaMono.ttf";
    }
}
