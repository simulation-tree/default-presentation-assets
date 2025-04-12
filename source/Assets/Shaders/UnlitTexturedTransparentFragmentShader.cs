using Data;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedTransparentFragmentShader : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Shaders/UnlitTexturedTransparent.fragment.glsl";
    }
}