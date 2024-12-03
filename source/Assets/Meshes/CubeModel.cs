using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct CubeModel : IDataReference
    {
        static CubeModel()
        {
            EmbeddedAddress.Register<CubeModel>();
        }

        readonly FixedString IDataReference.Value => "Assets/Meshes/Cube.obj";
    }
}
