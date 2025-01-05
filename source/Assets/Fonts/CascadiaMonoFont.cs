using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CascadiaMonoFont : IDataReference
    {
        static CascadiaMonoFont()
        {
            EmbeddedAddress.Register<CascadiaMonoFont>();
        }

        readonly Address IDataReference.Value => "Assets/Fonts/CascadiaMono.ttf";
    }
}
