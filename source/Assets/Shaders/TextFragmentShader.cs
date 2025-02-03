using Data;

namespace DefaultPresentationAssets
{
    public readonly struct TextFragmentShader : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Shaders/Text.fragment.glsl";
    }
}