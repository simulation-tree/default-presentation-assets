using Data;

namespace DefaultPresentationAssets
{
    public readonly struct QuadModel : IEmbeddedResource
    {
        readonly Address IEmbeddedResource.Address => "Assets/Meshes/Quad.obj";
    }
}