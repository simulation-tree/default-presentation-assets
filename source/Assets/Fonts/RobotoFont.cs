using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct RobotoFont : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Fonts/Roboto.ttf";
    }
}
