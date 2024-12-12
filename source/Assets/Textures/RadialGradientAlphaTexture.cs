using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct RadialGradientAlphaTexture : IDataReference
    {
        static RadialGradientAlphaTexture()
        {
            EmbeddedAddress.Register<RadialGradientAlphaTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/RadialGradientAlpha.png";
    }
}
