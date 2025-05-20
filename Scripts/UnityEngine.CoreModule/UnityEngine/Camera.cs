using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Camera/Camera.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
public sealed class Camera : Behaviour
{
	public enum GateFitMode
	{
		Vertical = 1,
		Horizontal = 2,
		Fill = 3,
		Overscan = 4,
		None = 0
	}

	public enum StereoscopicEye
	{
		Left = 0,
		Right = 1
	}

	public enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2
	}

	public enum SceneViewFilterMode
	{
		Off = 0,
		ShowFiltered = 1
	}

	public delegate void CameraCallback(Camera cam);

	public const float kMinAperture = 0.7f;

	public const float kMaxAperture = 32f;

	public const int kMinBladeCount = 3;

	public const int kMaxBladeCount = 11;

	public static CameraCallback onPreCull;

	public static CameraCallback onPreRender;

	public static CameraCallback onPostRender;

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public RenderingPath renderingPath
	{
		set
		{
		}
	}

	public RenderingPath actualRenderingPath
	{
		[NativeName("CalculateRenderingPath")]
		get
		{
			return default(RenderingPath);
		}
	}

	public bool allowHDR
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool allowMSAA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool allowDynamicResolution => false;

	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture
	{
		set
		{
		}
	}

	public float orthographicSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool orthographic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public OpaqueSortMode opaqueSortMode => default(OpaqueSortMode);

	public float depth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float aspect
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int cullingMask
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int eventMask => 0;

	public bool layerCullSpherical
	{
		set
		{
		}
	}

	public CameraType cameraType
	{
		get
		{
			return default(CameraType);
		}
		set
		{
		}
	}

	public float[] layerCullDistances
	{
		set
		{
		}
	}

	public bool useOcclusionCulling
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color backgroundColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public CameraClearFlags clearFlags
	{
		get
		{
			return default(CameraClearFlags);
		}
		set
		{
		}
	}

	public DepthTextureMode depthTextureMode
	{
		get
		{
			return default(DepthTextureMode);
		}
		set
		{
		}
	}

	public bool usePhysicalProperties
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float focusDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float focalLength
	{
		set
		{
		}
	}

	public Vector2 sensorSize
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 lensShift
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public GateFitMode gateFit
	{
		get
		{
			return default(GateFitMode);
		}
		set
		{
		}
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int scaledPixelWidth
	{
		[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int scaledPixelHeight
	{
		[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public RenderTexture targetTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RenderTexture activeTexture
	{
		[NativeName("GetCurrentTargetTexture")]
		get
		{
			return null;
		}
	}

	public int targetDisplay => 0;

	public Matrix4x4 cameraToWorldMatrix => default(Matrix4x4);

	public Matrix4x4 worldToCameraMatrix
	{
		get
		{
			return default(Matrix4x4);
		}
		set
		{
		}
	}

	public Matrix4x4 projectionMatrix
	{
		get
		{
			return default(Matrix4x4);
		}
		set
		{
		}
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		set
		{
		}
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		set
		{
		}
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		get
		{
			return null;
		}
	}

	public static Camera current
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		get
		{
			return null;
		}
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		get
		{
			return false;
		}
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		get
		{
			return default(StereoTargetEyeMask);
		}
		set
		{
		}
	}

	public MonoOrStereoscopicEye stereoActiveEye
	{
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = true)]
		get
		{
			return default(MonoOrStereoscopicEye);
		}
	}

	public static int allCamerasCount => 0;

	public static Camera[] allCameras => null;

	[NativeConditional("UNITY_EDITOR")]
	public SceneViewFilterMode sceneViewFilterMode => default(SceneViewFilterMode);

	[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = true)]
	private void SetLayerCullDistances([NotNull("ArgumentNullException")] float[] d)
	{
	}

	public void ResetWorldToCameraMatrix()
	{
	}

	public void ResetProjectionMatrix()
	{
	}

	[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = true)]
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
	{
		return default(Matrix4x4);
	}

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		return default(Vector3);
	}

	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		return default(Vector3);
	}

	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		return default(Vector3);
	}

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
	{
		return default(Vector3);
	}

	public Vector3 WorldToScreenPoint(Vector3 position)
	{
		return default(Vector3);
	}

	public Vector3 WorldToViewportPoint(Vector3 position)
	{
		return default(Vector3);
	}

	public Vector3 ViewportToWorldPoint(Vector3 position)
	{
		return default(Vector3);
	}

	public Vector3 ScreenToWorldPoint(Vector3 position)
	{
		return default(Vector3);
	}

	public Vector3 ScreenToViewportPoint(Vector3 position)
	{
		return default(Vector3);
	}

	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
	{
		return default(Ray);
	}

	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
	{
		return default(Ray);
	}

	public Ray ViewportPointToRay(Vector3 pos)
	{
		return default(Ray);
	}

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
	{
		return default(Ray);
	}

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
	{
		return default(Ray);
	}

	public Ray ScreenPointToRay(Vector3 pos)
	{
		return default(Ray);
	}

	[NativeName("FieldOfViewToFocalLength_Safe")]
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
	{
		return 0f;
	}

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye)
	{
		return default(Matrix4x4);
	}

	[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = true)]
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye)
	{
		return default(Matrix4x4);
	}

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye)
	{
	}

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = true)]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye)
	{
		return default(Matrix4x4);
	}

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix)
	{
	}

	public void ResetStereoProjectionMatrices()
	{
	}

	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix)
	{
	}

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount()
	{
		return 0;
	}

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl([Out][NotNull("ArgumentNullException")] Camera[] cam)
	{
		return 0;
	}

	public static int GetAllCameras(Camera[] cameras)
	{
		return 0;
	}

	[NativeConditional("UNITY_EDITOR")]
	private int GetFilterMode()
	{
		return 0;
	}

	[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
	public void Render()
	{
	}

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = true)]
	public void RenderWithShader(Shader shader, string replacementTag)
	{
	}

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur)
	{
	}

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = true)]
	public void CopyFrom(Camera other)
	{
	}

	[NativeName("AddCommandBuffer")]
	private void AddCommandBufferImpl(CameraEvent evt, [NotNull("ArgumentNullException")] CommandBuffer buffer)
	{
	}

	[NativeName("RemoveCommandBuffer")]
	private void RemoveCommandBufferImpl(CameraEvent evt, [NotNull("ArgumentNullException")] CommandBuffer buffer)
	{
	}

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer)
	{
	}

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam)
	{
	}

	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters)
	{
		cullingParameters = default(ScriptableCullingParameters);
		return false;
	}

	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
	{
		cullingParameters = default(ScriptableCullingParameters);
		return false;
	}

	[SpecialName]
	private void get_backgroundColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private void set_backgroundColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private void get_sensorSize_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_sensorSize_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_lensShift_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_lensShift_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_rect_Injected(out Rect ret)
	{
		ret = default(Rect);
	}

	[SpecialName]
	private void set_rect_Injected(ref Rect value)
	{
	}

	[SpecialName]
	private void get_pixelRect_Injected(out Rect ret)
	{
		ret = default(Rect);
	}

	[SpecialName]
	private void set_pixelRect_Injected(ref Rect value)
	{
	}

	[SpecialName]
	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	[SpecialName]
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	[SpecialName]
	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value)
	{
	}

	[SpecialName]
	private void get_projectionMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	[SpecialName]
	private void set_projectionMatrix_Injected(ref Matrix4x4 value)
	{
	}

	[SpecialName]
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value)
	{
	}

	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
	{
		ret = default(Ray);
	}

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
	{
		ret = default(Ray);
	}

	private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix)
	{
	}

	private void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix)
	{
	}
}
