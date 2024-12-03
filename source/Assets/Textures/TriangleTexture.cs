using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct TriangleTexture : IDataReference
    {
        static TriangleTexture()
        {
            EmbeddedAddress.Register<TriangleTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/Triangle.png";
    }
}
