using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace VolumetricFogAndMist2;

[ExecuteInEditMode]
[DefaultExecutionOrder(100)]
[HelpURL("https://kronnect.com/guides/volumetric-fog-urp-introduction/")]
public class VolumetricFog : MonoBehaviour
{
	private struct FogOfWarTransition
	{
		public bool enabled;

		public int x;

		public int y;

		public float startTime;

		public float startDelay;

		public float duration;

		public int initialAlpha;

		public int targetAlpha;

		public int restoreToAlpha;

		public float restoreDelay;

		public float restoreDuration;
	}

	public enum HeightmapCaptureResolution
	{
		_64 = 0x40,
		_128 = 0x80,
		_256 = 0x100,
		_512 = 0x200,
		_1024 = 0x400
	}

	public VolumetricFogProfile profile;

	[Tooltip("Supports Unity native lights including point and spot lights.")]
	public bool enableNativeLights;

	[Tooltip("Multiplier to native lights intensity")]
	public float nativeLightsMultiplier;

	[Tooltip("Enable fast point lights. This option is much faster than native lights. However, if you enable native lights, this option can't be enabled as point lights are already included in the native lights support.")]
	public bool enablePointLights;

	[Tooltip("Supports Adaptative Probe Volumes (Unity 2023.1+)")]
	public bool enableAPV;

	[Tooltip("Multiplier to native lights intensity")]
	public float apvIntensityMultiplier;

	public bool enableVoids;

	[Tooltip("Makes this fog volume follow another object automatically")]
	public bool enableFollow;

	public Transform followTarget;

	public VolumetricFogFollowMode followMode;

	public bool followIncludeDistantFog;

	public Vector3 followOffset;

	[Tooltip("Fades in/out fog effect when reference controller enters the fog volume.")]
	public bool enableFade;

	[Tooltip("Fog volume blending starts when reference controller is within this fade distance to any volume border.")]
	public float fadeDistance;

	[Tooltip("If this option is disabled, the fog disappears when the reference controller exits the volume and appears when the controller enters the volume. Enable this option to fade out the fog volume when the controller enters the volume. ")]
	public bool fadeOut;

	[Tooltip("The controller (player or camera) to check if enters the fog volume.")]
	public Transform fadeController;

	[Tooltip("Enable sub-volume blending.")]
	public bool enableSubVolumes;

	[Tooltip("Allowed subVolumes. If no subvolumes are specified, any subvolume entered by this controller will affect this fog volume.")]
	public List<VolumetricFogSubVolume> subVolumes;

	[Tooltip("Customize how this fog volume data is updated and animated")]
	public bool enableUpdateModeOptions;

	public VolumetricFogUpdateMode updateMode;

	[Tooltip("Camera used to compute visibility of this fog volume. If not set, the system will use the main camera.")]
	public Camera updateModeCamera;

	public Bounds updateModeBounds;

	[Tooltip("Shows the fog volume boundary in Game View")]
	public bool showBoundary;

	[NonSerialized]
	public MeshRenderer meshRenderer;

	private MeshFilter mf;

	private Material fogMat;

	private Material noiseMat;

	private Material turbulenceMat;

	private Shader fogShader;

	private RenderTexture rtNoise;

	private RenderTexture rtTurbulence;

	private float turbAcum;

	private Vector3 windAcum;

	private Vector3 detailNoiseWindAcum;

	private Vector3 sunDir;

	private float dayLight;

	private float moonLight;

	private List<string> shaderKeywords;

	private string[] keywordsArray;

	private Texture3D detailTex;

	private Texture3D refDetailTex;

	private Mesh debugMesh;

	private Material fogDebugMat;

	private VolumetricFogProfile activeProfile;

	private VolumetricFogProfile lerpProfile;

	private Vector3 lastControllerPosition;

	private float alphaMultiplier;

	private Material distantFogMat;

	private bool profileIsInstanced;

	private bool requireUpdateMaterial;

	private ColorSpace currentAppliedColorSpace;

	private static Texture2D blueNoiseTex;

	private Color ambientMultiplied;

	[NonSerialized]
	public bool forceTerrainCaptureUpdate;

	public static readonly List<VolumetricFog> volumetricFogs;

	private Bounds cameraFrustumBounds;

	private static readonly Vector3[] frustumVertices;

	private Vector3 cameraFrustumLastPosition;

	private Quaternion cameraFrustumLastRotation;

	public bool enableFogOfWar;

	public Vector3 fogOfWarCenter;

	public bool fogOfWarIsLocal;

	public Vector3 fogOfWarSize;

	public bool fogOfWarShowCoverage;

	[Range(32f, 2048f)]
	public int fogOfWarTextureSize;

	[Tooltip("Delay before the fog alpha is restored. A value of 0 keeps the fog cleared forever.")]
	[Range(0f, 100f)]
	public float fogOfWarRestoreDelay;

	[Range(0f, 25f)]
	public float fogOfWarRestoreDuration;

	[Range(0f, 1f)]
	public float fogOfWarSmoothness;

	public bool fogOfWarBlur;

	private const int MAX_SIMULTANEOUS_TRANSITIONS = 10000;

	private bool canDestroyFOWTexture;

	public bool maskEditorEnabled;

	public MASK_TEXTURE_BRUSH_MODE maskBrushMode;

	public Color maskBrushColor;

	[Range(1f, 128f)]
	public int maskBrushWidth;

	[Range(0f, 1f)]
	public float maskBrushFuzziness;

	[Range(0f, 1f)]
	public float maskBrushOpacity;

	[SerializeField]
	private Texture2D _fogOfWarTexture;

	private Color32[] fogOfWarColorBuffer;

	private FogOfWarTransition[] fowTransitionList;

	private int lastTransitionPos;

	private Dictionary<int, int> fowTransitionIndices;

	private bool requiresTextureUpload;

	private Material fowBlur;

	private RenderTexture fowBlur1;

	private RenderTexture fowBlur2;

	private const string SURFACE_CAM_NAME = "SurfaceCam";

	private RenderTexture rt;

	private Camera surfaceCam;

	private Matrix4x4 camMatrix;

	private Vector3 lastCamPos;

	private LayerMask lastTerrainLayerMask;

	private UniversalRendererData depthRendererData;

	private static Matrix4x4 identityMatrix;

	public VolumetricFogProfile settings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material material => null;

	public Vector3 anchoredFogOfWarCenter => default(Vector3);

	public Texture2D fogOfWarTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color32[] fogOfWarTextureData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDidApplyAnimationProperties()
	{
	}

	private void OnValidate()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void LateUpdate()
	{
	}

	private bool CanUpdate()
	{
		return false;
	}

	private void CalculateFrustumBounds(Camera camera)
	{
	}

	private void CalculateFrustumVertices(Camera cam)
	{
	}

	private void UpdateNoise()
	{
	}

	public void UpdateMaterialProperties()
	{
	}

	public void UpdateMaterialProperties(bool forceTerrainCaptureUpdate)
	{
	}

	public void UpdateMaterialPropertiesNow(bool skipTerrainCapture = false, bool forceTerrainCaptureUpdate = false)
	{
	}

	private void ComputeActiveProfile()
	{
	}

	private float ComputeVolumeFade(Transform transform, float fadeDistance)
	{
		return 0f;
	}

	private void ApplyProfileSettings()
	{
	}

	private void UpdateDistantFogPropertiesNow()
	{
	}

	private void UpdateFogOfWarMaterialBoundsProperties()
	{
	}

	public static void FindAlphaClippingObjects()
	{
	}

	private void FogOfWarInit()
	{
	}

	private void FogOfWarDestroy()
	{
	}

	public void ReloadFogOfWarTexture()
	{
	}

	private void EnsureTextureIsReadable(Texture2D tex)
	{
	}

	private void FogOfWarUpdateTexture()
	{
	}

	private int GetScaledSize(int size, float factor)
	{
		return 0;
	}

	public void UpdateFogOfWar(bool forceUpload = false)
	{
	}

	private void SetFowBlurTexture()
	{
	}

	private void CreateFoWBlurRTs()
	{
	}

	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha)
	{
	}

	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, float duration = 0f)
	{
	}

	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, float duration = 0f, float smoothness = 0f)
	{
	}

	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, bool blendAlpha = false, float duration = 0f, float smoothness = 0f, float restoreDelay = 0f, float restoreDuration = 2f, float restoreToAlphaValue = 1f)
	{
	}

	public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, float duration = 0f)
	{
	}

	public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, float duration, float smoothness)
	{
	}

	public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, bool blendAlpha, float duration = 0f, float smoothness = 0f, float restoreDelay = 0f, float restoreDuration = 2f, float restoreToAlpha = 1f)
	{
	}

	public void SetFogOfWarAlpha(Collider collider, float fogNewAlpha, bool blendAlpha = false, float duration = 0f, float smoothness = 0f, float restoreDelay = 0f, float restoreDuration = 2f, float restoreToAlpha = 1f)
	{
	}

	public void SetFogOfWarAlpha(GameObject go, float fogNewAlpha, float duration = 0f, float restoreDelay = 0f, float restoreDuration = 2f, float restoreToAlpha = 1f)
	{
	}

	private float Sign(float p1x, float p1z, float p2x, float p2z, float p3x, float p3z)
	{
		return 0f;
	}

	private bool PointInTriangle(float x, float z, float v1x, float v1z, float v2x, float v2z, float v3x, float v3z)
	{
		return false;
	}

	public void ResetFogOfWarAlpha(Vector3 worldPosition, float radius, float alpha = 1f)
	{
	}

	public void ResetFogOfWarAlpha(Bounds bounds, float alpha = 1f)
	{
	}

	public void ResetFogOfWarAlpha(Vector3 position, Vector3 size, float alpha = 1f)
	{
	}

	public void ResetFogOfWarAlpha(Vector3 position, float extentsX, float extentsZ, float alpha = 1f)
	{
	}

	public void ResetFogOfWar(float alpha = 1f)
	{
	}

	private void AddFogOfWarTransitionSlot(int x, int y, byte initialAlpha, byte targetAlpha, float delay, float duration, byte restoreToAlpha, float restoreDelay, float restoreDuration)
	{
	}

	public float GetFogOfWarAlpha(Vector3 worldPosition)
	{
		return 0f;
	}

	private void DisposeSurfaceCapture()
	{
	}

	private void CheckSurfaceCapture()
	{
	}

	private void SurfaceCaptureSupportCheck()
	{
	}

	private void CheckAndAssignDepthRenderer(UniversalAdditionalCameraData camData)
	{
	}

	public void PerformHeightmapCapture()
	{
	}

	private void SetupCameraCaptureMatrix()
	{
	}

	private void SurfaceCaptureUpdate()
	{
	}

	private void ComputeSufaceTransform(Matrix4x4 proj, Matrix4x4 view)
	{
	}
}
