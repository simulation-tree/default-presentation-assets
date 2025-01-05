using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CircleWithOutlineTexture : IDataReference
    {
        static CircleWithOutlineTexture()
        {
            EmbeddedAddress.Register<CircleWithOutlineTexture>();
        }

        readonly Address IDataReference.Value => "Assets/Textures/CircleWithOutline.png";
    }
}
