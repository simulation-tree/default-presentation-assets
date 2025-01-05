using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CheckerboardTexture : IDataReference
    {
        static CheckerboardTexture()
        {
            EmbeddedAddress.Register<CheckerboardTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/Checkerboard.png";
    }
}
