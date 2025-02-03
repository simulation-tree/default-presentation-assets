using Data;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedVertexShader : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Shaders/UnlitTextured.fragment.glsl";
    }
}