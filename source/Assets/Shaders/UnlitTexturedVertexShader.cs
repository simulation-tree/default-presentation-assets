using Data;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedVertexShader : IDataReference
    {
        static UnlitTexturedVertexShader()
        {
            EmbeddedAddress.Register<UnlitTexturedVertexShader>();
        }

        readonly Address IDataReference.Value => "Assets/Shaders/UnlitTextured.fragment.glsl";
    }
}
