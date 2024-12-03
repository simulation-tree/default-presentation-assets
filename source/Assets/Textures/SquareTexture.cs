using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct SquareTexture : IDataReference
    {
        static SquareTexture()
        {
            EmbeddedAddress.Register<SquareTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/Square.png";
    }
}
