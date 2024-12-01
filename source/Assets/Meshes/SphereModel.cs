using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct SphereModel : IDataReference
    {
        FixedString IDataReference.Value => "Assets/Meshes/Sphere.obj";
    }
}
