using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct RightTriangleTexture : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Textures/RightTriangle.png";
    }
}
