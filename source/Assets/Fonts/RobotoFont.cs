using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct RobotoFont : IDataReference
    {
        static RobotoFont()
        {
            EmbeddedAddress.Register<RobotoFont>();
        }

        readonly FixedString IDataReference.Value => "Assets/Fonts/Roboto.ttf";
    }
}
