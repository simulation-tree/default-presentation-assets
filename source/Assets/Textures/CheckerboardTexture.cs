using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CheckerboardTexture : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Textures/Checkerboard.png";
    }
}
