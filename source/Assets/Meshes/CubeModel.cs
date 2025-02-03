using Data;

namespace DefaultPresentationAssets
{
    public readonly struct CubeModel : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Meshes/Cube.obj";
    }
}