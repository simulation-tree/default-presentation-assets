using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct QuadMesh : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Meshes/Quad.obj";
    }
}
