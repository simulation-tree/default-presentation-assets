using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CubeModel : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Meshes/Cube.obj";
    }
}
