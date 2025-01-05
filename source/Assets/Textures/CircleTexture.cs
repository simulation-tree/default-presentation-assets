using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CircleTexture : IDataReference
    {
        static CircleTexture()
        {
            EmbeddedAddress.Register<CircleTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/Circle.png";
    }
}
