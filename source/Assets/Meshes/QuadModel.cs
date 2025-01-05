using Data;

namespace DefaultPresentationAssets
{
    public readonly struct QuadModel : IDataReference
    {
        static QuadModel()
        {
            EmbeddedAddress.Register<QuadModel>();
        }

        readonly Address IDataReference.Value => "Assets/Meshes/Quad.obj";
    }
}
