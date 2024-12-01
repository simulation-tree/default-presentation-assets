using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct SquareTexture : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Textures/Square.png";
    }
}
