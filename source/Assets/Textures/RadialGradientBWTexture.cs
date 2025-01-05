using Data;

namespace DefaultPresentationAssets
{
    public readonly struct RadialGradientBWTexture : IDataReference
    {
        static RadialGradientBWTexture()
        {
            EmbeddedAddress.Register<RadialGradientBWTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/RadialGradientBW.png";
    }
}
