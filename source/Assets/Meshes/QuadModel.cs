using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct QuadModel : IDataReference
    {
        static QuadModel()
        {
            EmbeddedAddress.Register<QuadModel>();
        }

        readonly FixedString IDataReference.Value => "Assets/Meshes/Quad.obj";
    }
}
