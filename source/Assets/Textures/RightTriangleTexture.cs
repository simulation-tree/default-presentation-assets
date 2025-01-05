using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RightTriangleTexture : IDataReference
    {
        static RightTriangleTexture()
        {
            EmbeddedAddress.Register<RightTriangleTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/RightTriangle.png";
    }
}
