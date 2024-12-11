using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct RadialGradientBWTexture : IDataReference
    {
        static RadialGradientBWTexture()
        {
            EmbeddedAddress.Register<RadialGradientBWTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/RadialGradientBW.png";
    }
}
