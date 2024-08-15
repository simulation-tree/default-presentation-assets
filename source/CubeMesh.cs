using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CubeMesh : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Meshes/Cube.obj";
    }
}
