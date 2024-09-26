#version 450

layout(location = 0) in vec4 fragColor;
layout(location = 1) in vec2 uv;

layout(binding = 0) uniform sampler2D fontAtlas;

layout(location = 0) out vec4 outColor;

void main() {
    vec4 textureColor = texture(fontAtlas, uv);
    float alpha = textureColor.x;
    if (alpha <= 0.08) discard;

    outColor = alpha * fragColor;
}