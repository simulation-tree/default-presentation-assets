using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CheckerboardTexture : IDataReference
    {
        static CheckerboardTexture()
        {
            EmbeddedAddress.Register<CheckerboardTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/Checkerboard.png";
    }
}
