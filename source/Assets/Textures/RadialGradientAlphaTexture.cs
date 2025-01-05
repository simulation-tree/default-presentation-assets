using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RadialGradientAlphaTexture : IDataReference
    {
        static RadialGradientAlphaTexture()
        {
            EmbeddedAddress.Register<RadialGradientAlphaTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/RadialGradientAlpha.png";
    }
}
