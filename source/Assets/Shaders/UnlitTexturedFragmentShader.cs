using Data;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedFragmentShader : IDataReference
    {
        static UnlitTexturedFragmentShader()
        {
            EmbeddedAddress.Register<UnlitTexturedFragmentShader>();
        }

        readonly Address IDataReference.Value => "Assets/Shaders/UnlitTextured.vertex.glsl";
    }
}
