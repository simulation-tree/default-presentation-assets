using Data;

namespace DefaultPresentationAssets
{
    public readonly struct TextFragmentShader : IDataReference
    {
        static TextFragmentShader()
        {
            EmbeddedAddress.Register<TextFragmentShader>();
        }

        readonly Address IDataReference.Value => "Assets/Shaders/Text.fragment.glsl";
    }
}
