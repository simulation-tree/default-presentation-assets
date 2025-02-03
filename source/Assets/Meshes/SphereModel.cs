using Data;

namespace DefaultPresentationAssets
{
    public readonly struct SphereModel : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Meshes/Sphere.obj";
    }
}