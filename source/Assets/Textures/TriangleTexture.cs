using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct TriangleTexture : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Textures/Triangle.png";
    }
}
