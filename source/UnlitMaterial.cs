using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedMaterial : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Materials/UnlitTextured.material.json";
    }
}
