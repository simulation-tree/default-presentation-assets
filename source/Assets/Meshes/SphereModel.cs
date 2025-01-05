using Data;

namespace DefaultPresentationAssets
{
    public readonly struct SphereModel : IDataReference
    {
        static SphereModel()
        {
            EmbeddedAddress.Register<SphereModel>();
        }

        readonly Address IDataReference.Value => "Assets/Meshes/Sphere.obj";
    }
}
