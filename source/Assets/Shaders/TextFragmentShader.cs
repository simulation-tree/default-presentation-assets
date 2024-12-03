using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct TextFragmentShader : IDataReference
    {
        static TextFragmentShader()
        {
            EmbeddedAddress.Register<TextFragmentShader>();
        }

        readonly FixedString IDataReference.Value => "Assets/Shaders/Text.fragment.glsl";
    }
}
