using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CubeModel : IDataReference
    {
        static CubeModel()
        {
            EmbeddedAddress.Register<CubeModel>();
        }

        readonly Address IDataReference.Value => "Assets/Meshes/Cube.obj";
    }
}
