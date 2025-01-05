using Data;

namespace DefaultPresentationAssets
{
    public readonly struct TriangleTexture : IDataReference
    {
        static TriangleTexture()
        {
            EmbeddedAddress.Register<TriangleTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/Triangle.png";
    }
}
