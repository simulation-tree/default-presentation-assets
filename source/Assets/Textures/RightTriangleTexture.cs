using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct RightTriangleTexture : IDataReference
    {
        static RightTriangleTexture()
        {
            EmbeddedAddress.Register<RightTriangleTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/RightTriangle.png";
    }
}
