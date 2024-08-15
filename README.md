# Default Presentation Assets
A set of data references that point to assets useful for getting started with rendering and presentations.

### Contents
* Shaders
  * Unlit vertex and fragment shaders
* Materials
  * Unlit with texture and color bindings
* Meshes
  * Quad
  * Cube
  * UV Sphere
  * Icosphere
  * Cylinder
  * Cone
  * Capsule
* Textures
  * Checkerboard
  * Circle
  * Gradient
  * Hexagon
  * Triangle (right angle & equilateral)
* Fonts
  * Roboto
  * Roboto Mono
  * Cascadia Code
  * Cascadia Mono

### Usage
```csharp
using World world = new();
DataRequest<UnlitMaterial> unlit = new(world);
DataRequest<CheckerboardTexture> checkerboard = new(world);
DataRequest<QuadMesh> quad = new(world);
Renderer renderer = new(world, unlit, quad);
```