namespace UnityEngine.Rendering;

[ExecuteAlways]
[AddComponentMenu("Rendering/Lens Flare (SRP)")]
public sealed class LensFlareComponentSRP : MonoBehaviour
{
	[SerializeField]
	private LensFlareDataSRP m_LensFlareData;

	[Min(0f)]
	public float intensity;

	[Min(1E-05f)]
	public float maxAttenuationDistance;

	[Min(1E-05f)]
	public float maxAttenuationScale;

	public AnimationCurve distanceAttenuationCurve;

	public AnimationCurve scaleByDistanceCurve;

	public bool attenuationByLightShape;

	public AnimationCurve radialScreenAttenuationCurve;

	public bool useOcclusion;

	[Min(0f)]
	public float occlusionRadius;

	public bool useBackgroundCloudOcclusion;

	[Range(1f, 64f)]
	public uint sampleCount;

	public float occlusionOffset;

	[Min(0f)]
	public float scale;

	public bool allowOffScreen;

	public bool volumetricCloudOcclusion;

	private static float sCelestialAngularRadius;

	public TextureCurve occlusionRemapCurve;

	public LensFlareDataSRP lensFlareData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float celestialProjectedOcclusionRadius(Camera mainCam)
	{
		return 0f;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}
}
