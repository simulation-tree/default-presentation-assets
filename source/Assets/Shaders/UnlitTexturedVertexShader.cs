using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedVertexShader : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Shaders/UnlitTextured.fragment.glsl";
    }
}
