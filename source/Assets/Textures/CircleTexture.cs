using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CircleTexture : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Textures/Circle.png";
    }
}
