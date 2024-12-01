using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedFragmentShader : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Shaders/UnlitTextured.vertex.glsl";
    }
}
