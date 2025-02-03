using Data;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedFragmentShader : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Shaders/UnlitTextured.vertex.glsl";
    }
}