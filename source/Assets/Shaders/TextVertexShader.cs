using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct TextVertexShader : IDataReference
    {
        static TextVertexShader()
        {
            EmbeddedAddress.Register<TextVertexShader>();
        }

        readonly FixedString IDataReference.Value => "Assets/Shaders/Text.vertex.glsl";
    }
}
