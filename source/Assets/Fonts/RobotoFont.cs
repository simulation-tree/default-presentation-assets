using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RobotoFont : IDataReference
    {
        static RobotoFont()
        {
            EmbeddedAddress.Register<RobotoFont>();
        }

        readonly Address IDataReference.Value => "Assets/Fonts/Roboto.ttf";
    }
}
