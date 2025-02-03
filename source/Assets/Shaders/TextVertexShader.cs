using Data;

namespace DefaultPresentationAssets
{
    public readonly struct TextVertexShader : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Shaders/Text.vertex.glsl";
    }
}