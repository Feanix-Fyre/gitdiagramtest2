using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public class DynamicResolutionHandler
{
	private struct ScalerContainer
	{
		public DynamicResScalePolicyType type;

		public PerformDynamicRes method;
	}

	public enum UpsamplerScheduleType
	{
		BeforePost = 0,
		AfterDepthOfField = 1,
		AfterPost = 2
	}

	private bool m_Enabled;

	private bool m_UseMipBias;

	private float m_MinScreenFraction;

	private float m_MaxScreenFraction;

	private float m_CurrentFraction;

	private bool m_ForcingRes;

	private bool m_CurrentCameraRequest;

	private float m_PrevFraction;

	private bool m_ForceSoftwareFallback;

	private bool m_RunUpscalerFilterOnFullResolution;

	private float m_PrevHWScaleWidth;

	private float m_PrevHWScaleHeight;

	private Vector2Int m_LastScaledSize;

	private static DynamicResScalerSlot s_ActiveScalerSlot;

	private static ScalerContainer[] s_ScalerContainers;

	private Vector2Int cachedOriginalSize;

	private static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters;

	private DynamicResolutionType type;

	private GlobalDynamicResolutionSettings m_CachedSettings;

	private const int CameraDictionaryMaxcCapacity = 32;

	private WeakReference m_OwnerCameraWeakRef;

	private static Dictionary<int, DynamicResolutionHandler> s_CameraInstances;

	private static DynamicResolutionHandler s_DefaultInstance;

	private static int s_ActiveCameraId;

	private static DynamicResolutionHandler s_ActiveInstance;

	private static bool s_ActiveInstanceDirty;

	private static float s_GlobalHwFraction;

	private static bool s_GlobalHwUpresActive;

	private UpsamplerScheduleType m_UpsamplerSchedule;

	public DynamicResUpscaleFilter filter { get; private set; }

	public Vector2Int finalViewport { get; set; }

	public bool runUpscalerFilterOnFullResolution
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UpsamplerScheduleType upsamplerSchedule
	{
		get
		{
			return default(UpsamplerScheduleType);
		}
		set
		{
		}
	}

	public static DynamicResolutionHandler instance => null;

	private void Reset()
	{
	}

	private bool FlushScalableBufferManagerState()
	{
		return false;
	}

	private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera)
	{
		return null;
	}

	private DynamicResolutionHandler()
	{
	}

	private static float DefaultDynamicResMethod()
	{
		return 0f;
	}

	private void ProcessSettings(GlobalDynamicResolutionSettings settings)
	{
	}

	public Vector2 GetResolvedScale()
	{
		return default(Vector2);
	}

	public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false)
	{
		return 0f;
	}

	public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
	{
	}

	public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
	{
	}

	public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot)
	{
	}

	public static void ClearSelectedCamera()
	{
	}

	public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter)
	{
	}

	public void SetCurrentCameraRequest(bool cameraRequest)
	{
	}

	public static void UpdateAndUseCamera(Camera camera, GlobalDynamicResolutionSettings? settings = null, Action OnResolutionChange = null)
	{
	}

	public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null)
	{
	}

	public bool SoftwareDynamicResIsEnabled()
	{
		return false;
	}

	public bool HardwareDynamicResIsEnabled()
	{
		return false;
	}

	public bool RequestsHardwareDynamicResolution()
	{
		return false;
	}

	public bool DynamicResolutionEnabled()
	{
		return false;
	}

	public void ForceSoftwareFallback()
	{
	}

	public Vector2Int GetScaledSize(Vector2Int size)
	{
		return default(Vector2Int);
	}

	public Vector2Int ApplyScalesOnSize(Vector2Int size)
	{
		return default(Vector2Int);
	}

	internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales)
	{
		return default(Vector2Int);
	}

	public float GetCurrentScale()
	{
		return 0f;
	}

	public Vector2Int GetLastScaledSize()
	{
		return default(Vector2Int);
	}

	public float GetLowResMultiplier(float targetLowRes)
	{
		return 0f;
	}

	public float GetLowResMultiplier(float targetLowRes, float minimumThreshold)
	{
		return 0f;
	}
}
