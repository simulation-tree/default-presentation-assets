using Data;

namespace DefaultPresentationAssets
{
    public readonly struct TextVertexShader : IDataReference
    {
        static TextVertexShader()
        {
            EmbeddedAddress.Register<TextVertexShader>();
        }

        readonly Address IDataReference.Value => "Assets/Shaders/Text.vertex.glsl";
    }
}
