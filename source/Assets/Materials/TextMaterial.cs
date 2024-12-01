using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct TextMaterial : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Materials/Text.material.json";
    }
}
