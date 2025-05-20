using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
public struct CullingResults : IEquatable<CullingResults>
{
	internal IntPtr ptr;

	private unsafe CullingAllocationInfo* m_AllocationInfo;

	public NativeArray<VisibleLight> visibleLights => default(NativeArray<VisibleLight>);

	public NativeArray<VisibleReflectionProbe> visibleReflectionProbes => default(NativeArray<VisibleReflectionProbe>);

	public int lightAndReflectionProbeIndexCount => 0;

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetLightIndexCount")]
	private static int GetLightIndexCount(IntPtr cullingResultsPtr)
	{
		return 0;
	}

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetReflectionProbeIndexCount")]
	private static int GetReflectionProbeIndexCount(IntPtr cullingResultsPtr)
	{
		return 0;
	}

	[FreeFunction("FillLightAndReflectionProbeIndices")]
	private static void FillLightAndReflectionProbeIndices(IntPtr cullingResultsPtr, ComputeBuffer computeBuffer)
	{
	}

	[FreeFunction("GetLightIndexMapSize")]
	private static int GetLightIndexMapSize(IntPtr cullingResultsPtr)
	{
		return 0;
	}

	[FreeFunction("FillLightIndexMapScriptable")]
	private static void FillLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
	{
	}

	[FreeFunction("SetLightIndexMapScriptable")]
	private static void SetLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
	{
	}

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetShadowCasterBounds")]
	private static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds)
	{
		bounds = default(Bounds);
		return false;
	}

	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeSpotShadowMatricesAndCullingPrimitives")]
	private static bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		viewMatrix = default(Matrix4x4);
		projMatrix = default(Matrix4x4);
		shadowSplitData = default(ShadowSplitData);
		return false;
	}

	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputePointShadowMatricesAndCullingPrimitives")]
	private static bool ComputePointShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		viewMatrix = default(Matrix4x4);
		projMatrix = default(Matrix4x4);
		shadowSplitData = default(ShadowSplitData);
		return false;
	}

	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeDirectionalShadowMatricesAndCullingPrimitives")]
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		viewMatrix = default(Matrix4x4);
		projMatrix = default(Matrix4x4);
		shadowSplitData = default(ShadowSplitData);
		return false;
	}

	private unsafe NativeArray<T> GetNativeArray<T>(void* dataPointer, int length) where T : struct
	{
		return default(NativeArray<T>);
	}

	public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer)
	{
	}

	public NativeArray<int> GetLightIndexMap(Allocator allocator)
	{
		return default(NativeArray<int>);
	}

	public void SetLightIndexMap(NativeArray<int> lightIndexMap)
	{
	}

	public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds)
	{
		outBounds = default(Bounds);
		return false;
	}

	public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		viewMatrix = default(Matrix4x4);
		projMatrix = default(Matrix4x4);
		shadowSplitData = default(ShadowSplitData);
		return false;
	}

	public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		viewMatrix = default(Matrix4x4);
		projMatrix = default(Matrix4x4);
		shadowSplitData = default(ShadowSplitData);
		return false;
	}

	public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		viewMatrix = default(Matrix4x4);
		projMatrix = default(Matrix4x4);
		shadowSplitData = default(ShadowSplitData);
		return false;
	}

	public bool Equals(CullingResults other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(CullingResults left, CullingResults right)
	{
		return false;
	}

	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
	{
		viewMatrix = default(Matrix4x4);
		projMatrix = default(Matrix4x4);
		shadowSplitData = default(ShadowSplitData);
		return false;
	}
}
