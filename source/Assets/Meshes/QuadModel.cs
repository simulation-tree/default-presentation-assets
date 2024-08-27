using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct QuadModel : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Meshes/Quad.obj";
    }
}
