Shader "Custom/BalloonScrap" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Cutoff("Alpha cutoff", Range(0,1)) = 0.5
		_Specular ("Specular", Color) = (1,1,1,1)
		_Smoothness ("Smoothness", Range(0,1)) = 0.0
	}
	SubShader {
		Tags{ "RenderType" = "Opaque" "Queue" = "Geometry" "ForceNoShadowCasting" = "True" }
		LOD 200
		Cull Off
		
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf StandardSpecular alphatest:_Cutoff

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		fixed3 _Specular;    // specular color
		half _Smoothness;    // 0=rough, 1=smooth
		fixed4 _Color;

		void surf (Input IN, inout SurfaceOutputStandardSpecular o) {
			// Albedo comes from a texture tinted by color
			o.Albedo = _Color;
			// Metallic and smoothness come from slider variables
			o.Specular = _Specular;
			o.Smoothness = _Smoothness;
			o.Alpha = tex2D(_MainTex, IN.uv_MainTex).a;
		}
		ENDCG
	}
	FallBack "Diffuse"
	/*
	Properties{
		_MainTex("Base (RGB)", 2D) = "white" {}
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" "Queue" = "Geometry+1" "ForceNoShadowCasting" = "True" }
		LOD 200

		CGPROGRAM
#pragma surface surf Lambert decal:blend

		sampler2D _MainTex;

	struct Input {
		float2 uv_MainTex;
	};

	void surf(Input IN, inout SurfaceOutput o) {
		half4 c = tex2D(_MainTex, IN.uv_MainTex);
		o.Albedo = c.rgb;
		o.Alpha = c.a;
	}
	ENDCG
	}*/

}
