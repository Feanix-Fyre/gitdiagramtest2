using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal;

[ExecuteInEditMode]
[AddComponentMenu("Rendering/2D/Shadow Caster 2D")]
[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
[DisallowMultipleComponent]
public class ShadowCaster2D : ShadowCasterGroup2D, ISerializationCallbackReceiver
{
	public enum ComponentVersions
	{
		Version_Unserialized = 0,
		Version_1 = 1
	}

	private const ComponentVersions k_CurrentComponentVersion = ComponentVersions.Version_1;

	[SerializeField]
	private ComponentVersions m_ComponentVersion;

	[SerializeField]
	private bool m_HasRenderer;

	[SerializeField]
	private bool m_UseRendererSilhouette;

	[SerializeField]
	private bool m_CastsShadows;

	[SerializeField]
	private bool m_SelfShadows;

	[SerializeField]
	private int[] m_ApplyToSortingLayers;

	[SerializeField]
	private Vector3[] m_ShapePath;

	[SerializeField]
	private int m_ShapePathHash;

	[SerializeField]
	private Mesh m_Mesh;

	[SerializeField]
	private int m_InstanceId;

	internal ShadowCasterGroup2D m_ShadowCasterGroup;

	internal ShadowCasterGroup2D m_PreviousShadowCasterGroup;

	[SerializeField]
	internal Bounds m_LocalBounds;

	internal BoundingSphere m_BoundingSphere;

	private int m_PreviousShadowGroup;

	private bool m_PreviousCastsShadows;

	private int m_PreviousPathHash;

	internal Vector3 m_CachedPosition;

	internal Vector3 m_CachedLossyScale;

	internal Quaternion m_CachedRotation;

	internal Matrix4x4 m_CachedShadowMatrix;

	internal Matrix4x4 m_CachedInverseShadowMatrix;

	internal Matrix4x4 m_CachedLocalToWorldMatrix;

	public Mesh mesh => null;

	public Vector3[] shapePath => null;

	internal int shapePathHash
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool useRendererSilhouette
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool selfShadows
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool castsShadows
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal override void CacheValues()
	{
	}

	private static int[] SetDefaultSortingLayers()
	{
		return null;
	}

	internal bool IsLit(Light2D light)
	{
		return false;
	}

	internal bool IsShadowedLayer(int layer)
	{
		return false;
	}

	private void Awake()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	public void Update()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	private void UpdateBoundingSphere()
	{
	}
}
