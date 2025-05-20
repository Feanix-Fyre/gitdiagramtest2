using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

public sealed class LensFlareCommonSRP
{
	internal class LensFlareCompInfo
	{
		internal int index;

		internal LensFlareComponentSRP comp;

		internal LensFlareCompInfo(int idx, LensFlareComponentSRP cmp)
		{
		}
	}

	private static LensFlareCommonSRP m_Instance;

	private static readonly object m_Padlock;

	private static List<LensFlareCompInfo> m_Data;

	private static List<int> m_AvailableIndicies;

	public static int maxLensFlareWithOcclusion;

	public static int maxLensFlareWithOcclusionTemporalSample;

	public static int mergeNeeded;

	public static RTHandle occlusionRT;

	private static int frameIdx;

	private static readonly bool s_SupportsLensFlareTexFormat;

	public static LensFlareCommonSRP Instance => null;

	private List<LensFlareCompInfo> Data => null;

	private LensFlareCommonSRP()
	{
	}

	public static bool IsOcclusionRTCompatible()
	{
		return false;
	}

	public static void Initialize()
	{
	}

	public static void Dispose()
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	private int GetNextAvailableIndex()
	{
		return 0;
	}

	public void AddData(LensFlareComponentSRP newData)
	{
	}

	public void RemoveData(LensFlareComponentSRP data)
	{
	}

	public static float ShapeAttenuationPointLight()
	{
		return 0f;
	}

	public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo)
	{
		return 0f;
	}

	public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01)
	{
		return 0f;
	}

	public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo)
	{
		return 0f;
	}

	public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo)
	{
		return 0f;
	}

	public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam)
	{
		return 0f;
	}

	public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo)
	{
		return 0f;
	}

	public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo)
	{
		return 0f;
	}

	private static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data)
	{
		return false;
	}

	public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate)
	{
		return default(Vector4);
	}

	private static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0)
	{
		return default(Vector2);
	}

	private static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS)
	{
		return default(Vector3);
	}

	private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS)
	{
		return default(Vector3);
	}

	private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS)
	{
		return default(Vector3);
	}

	public static bool IsCloudLayerOpacityNeeded(Camera cam)
	{
		return false;
	}

	private static void SetOcclusionPermutation(CommandBuffer cmd, bool useBackgroundCloudOcclusion, bool volumetricCloudOcclusion, bool hasCloudLayer, int _FlareCloudOpacity, int _FlareSunOcclusionTex, Texture cloudOpacityTexture, Texture sunOcclusionTexture)
	{
	}

	public static void ComputeOcclusion(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4)
	{
	}

	public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView)
	{
	}

	private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance)
	{
		return default(Vector2);
	}

	private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView)
	{
		return default(Vector2);
	}

	private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d)
	{
		return default(Vector2);
	}

	private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d)
	{
		return default(Vector2);
	}
}
