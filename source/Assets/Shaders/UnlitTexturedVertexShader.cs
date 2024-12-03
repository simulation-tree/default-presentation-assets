using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedVertexShader : IDataReference
    {
        static UnlitTexturedVertexShader()
        {
            EmbeddedAddress.Register<UnlitTexturedVertexShader>();
        }

        readonly FixedString IDataReference.Value => "Assets/Shaders/UnlitTextured.fragment.glsl";
    }
}
