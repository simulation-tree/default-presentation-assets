using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CircleWithOutlineTexture : IDataReference
    {
        static CircleWithOutlineTexture()
        {
            EmbeddedAddress.Register<CircleWithOutlineTexture>();
        }

        readonly FixedString IDataReference.Value => "Assets/Textures/CircleWithOutline.png";
    }
}
