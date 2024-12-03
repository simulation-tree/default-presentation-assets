using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct TextMaterial : IDataReference
    {
        static TextMaterial()
        {
            EmbeddedAddress.Register<TextMaterial>();
            EmbeddedAddress.Register<TextFragmentShader>();
            EmbeddedAddress.Register<TextVertexShader>();
        }

        readonly FixedString IDataReference.Value => "Assets/Materials/Text.material.json";
    }
}
