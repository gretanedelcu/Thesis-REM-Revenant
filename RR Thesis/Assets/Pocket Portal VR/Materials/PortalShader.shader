Shader "Portals/PortalShader" {
    Properties{
        [HDR] _LeftTex("Left Texture", 2D) = "white" {}
        [HDR] _RightTex("Right Texture", 2D) = "white" {}
        [Toggle] _RecursiveRender("Recursive Render", Float) = 0
    }

        SubShader{
            Tags {
                "LightMode" = "ForwardBase"
                "RenderType" = "Opaque"
            }

            Pass {
                Cull Off
                ZWrite Off
                ZTest Always

                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                #pragma target 3.0

                #include "UnityCG.cginc"
                #include "Lighting.cginc"

                sampler2D _LeftTex;
                sampler2D _RightTex;

                struct vertexInput {
                    float4 vertex : POSITION;
                    float3 normal : NORMAL;
                    float4 texCoord : TEXCOORD0;
                };

                struct vertexOutput {
                    float4 pos : SV_POSITION;
                    float4 screenPos : TEXCOORD2;
                    UNITY_FOG_COORDS(1)
                };

                float _RecursiveRender;

                vertexOutput vert(vertexInput v) {
                    vertexOutput o;
                    o.pos = UnityObjectToClipPos(v.vertex);
                    o.screenPos = ComputeScreenPos(o.pos);
                    UNITY_TRANSFER_FOG(o, o.pos);
                    return o;
                }

                fixed4 frag(vertexOutput i) : SV_Target {
                    float2 screenUV = i.screenPos.xy / i.screenPos.w;
                    bool leftEye;

                    #ifdef UNITY_SINGLE_PASS_STEREO
                        leftEye = unity_StereoEyeIndex == 0;
                    #else
                        leftEye = (unity_CameraProjection[0][2] <= 0);
                    #endif

                    fixed4 col;
                    if (leftEye || _RecursiveRender == 1) {
                        col = tex2D(_LeftTex, screenUV);
                    }
                    else {
                        col = tex2D(_RightTex, screenUV);
                    }

                    UNITY_APPLY_FOG(i.fogCoord, col);
                    return col;
                }
                ENDCG
            }
        }
}
