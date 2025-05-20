using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
public struct Light2DBlendStyle
{
	internal enum TextureChannel
	{
		None = 0,
		R = 1,
		G = 2,
		B = 3,
		A = 4,
		OneMinusR = 5,
		OneMinusG = 6,
		OneMinusB = 7,
		OneMinusA = 8
	}

	internal struct MaskChannelFilter
	{
		public Vector4 mask { get; private set; }

		public Vector4 inverted { get; private set; }

		public MaskChannelFilter(Vector4 m, Vector4 i)
		{
			mask = default(Vector4);
			inverted = default(Vector4);
		}
	}

	internal enum BlendMode
	{
		Additive = 0,
		Multiply = 1,
		Subtractive = 2
	}

	[Serializable]
	internal struct BlendFactors
	{
		public float multiplicative;

		public float additive;
	}

	public string name;

	[SerializeField]
	internal TextureChannel maskTextureChannel;

	[SerializeField]
	internal BlendMode blendMode;

	internal int renderTargetHandleId;

	internal RTHandle renderTargetHandle;

	internal Vector2 blendFactors => default(Vector2);

	internal MaskChannelFilter maskTextureChannelFilter => default(MaskChannelFilter);

	internal bool isDirty { get; set; }

	internal bool hasRenderTarget { get; set; }
}
