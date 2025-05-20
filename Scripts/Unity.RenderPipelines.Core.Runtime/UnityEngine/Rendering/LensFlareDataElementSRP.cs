using System;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering;

[Serializable]
public sealed class LensFlareDataElementSRP
{
	public bool visible;

	public float position;

	public Vector2 positionOffset;

	public float angularOffset;

	public Vector2 translationScale;

	[Min(0f)]
	[SerializeField]
	[FormerlySerializedAs("localIntensity")]
	private float m_LocalIntensity;

	public Texture lensFlareTexture;

	public float uniformScale;

	public Vector2 sizeXY;

	public bool allowMultipleElement;

	[FormerlySerializedAs("count")]
	[Min(1f)]
	[SerializeField]
	private int m_Count;

	public bool preserveAspectRatio;

	public float rotation;

	public Color tint;

	public SRPLensFlareBlendMode blendMode;

	public bool autoRotate;

	public SRPLensFlareType flareType;

	public bool modulateByLightColor;

	[SerializeField]
	private bool isFoldOpened;

	public SRPLensFlareDistribution distribution;

	public float lengthSpread;

	public AnimationCurve positionCurve;

	public AnimationCurve scaleCurve;

	public int seed;

	public Gradient colorGradient;

	[Range(0f, 1f)]
	[FormerlySerializedAs("intensityVariation")]
	[SerializeField]
	private float m_IntensityVariation;

	public Vector2 positionVariation;

	public float scaleVariation;

	public float rotationVariation;

	public bool enableRadialDistortion;

	public Vector2 targetSizeDistortion;

	public AnimationCurve distortionCurve;

	public bool distortionRelativeToCenter;

	[FormerlySerializedAs("fallOff")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_FallOff;

	[SerializeField]
	[Range(0f, 1f)]
	[FormerlySerializedAs("edgeOffset")]
	private float m_EdgeOffset;

	[FormerlySerializedAs("sideCount")]
	[Min(3f)]
	[SerializeField]
	private int m_SideCount;

	[SerializeField]
	[FormerlySerializedAs("sdfRoundness")]
	[Range(0f, 1f)]
	private float m_SdfRoundness;

	public bool inverseSDF;

	public float uniformAngle;

	public AnimationCurve uniformAngleCurve;

	public float localIntensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int count
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float intensityVariation
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float fallOff
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float edgeOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int sideCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float sdfRoundness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
