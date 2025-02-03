using Data;

namespace DefaultPresentationAssets
{
    public readonly struct TextMaterial : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Materials/Text.material.json";
    }
}
