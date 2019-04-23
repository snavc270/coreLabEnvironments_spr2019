﻿Shader "Unlit/betterWaterShader"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_WaveHeight ("Wave Height", Float ) = 0.5
		_WaveFreq ("Wave Frequency", Float) = 2
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};
			//variable declarations for our texture
			sampler2D _MainTex;
			float4 _MainTex_ST;
			float _WaveHeight; 
			float _WaveFreq;
			
			v2f vert (appdata v)
			{
				v2f o;

				v.vertex += float4(0, 
					sin(_Time.y*_WaveFreq + v.vertex.x + v.vertex.z)/_WaveHeight,0, 0);
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv + float2(_Time.y, _Time.x)/20);
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG
		}
	}
}
