using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Profiling;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/RayTracingShader.h")]
[UsedByNativeCode]
[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
public class CommandBuffer : IDisposable
{
	internal IntPtr m_Ptr;

	public string name
	{
		set
		{
		}
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = true)]
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer()
	{
		return (IntPtr)0;
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::CreateGPUFence_Internal", HasExplicitThis = true)]
	private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
	{
		return (IntPtr)0;
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::WaitOnGPUFence_Internal", HasExplicitThis = true)]
	private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = true, IsThreadSafe = true)]
	private void ReleaseBuffer()
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeIntParam", HasExplicitThis = true)]
	public void SetComputeIntParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, int val)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = true)]
	public void SetComputeVectorParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, Vector4 val)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorArrayParam", HasExplicitThis = true)]
	public void SetComputeVectorArrayParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, [Unmarshalled] Vector4[] values)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = true)]
	private void Internal_SetComputeFloats([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, [Unmarshalled] float[] values)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = true)]
	private void Internal_SetComputeTextureParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = true)]
	private void Internal_SetComputeBufferParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = true)]
	private void Internal_SetComputeConstantComputeBufferParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = true, ThrowsException = true)]
	private void Internal_DispatchCompute([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
	{
	}

	[NativeMethod("ClearCommands")]
	public void Clear()
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = true)]
	private void Internal_DrawMesh([NotNull("ArgumentNullException")] Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
	{
	}

	[NativeMethod("AddDrawRenderer")]
	private void Internal_DrawRenderer([NotNull("ArgumentNullException")] Renderer renderer, Material material, int submeshIndex, int shaderPass)
	{
	}

	[NativeMethod("AddDrawRendererList")]
	private void Internal_DrawRendererList(RendererList rendererList)
	{
	}

	[NativeMethod("AddDrawProcedural")]
	private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstanced", HasExplicitThis = true)]
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, [Unmarshalled] Matrix4x4[] matrices, int count, MaterialPropertyBlock properties)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawOcclusionMesh", HasExplicitThis = true)]
	private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Texture", HasExplicitThis = true, ThrowsException = true)]
	private void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = true, ThrowsException = true)]
	private void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", HasExplicitThis = true, ThrowsException = true)]
	public void ClearRandomWriteTargets()
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = true, ThrowsException = true)]
	public void SetViewport(Rect pixelRect)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = true, ThrowsException = true)]
	public void DisableScissorRect()
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = true)]
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = true)]
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = true)]
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRT", HasExplicitThis = true)]
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
	{
	}

	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = true)]
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter)
	{
	}

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter)
	{
	}

	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = true)]
	public void ReleaseTemporaryRT(int nameID)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRenderTarget", HasExplicitThis = true)]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil)
	{
	}

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
	{
	}

	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = true)]
	public void SetGlobalFloat(int nameID, float value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = true)]
	public void SetGlobalInt(int nameID, int value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = true)]
	public void SetGlobalInteger(int nameID, int value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = true)]
	public void SetGlobalVector(int nameID, Vector4 value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = true)]
	public void SetGlobalColor(int nameID, Color value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = true)]
	public void SetGlobalMatrix(int nameID, Matrix4x4 value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = true)]
	public void EnableShaderKeyword(string keyword)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = true)]
	public void DisableShaderKeyword(string keyword)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetMaterialKeyword", HasExplicitThis = true)]
	private void SetMaterialKeyword(Material material, LocalKeyword keyword, bool value)
	{
	}

	public void SetKeyword(Material material, in LocalKeyword keyword, bool value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", HasExplicitThis = true, ThrowsException = true)]
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
	{
	}

	[NativeMethod("AddSetGlobalDepthBias")]
	public void SetGlobalDepthBias(float bias, float slopeBias)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", HasExplicitThis = true, ThrowsException = true)]
	public void SetExecutionFlags(CommandBufferExecutionFlags flags)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = true, ThrowsException = true)]
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags)
	{
		return false;
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", HasExplicitThis = true, ThrowsException = true)]
	public void SetGlobalFloatArray(int nameID, [Unmarshalled] float[] values)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", HasExplicitThis = true, ThrowsException = true)]
	public void SetGlobalVectorArray(int nameID, [Unmarshalled] Vector4[] values)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", HasExplicitThis = true, ThrowsException = true)]
	public void SetGlobalMatrixArray(int nameID, [Unmarshalled] Matrix4x4[] values)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", HasExplicitThis = true, ThrowsException = true)]
	public void SetLateLatchProjectionMatrices([Unmarshalled] Matrix4x4[] projectionMat)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = true)]
	public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = true)]
	public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = true)]
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = true)]
	private void SetGlobalBufferInternal(int nameID, ComputeBuffer value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = true)]
	private void SetGlobalGraphicsBufferInternal(int nameID, GraphicsBuffer value)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = true)]
	public void BeginSample(string name)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = true)]
	public void EndSample(string name)
	{
	}

	public void BeginSample(CustomSampler sampler)
	{
	}

	public void EndSample(CustomSampler sampler)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample_CustomSampler", HasExplicitThis = true)]
	private void BeginSample_CustomSampler([NotNull("ArgumentNullException")] CustomSampler sampler)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample_CustomSampler", HasExplicitThis = true)]
	private void EndSample_CustomSampler([NotNull("ArgumentNullException")] CustomSampler sampler)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = true)]
	private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = true)]
	private void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = true)]
	public void SetInstanceMultiplier(uint multiplier)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::SetFoveatedRenderingMode", HasExplicitThis = true)]
	public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode)
	{
	}

	[FreeFunction("RenderingCommandBuffer_Bindings::ConfigureFoveatedRendering", HasExplicitThis = true)]
	public void ConfigureFoveatedRendering(IntPtr platformData)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier rt)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth)
	{
	}

	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
	{
	}

	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
	{
	}

	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
	{
	}

	private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
	{
	}

	public void SetBufferData(ComputeBuffer buffer, Array data)
	{
	}

	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = true, ThrowsException = true)]
	private void InternalSetComputeBufferData([NotNull("ArgumentNullException")] ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
	{
	}

	~CommandBuffer()
	{
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public void Release()
	{
	}

	public GraphicsFence CreateAsyncGraphicsFence()
	{
		return default(GraphicsFence);
	}

	public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
	{
		return default(GraphicsFence);
	}

	public void WaitOnAsyncGraphicsFence(GraphicsFence fence)
	{
	}

	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage)
	{
	}

	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage)
	{
	}

	public void SetComputeIntParam(ComputeShader computeShader, string name, int val)
	{
	}

	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val)
	{
	}

	public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values)
	{
	}

	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
	{
	}

	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt)
	{
	}

	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer)
	{
	}

	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
	{
	}

	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
	{
	}

	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass, [DefaultValue("null")] MaterialPropertyBlock properties)
	{
	}

	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
	{
	}

	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
	{
	}

	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
	{
	}

	public void DrawRenderer(Renderer renderer, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass)
	{
	}

	[ExcludeFromDocs]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
	{
	}

	[ExcludeFromDocs]
	public void DrawRenderer(Renderer renderer, Material material)
	{
	}

	public void DrawRendererList(RendererList rendererList)
	{
	}

	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, [DefaultValue("1")] int instanceCount, [DefaultValue("null")] MaterialPropertyBlock properties)
	{
	}

	[ExcludeFromDocs]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
	{
	}

	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties)
	{
	}

	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count)
	{
	}

	public void DrawOcclusionMesh(RectInt normalizedCamViewport)
	{
	}

	public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt)
	{
	}

	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue)
	{
	}

	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer)
	{
	}

	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
	{
	}

	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip)
	{
	}

	public void Blit(Texture source, RenderTargetIdentifier dest)
	{
	}

	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
	{
	}

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
	{
	}

	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
	{
	}

	public void SetGlobalVector(string name, Vector4 value)
	{
	}

	public void SetGlobalMatrix(string name, Matrix4x4 value)
	{
	}

	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values)
	{
	}

	public void SetGlobalTexture(string name, RenderTargetIdentifier value)
	{
	}

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
	{
	}

	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element)
	{
	}

	public void SetGlobalBuffer(int nameID, ComputeBuffer value)
	{
	}

	public void SetGlobalBuffer(int nameID, GraphicsBuffer value)
	{
	}

	public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size)
	{
	}

	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size)
	{
	}

	public void SetSinglePassStereo(SinglePassStereoMode mode)
	{
	}

	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val)
	{
	}

	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
	{
	}

	private void Internal_DrawRendererList_Injected(ref RendererList rendererList)
	{
	}

	private void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
	{
	}

	private void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport)
	{
	}

	private void SetViewport_Injected(ref Rect pixelRect)
	{
	}

	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
	}

	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
	{
	}

	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter)
	{
	}

	private void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, uint stencil)
	{
	}

	private void SetGlobalVector_Injected(int nameID, ref Vector4 value)
	{
	}

	private void SetGlobalColor_Injected(int nameID, ref Color value)
	{
	}

	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value)
	{
	}

	private void SetMaterialKeyword_Injected(Material material, ref LocalKeyword keyword, bool value)
	{
	}

	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj)
	{
	}

	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
	{
	}

	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
	{
	}

	private void SetRenderTargetMultiSubtarget_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
	{
	}
}
