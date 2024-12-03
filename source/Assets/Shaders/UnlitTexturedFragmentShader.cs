using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedFragmentShader : IDataReference
    {
        static UnlitTexturedFragmentShader()
        {
            EmbeddedAddress.Register<UnlitTexturedFragmentShader>();
        }

        readonly FixedString IDataReference.Value => "Assets/Shaders/UnlitTextured.vertex.glsl";
    }
}
