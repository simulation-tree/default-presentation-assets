using Data;

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

        readonly Address IDataReference.Value => "Assets/Materials/Text.material.json";
    }
}
