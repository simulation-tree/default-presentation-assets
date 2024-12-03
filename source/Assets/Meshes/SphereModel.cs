using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct SphereModel : IDataReference
    {
        static SphereModel()
        {
            EmbeddedAddress.Register<SphereModel>();
        }

        readonly FixedString IDataReference.Value => "Assets/Meshes/Sphere.obj";
    }
}
