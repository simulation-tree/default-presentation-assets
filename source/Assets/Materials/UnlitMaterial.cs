using Data;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedMaterial : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Materials/UnlitTextured.material.json";
    }
}