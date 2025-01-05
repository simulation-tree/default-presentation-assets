using Data;

namespace DefaultPresentationAssets
{
    public readonly struct SquareTexture : IDataReference
    {
        static SquareTexture()
        {
            EmbeddedAddress.Register<SquareTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/Square.png";
    }
}
