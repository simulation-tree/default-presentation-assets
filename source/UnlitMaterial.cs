using Data;
using Unmanaged;

namespace DefaultPresentationAssets
{
    public readonly struct UnlitTexturedMaterial : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Materials/UnlitTextured.material.json";
    }

    public readonly struct UnlitTexturedVertexShader : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Shaders/UnlitTextured.fragment.glsl";
    }

    public readonly struct UnlitTexturedFragmentShader : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Shaders/UnlitTextured.vertex.glsl";
    }

    public readonly struct CheckerboardTexture : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Textures/Checkerboard.png";
    }

    public readonly struct SquareTexture : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Textures/Square.png";
    }

    public readonly struct CircleTexture : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Textures/Circle.png";
    }

    public readonly struct QuadMesh : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Meshes/Quad.obj";
    }

    public readonly struct CubeMesh : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Meshes/Cube.obj";
    }

    public readonly struct CascadiaMonoFont : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Fonts/Cascadia Mono.ttf";
    }

    public readonly struct RobotoFont : IDataReference
    {
        FixedString IDataReference.Value => "*/Assets/Fonts/Roboto.ttf";
    }
}
