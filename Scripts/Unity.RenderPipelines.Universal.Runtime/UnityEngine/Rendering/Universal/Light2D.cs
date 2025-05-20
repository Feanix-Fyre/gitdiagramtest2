using System;
using UnityEngine.Animations;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;
using UnityEngine.U2D;

namespace UnityEngine.Rendering.Universal;

[ExecuteAlways]
[DisallowMultipleComponent]
[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
[AddComponentMenu("Rendering/2D/Light 2D")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DLightProperties.html")]
public sealed class Light2D : Light2DBase, ISerializationCallbackReceiver
{
	public enum DeprecatedLightType
	{
		Parametric = 0
	}

	public enum LightType
	{
		Parametric = 0,
		Freeform = 1,
		Sprite = 2,
		Point = 3,
		Global = 4
	}

	public enum NormalMapQuality
	{
		Disabled = 2,
		Fast = 0,
		Accurate = 1
	}

	public enum OverlapOperation
	{
		Additive = 0,
		AlphaBlend = 1
	}

	private enum ComponentVersions
	{
		Version_Unserialized = 0,
		Version_1 = 1
	}

	private const ComponentVersions k_CurrentComponentVersion = ComponentVersions.Version_1;

	[SerializeField]
	private ComponentVersions m_ComponentVersion;

	[NotKeyable]
	[SerializeField]
	private LightType m_LightType;

	[SerializeField]
	[FormerlySerializedAs("m_LightOperationIndex")]
	private int m_BlendStyleIndex;

	[SerializeField]
	private float m_FalloffIntensity;

	[ColorUsage(true)]
	[SerializeField]
	private Color m_Color;

	[SerializeField]
	private float m_Intensity;

	[FormerlySerializedAs("m_LightVolumeOpacity")]
	[SerializeField]
	private float m_LightVolumeIntensity;

	[SerializeField]
	private bool m_LightVolumeIntensityEnabled;

	[SerializeField]
	private int[] m_ApplyToSortingLayers;

	[Reload("Textures/2D/Sparkle.png", ReloadAttribute.Package.Root)]
	[SerializeField]
	private Sprite m_LightCookieSprite;

	[FormerlySerializedAs("m_LightCookieSprite")]
	[SerializeField]
	private Sprite m_DeprecatedPointLightCookieSprite;

	[SerializeField]
	private int m_LightOrder;

	[SerializeField]
	private bool m_AlphaBlendOnOverlap;

	[SerializeField]
	private OverlapOperation m_OverlapOperation;

	[SerializeField]
	[FormerlySerializedAs("m_PointLightDistance")]
	private float m_NormalMapDistance;

	[SerializeField]
	[FormerlySerializedAs("m_PointLightQuality")]
	[NotKeyable]
	private NormalMapQuality m_NormalMapQuality;

	[SerializeField]
	private bool m_UseNormalMap;

	[SerializeField]
	private bool m_ShadowIntensityEnabled;

	[Range(0f, 1f)]
	[SerializeField]
	private float m_ShadowIntensity;

	[SerializeField]
	private bool m_ShadowVolumeIntensityEnabled;

	[Range(0f, 1f)]
	[SerializeField]
	private float m_ShadowVolumeIntensity;

	private Mesh m_Mesh;

	[NonSerialized]
	private LightUtility.LightMeshVertex[] m_Vertices;

	[NonSerialized]
	private ushort[] m_Triangles;

	private int m_PreviousLightCookieSprite;

	internal Vector3 m_CachedPosition;

	[SerializeField]
	private Bounds m_LocalBounds;

	internal bool forceUpdate;

	[SerializeField]
	private float m_PointLightInnerAngle;

	[SerializeField]
	private float m_PointLightOuterAngle;

	[SerializeField]
	private float m_PointLightInnerRadius;

	[SerializeField]
	private float m_PointLightOuterRadius;

	[SerializeField]
	private int m_ShapeLightParametricSides;

	[SerializeField]
	private float m_ShapeLightParametricAngleOffset;

	[SerializeField]
	private float m_ShapeLightParametricRadius;

	[SerializeField]
	private float m_ShapeLightFalloffSize;

	[SerializeField]
	private Vector2 m_ShapeLightFalloffOffset;

	[SerializeField]
	private Vector3[] m_ShapePath;

	private float m_PreviousShapeLightFalloffSize;

	private int m_PreviousShapeLightParametricSides;

	private float m_PreviousShapeLightParametricAngleOffset;

	private float m_PreviousShapeLightParametricRadius;

	private int m_PreviousShapePathHash;

	private LightType m_PreviousLightType;

	internal LightUtility.LightMeshVertex[] vertices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ushort[] indices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal int[] affectedSortingLayers => null;

	private int lightCookieSpriteInstanceID => 0;

	internal BoundingSphere boundingSphere { get; private set; }

	internal Mesh lightMesh => null;

	internal bool hasCachedMesh => false;

	public LightType lightType
	{
		get
		{
			return default(LightType);
		}
		set
		{
		}
	}

	public int blendStyleIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float shadowIntensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool shadowsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float shadowVolumeIntensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool volumetricShadowsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float intensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete]
	public float volumeOpacity => 0f;

	public float volumeIntensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool volumeIntensityEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Sprite lightCookieSprite
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float falloffIntensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete]
	public bool alphaBlendOnOverlap => false;

	public OverlapOperation overlapOperation
	{
		get
		{
			return default(OverlapOperation);
		}
		set
		{
		}
	}

	public int lightOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float normalMapDistance => 0f;

	public NormalMapQuality normalMapQuality => default(NormalMapQuality);

	public bool renderVolumetricShadows => false;

	public float pointLightInnerAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float pointLightOuterAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float pointLightInnerRadius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float pointLightOuterRadius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete("pointLightDistance has been changed to normalMapDistance", true)]
	public float pointLightDistance => 0f;

	[Obsolete("pointLightQuality has been changed to normalMapQuality", true)]
	public NormalMapQuality pointLightQuality => default(NormalMapQuality);

	internal bool isPointLight => false;

	public int shapeLightParametricSides => 0;

	public float shapeLightParametricAngleOffset => 0f;

	public float shapeLightParametricRadius
	{
		get
		{
			return 0f;
		}
		internal set
		{
		}
	}

	public float shapeLightFalloffSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector3[] shapePath
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	internal void MarkForUpdate()
	{
	}

	internal void CacheValues()
	{
	}

	internal int GetTopMostLitLayer()
	{
		return 0;
	}

	internal Bounds UpdateSpriteMesh()
	{
		return default(Bounds);
	}

	internal void UpdateMesh(bool forceUpdate = false)
	{
	}

	internal void UpdateBoundingSphere()
	{
	}

	internal bool IsLitLayer(int layer)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public void SetShapePath(Vector3[] path)
	{
	}
}
