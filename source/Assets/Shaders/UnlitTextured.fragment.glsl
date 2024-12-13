#version 450

layout(location = 0) in vec4 fragColor;
layout(location = 1) in vec2 uv;
layout(binding = 1) uniform sampler2D mainTexture;

layout(location = 0) out vec4 outColor;

mat4 threshold = mat4
(
    1.0 / 17.0,   9.0 / 17.0,   3.0 / 17.0,   11.0 / 17.0,
    13.0 / 17.0,  5.0 / 17.0,   15.0 / 17.0,  7.0 / 17.0,
    4.0 / 17.0,   12.0 / 17.0,  2.0 / 17.0,   10.0 / 17.0,
    16.0 / 17.0,  8.0 / 17.0,   14.0 / 17.0,  6.0 / 17.0
);

void main() {
    vec4 textureColor = texture(mainTexture, uv);
    float alpha = textureColor.a;
    int x = int(gl_FragCoord.x - 0.5);
    int y = int(gl_FragCoord.y - 0.5);
    if (alpha * fragColor.a < threshold[x % 4][y % 4])
        discard;

    textureColor.a = 1;
    outColor = textureColor * fragColor;
}