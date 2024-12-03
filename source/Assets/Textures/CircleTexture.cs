using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CircleTexture : IDataReference
    {
        static CircleTexture()
        {
            EmbeddedAddress.Register<CircleTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/Circle.png";
    }
}
