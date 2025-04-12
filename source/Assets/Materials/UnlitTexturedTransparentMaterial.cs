using Data;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedTransparentMaterial : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Materials/UnlitTexturedTransparent.material.json";
    }
}