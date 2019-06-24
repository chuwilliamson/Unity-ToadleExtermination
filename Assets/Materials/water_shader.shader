// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:34949,y:32752,varname:node_2865,prsc:2|diff-357-OUT,spec-5425-OUT,gloss-9746-OUT,alpha-4022-OUT,voffset-687-OUT,tess-1178-OUT;n:type:ShaderForge.SFN_Color,id:6665,x:32953,y:32238,ptovrint:False,ptlb:ColorB,ptin:_ColorB,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Slider,id:358,x:35412,y:32767,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_358,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:1813,x:35412,y:32867,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:4909,x:33355,y:32358,varname:node_4909,prsc:2|A-5588-RGB,B-6665-RGB,T-372-OUT;n:type:ShaderForge.SFN_Color,id:5588,x:32953,y:32054,ptovrint:False,ptlb:ColorA,ptin:_ColorA,varname:node_5588,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Vector1,id:1064,x:34018,y:33666,varname:node_1064,prsc:2,v1:0;n:type:ShaderForge.SFN_DepthBlend,id:324,x:32380,y:32868,varname:node_324,prsc:2|DIST-270-OUT;n:type:ShaderForge.SFN_ValueProperty,id:270,x:32126,y:32868,ptovrint:False,ptlb:Depth,ptin:_Depth,varname:node_270,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Dot,id:1756,x:32364,y:32996,varname:node_1756,prsc:2,dt:4|A-4267-OUT,B-8203-OUT;n:type:ShaderForge.SFN_ViewVector,id:4267,x:32126,y:32996,varname:node_4267,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:8203,x:32126,y:33143,prsc:2,pt:False;n:type:ShaderForge.SFN_Clamp01,id:372,x:32890,y:32867,varname:node_372,prsc:2|IN-200-OUT;n:type:ShaderForge.SFN_Divide,id:200,x:32625,y:32868,varname:node_200,prsc:2|A-324-OUT,B-1756-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:2799,x:32931,y:33050,varname:node_2799,prsc:2|IN-372-OUT,IMIN-3605-OUT,IMAX-9019-OUT,OMIN-8316-OUT,OMAX-8523-OUT;n:type:ShaderForge.SFN_Vector1,id:8316,x:32663,y:33249,varname:node_8316,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:8523,x:32663,y:33313,varname:node_8523,prsc:2,v1:1;n:type:ShaderForge.SFN_Slider,id:3605,x:32519,y:33070,ptovrint:False,ptlb:FoamMin,ptin:_FoamMin,varname:node_3605,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:9019,x:32519,y:33164,ptovrint:False,ptlb:FoamMax,ptin:_FoamMax,varname:node_9019,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:6110,x:33878,y:33444,varname:node_6110,prsc:2|IN-372-OUT,IMIN-6106-OUT,IMAX-6531-OUT,OMIN-7689-OUT,OMAX-5197-OUT;n:type:ShaderForge.SFN_Slider,id:6106,x:33149,y:33372,ptovrint:False,ptlb:DepthMin,ptin:_DepthMin,varname:node_6106,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:6531,x:33149,y:33471,ptovrint:False,ptlb:DepthMax,ptin:_DepthMax,varname:node_6531,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Vector1,id:7689,x:33306,y:33565,varname:node_7689,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:5197,x:33306,y:33637,varname:node_5197,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:6295,x:34376,y:33103,varname:node_6295,prsc:2|A-5497-OUT,B-418-OUT;n:type:ShaderForge.SFN_ComponentMask,id:5497,x:34390,y:32800,varname:node_5497,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-1758-OUT;n:type:ShaderForge.SFN_Vector1,id:418,x:34390,y:32937,varname:node_418,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Clamp01,id:4022,x:34771,y:33010,varname:node_4022,prsc:2|IN-3661-OUT;n:type:ShaderForge.SFN_Clamp01,id:5569,x:33102,y:33050,varname:node_5569,prsc:2|IN-2799-OUT;n:type:ShaderForge.SFN_Multiply,id:3866,x:35778,y:32755,varname:node_3866,prsc:2;n:type:ShaderForge.SFN_Clamp01,id:1758,x:34122,y:32994,varname:node_1758,prsc:2|IN-4120-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5939,x:33502,y:32892,ptovrint:False,ptlb:FoamPower,ptin:_FoamPower,varname:node_5939,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:8;n:type:ShaderForge.SFN_Add,id:2845,x:34383,y:32435,varname:node_2845,prsc:2|A-4909-OUT,B-1758-OUT;n:type:ShaderForge.SFN_Clamp01,id:357,x:34624,y:32552,varname:node_357,prsc:2|IN-2845-OUT;n:type:ShaderForge.SFN_Add,id:3661,x:34571,y:33191,varname:node_3661,prsc:2|A-6295-OUT,B-6110-OUT;n:type:ShaderForge.SFN_OneMinus,id:3900,x:33286,y:33050,varname:node_3900,prsc:2|IN-5569-OUT;n:type:ShaderForge.SFN_Slider,id:1178,x:34553,y:33340,ptovrint:False,ptlb:Tesselation,ptin:_Tesselation,varname:node_1178,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Tex2d,id:2099,x:33097,y:33632,ptovrint:False,ptlb:WaveDistortion,ptin:_WaveDistortion,varname:node_2099,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ce95613732f0edc498a0cae8db5a031c,ntxv:0,isnm:False|UVIN-9044-UVOUT;n:type:ShaderForge.SFN_Panner,id:9044,x:32858,y:33632,varname:node_9044,prsc:2,spu:0.5,spv:0.5|UVIN-8713-UVOUT,DIST-9257-OUT;n:type:ShaderForge.SFN_TexCoord,id:8713,x:32583,y:33592,varname:node_8713,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:4801,x:32308,y:33659,varname:node_4801,prsc:2;n:type:ShaderForge.SFN_FragmentPosition,id:6203,x:32149,y:33922,varname:node_6203,prsc:2;n:type:ShaderForge.SFN_Sin,id:3003,x:32847,y:33940,varname:node_3003,prsc:2|IN-4906-OUT;n:type:ShaderForge.SFN_RemapRange,id:9118,x:33466,y:33940,varname:node_9118,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-1650-OUT;n:type:ShaderForge.SFN_Add,id:9768,x:32438,y:33926,varname:node_9768,prsc:2|A-6203-X,B-9257-OUT;n:type:ShaderForge.SFN_Multiply,id:4906,x:32634,y:33940,varname:node_4906,prsc:2|A-9768-OUT,B-3531-OUT;n:type:ShaderForge.SFN_Multiply,id:900,x:33058,y:33940,varname:node_900,prsc:2|A-3003-OUT,B-7328-OUT;n:type:ShaderForge.SFN_Add,id:1650,x:33270,y:33940,varname:node_1650,prsc:2|A-900-OUT,B-4578-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3531,x:32472,y:34116,ptovrint:False,ptlb:WaveCount,ptin:_WaveCount,varname:node_3531,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_ValueProperty,id:7328,x:32975,y:34141,ptovrint:False,ptlb:WaveSpread,ptin:_WaveSpread,varname:node_7328,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_ValueProperty,id:4578,x:33204,y:34141,ptovrint:False,ptlb:WaveWidth,ptin:_WaveWidth,varname:node_4578,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Multiply,id:1014,x:33504,y:33687,varname:node_1014,prsc:2|A-2099-R,B-9118-OUT;n:type:ShaderForge.SFN_Multiply,id:5208,x:33840,y:33761,varname:node_5208,prsc:2|A-1014-OUT,B-8156-OUT;n:type:ShaderForge.SFN_Slider,id:8156,x:33676,y:34004,ptovrint:False,ptlb:WaveHeight,ptin:_WaveHeight,varname:node_8156,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Append,id:6985,x:34103,y:33778,varname:node_6985,prsc:2|A-1064-OUT,B-5208-OUT;n:type:ShaderForge.SFN_Append,id:687,x:34384,y:33832,varname:node_687,prsc:2|A-6985-OUT,B-7470-OUT;n:type:ShaderForge.SFN_Vector1,id:7470,x:34176,y:33937,varname:node_7470,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:9257,x:32494,y:33748,varname:node_9257,prsc:2|A-4801-TSL,B-1308-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1308,x:32229,y:33840,ptovrint:False,ptlb:WaveSpeed,ptin:_WaveSpeed,varname:node_1308,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Vector1,id:9746,x:34707,y:32842,varname:node_9746,prsc:2,v1:0.8;n:type:ShaderForge.SFN_Vector1,id:5425,x:34707,y:32791,varname:node_5425,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:6541,x:33574,y:32495,varname:node_6541,prsc:2|A-4909-OUT,B-3077-RGB;n:type:ShaderForge.SFN_Tex2d,id:3077,x:32842,y:32580,ptovrint:False,ptlb:WaveTexture,ptin:_WaveTexture,varname:node_3077,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ea7d5b053194d674b812f53ee17cf0b8,ntxv:0,isnm:False|UVIN-2495-UVOUT;n:type:ShaderForge.SFN_Multiply,id:7562,x:33803,y:32635,varname:node_7562,prsc:2|A-6541-OUT,B-3900-OUT;n:type:ShaderForge.SFN_Multiply,id:8430,x:33840,y:32824,varname:node_8430,prsc:2|A-7562-OUT,B-5939-OUT;n:type:ShaderForge.SFN_Add,id:4120,x:33853,y:33039,varname:node_4120,prsc:2|A-8430-OUT,B-4342-OUT;n:type:ShaderForge.SFN_Power,id:4342,x:33528,y:33100,varname:node_4342,prsc:2|VAL-3900-OUT,EXP-3714-OUT;n:type:ShaderForge.SFN_Vector1,id:3714,x:33306,y:33201,varname:node_3714,prsc:2,v1:5;n:type:ShaderForge.SFN_Panner,id:2495,x:32582,y:32578,varname:node_2495,prsc:2,spu:1,spv:1|UVIN-9808-UVOUT,DIST-7674-OUT;n:type:ShaderForge.SFN_TexCoord,id:9808,x:32338,y:32434,varname:node_9808,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Slider,id:4299,x:31471,y:32803,ptovrint:False,ptlb:FoamSpeed,ptin:_FoamSpeed,varname:node_4299,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3.307692,max:10;n:type:ShaderForge.SFN_ValueProperty,id:8206,x:32097,y:32754,ptovrint:False,ptlb:FoamSpeed,ptin:_FoamSpeed,varname:node_8206,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Time,id:9212,x:32108,y:32560,varname:node_9212,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7674,x:32338,y:32598,varname:node_7674,prsc:2|A-9212-TSL,B-8206-OUT;proporder:5588-6665-358-1813-270-3605-9019-5939-6106-6531-1178-3077-2099-3531-7328-4578-8156-1308-4299-8206;pass:END;sub:END;*/

Shader "Shader Forge/watertest_shader" {
    Properties {
        _ColorA ("ColorA", Color) = (0.1,0,1,1)
        _ColorB ("ColorB", Color) = (1,0,0,1)
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Gloss ("Gloss", Range(0, 1)) = 0
        _Depth ("Depth", Float ) = 10
        _FoamMin ("FoamMin", Range(0, 1)) = 0
        _FoamMax ("FoamMax", Range(0, 1)) = 1
        _FoamPower ("FoamPower", Float ) = 8
        _DepthMin ("DepthMin", Range(0, 1)) = 0
        _DepthMax ("DepthMax", Range(0, 1)) = 1
        _Tesselation ("Tesselation", Range(0, 10)) = 1
        _WaveTexture ("WaveTexture", 2D) = "white" {}
        _WaveDistortion ("WaveDistortion", 2D) = "white" {}
        _WaveCount ("WaveCount", Float ) = 10
        _WaveSpread ("WaveSpread", Float ) = 0.3
        _WaveWidth ("WaveWidth", Float ) = 10
        _WaveHeight ("WaveHeight", Range(0, 1)) = 0.5
        _WaveSpeed ("WaveSpeed", Float ) = 1
        _FoamSpeed ("FoamSpeed", Range(0, 10)) = 3.307692
        _FoamSpeed ("FoamSpeed", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _ColorB;
            uniform float4 _ColorA;
            uniform float _Depth;
            uniform float _FoamMin;
            uniform float _FoamMax;
            uniform float _DepthMin;
            uniform float _DepthMax;
            uniform float _FoamPower;
            uniform float _Tesselation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveCount;
            uniform float _WaveSpread;
            uniform float _WaveWidth;
            uniform float _WaveHeight;
            uniform float _WaveSpeed;
            uniform sampler2D _WaveTexture; uniform float4 _WaveTexture_ST;
            uniform float _FoamSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_4801 = _Time;
                float node_9257 = (node_4801.r*_WaveSpeed);
                float2 node_9044 = (o.uv0+node_9257*float2(0.5,0.5));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_9044, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_9257)*_WaveCount))*_WaveSpread)+_WaveWidth)*2.0+-1.0))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 0.8;
                float perceptualRoughness = 1.0 - 0.8;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float node_372 = saturate((saturate((sceneZ-partZ)/_Depth)/0.5*dot(viewDirection,i.normalDir)+0.5));
                float3 node_4909 = lerp(_ColorA.rgb,_ColorB.rgb,node_372);
                float4 node_9212 = _Time;
                float2 node_2495 = (i.uv0+(node_9212.r*_FoamSpeed)*float2(1,1));
                float4 _WaveTexture_var = tex2D(_WaveTexture,TRANSFORM_TEX(node_2495, _WaveTexture));
                float node_8316 = 0.0;
                float node_3900 = (1.0 - saturate((node_8316 + ( (node_372 - _FoamMin) * (1.0 - node_8316) ) / (_FoamMax - _FoamMin))));
                float3 node_1758 = saturate(((((node_4909*_WaveTexture_var.rgb)*node_3900)*_FoamPower)+pow(node_3900,5.0)));
                float3 diffuseColor = saturate((node_4909+node_1758)); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_7689 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor,saturate(((node_1758.r*0.5)+(node_7689 + ( (node_372 - _DepthMin) * (1.0 - node_7689) ) / (_DepthMax - _DepthMin)))));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _ColorB;
            uniform float4 _ColorA;
            uniform float _Depth;
            uniform float _FoamMin;
            uniform float _FoamMax;
            uniform float _DepthMin;
            uniform float _DepthMax;
            uniform float _FoamPower;
            uniform float _Tesselation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveCount;
            uniform float _WaveSpread;
            uniform float _WaveWidth;
            uniform float _WaveHeight;
            uniform float _WaveSpeed;
            uniform sampler2D _WaveTexture; uniform float4 _WaveTexture_ST;
            uniform float _FoamSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                LIGHTING_COORDS(8,9)
                UNITY_FOG_COORDS(10)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_4801 = _Time;
                float node_9257 = (node_4801.r*_WaveSpeed);
                float2 node_9044 = (o.uv0+node_9257*float2(0.5,0.5));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_9044, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_9257)*_WaveCount))*_WaveSpread)+_WaveWidth)*2.0+-1.0))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 0.8;
                float perceptualRoughness = 1.0 - 0.8;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float node_372 = saturate((saturate((sceneZ-partZ)/_Depth)/0.5*dot(viewDirection,i.normalDir)+0.5));
                float3 node_4909 = lerp(_ColorA.rgb,_ColorB.rgb,node_372);
                float4 node_9212 = _Time;
                float2 node_2495 = (i.uv0+(node_9212.r*_FoamSpeed)*float2(1,1));
                float4 _WaveTexture_var = tex2D(_WaveTexture,TRANSFORM_TEX(node_2495, _WaveTexture));
                float node_8316 = 0.0;
                float node_3900 = (1.0 - saturate((node_8316 + ( (node_372 - _FoamMin) * (1.0 - node_8316) ) / (_FoamMax - _FoamMin))));
                float3 node_1758 = saturate(((((node_4909*_WaveTexture_var.rgb)*node_3900)*_FoamPower)+pow(node_3900,5.0)));
                float3 diffuseColor = saturate((node_4909+node_1758)); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_7689 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor * saturate(((node_1758.r*0.5)+(node_7689 + ( (node_372 - _DepthMin) * (1.0 - node_7689) ) / (_DepthMax - _DepthMin)))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float _Tesselation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveCount;
            uniform float _WaveSpread;
            uniform float _WaveWidth;
            uniform float _WaveHeight;
            uniform float _WaveSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float4 posWorld : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                float4 node_4801 = _Time;
                float node_9257 = (node_4801.r*_WaveSpeed);
                float2 node_9044 = (o.uv0+node_9257*float2(0.5,0.5));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_9044, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_9257)*_WaveCount))*_WaveSpread)+_WaveWidth)*2.0+-1.0))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _ColorB;
            uniform float4 _ColorA;
            uniform float _Depth;
            uniform float _FoamMin;
            uniform float _FoamMax;
            uniform float _FoamPower;
            uniform float _Tesselation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveCount;
            uniform float _WaveSpread;
            uniform float _WaveWidth;
            uniform float _WaveHeight;
            uniform float _WaveSpeed;
            uniform sampler2D _WaveTexture; uniform float4 _WaveTexture_ST;
            uniform float _FoamSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_4801 = _Time;
                float node_9257 = (node_4801.r*_WaveSpeed);
                float2 node_9044 = (o.uv0+node_9257*float2(0.5,0.5));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_9044, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_9257)*_WaveCount))*_WaveSpread)+_WaveWidth)*2.0+-1.0))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float node_372 = saturate((saturate((sceneZ-partZ)/_Depth)/0.5*dot(viewDirection,i.normalDir)+0.5));
                float3 node_4909 = lerp(_ColorA.rgb,_ColorB.rgb,node_372);
                float4 node_9212 = _Time;
                float2 node_2495 = (i.uv0+(node_9212.r*_FoamSpeed)*float2(1,1));
                float4 _WaveTexture_var = tex2D(_WaveTexture,TRANSFORM_TEX(node_2495, _WaveTexture));
                float node_8316 = 0.0;
                float node_3900 = (1.0 - saturate((node_8316 + ( (node_372 - _FoamMin) * (1.0 - node_8316) ) / (_FoamMax - _FoamMin))));
                float3 node_1758 = saturate(((((node_4909*_WaveTexture_var.rgb)*node_3900)*_FoamPower)+pow(node_3900,5.0)));
                float3 diffColor = saturate((node_4909+node_1758));
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, 0.0, specColor, specularMonochrome );
                float roughness = 1.0 - 0.8;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
