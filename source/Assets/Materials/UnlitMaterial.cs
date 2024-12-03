using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedMaterial : IDataReference
    {
        static UnlitTexturedMaterial()
        {
            EmbeddedAddress.Register<UnlitTexturedMaterial>();
            EmbeddedAddress.Register<UnlitTexturedFragmentShader>();
            EmbeddedAddress.Register<UnlitTexturedVertexShader>();
        }

        readonly FixedString IDataReference.Value => "Assets/Materials/UnlitTextured.material.json";
    }
}
