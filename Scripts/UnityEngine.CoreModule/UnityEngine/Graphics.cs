using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount;

	internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts;

	[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
	public static GraphicsTier activeTier => default(GraphicsTier);

	public static bool preserveFramebufferAlpha => false;

	public static OpenGLESVersion minOpenGLESVersion => default(OpenGLESVersion);

	public static RenderBuffer activeColorBuffer => default(RenderBuffer);

	public static RenderBuffer activeDepthBuffer => default(RenderBuffer);

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = true)]
	private static int Internal_GetMaxDrawMeshInstanceCount()
	{
		return 0;
	}

	[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
	[NativeMethod(Name = "GetPreserveFramebufferAlpha")]
	internal static bool GetPreserveFramebufferAlpha()
	{
		return false;
	}

	[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
	[NativeMethod(Name = "GetMinOpenGLESVersion")]
	internal static OpenGLESVersion GetMinOpenGLESVersion()
	{
		return default(OpenGLESVersion);
	}

	[FreeFunction("GraphicsScripting::GetActiveColorBuffer")]
	private static RenderBuffer GetActiveColorBuffer()
	{
		return default(RenderBuffer);
	}

	[FreeFunction("GraphicsScripting::GetActiveDepthBuffer")]
	private static RenderBuffer GetActiveDepthBuffer()
	{
		return default(RenderBuffer);
	}

	[FreeFunction("GraphicsScripting::SetNullRT")]
	private static void Internal_SetNullRT()
	{
	}

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = true, ThrowsException = true)]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
	}

	[NativeMethod(Name = "GraphicsScripting::SetMRTSimple", IsFreeFunction = true, ThrowsException = true)]
	private static void Internal_SetMRTSimple([NotNull("ArgumentNullException")] RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
	}

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
	{
	}

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
	{
	}

	[FreeFunction("GraphicsScripting::DrawMeshNow")]
	private static void Internal_DrawMeshNow2([NotNull("NullExceptionObject")] Mesh mesh, int subsetIndex, Matrix4x4 matrix)
	{
	}

	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
	[FreeFunction("GraphicsScripting::DrawTexture")]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args)
	{
	}

	[FreeFunction("GraphicsScripting::DrawMesh")]
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
	}

	[FreeFunction("GraphicsScripting::DrawMeshInstanced")]
	private static void Internal_DrawMeshInstanced([NotNull("NullExceptionObject")] Mesh mesh, int submeshIndex, [NotNull("NullExceptionObject")] Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
	}

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, [NotNull("ArgumentNullException")] Material mat, int pass, bool setRT)
	{
	}

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit2(Texture source, RenderTexture dest)
	{
	}

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
	{
	}

	[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = true, ThrowsException = true)]
	public static void ExecuteCommandBuffer([NotNull("ArgumentNullException")] CommandBuffer buffer)
	{
	}

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
	{
	}

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
	{
	}

	internal static void SetRenderTargetImpl(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
	{
	}

	public static void SetRenderTarget(RenderTexture rt, [DefaultValue("0")] int mipLevel, [DefaultValue("CubemapFace.Unknown")] CubemapFace face, [DefaultValue("0")] int depthSlice)
	{
	}

	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, [DefaultValue("0")] int mipLevel, [DefaultValue("CubemapFace.Unknown")] CubemapFace face, [DefaultValue("0")] int depthSlice)
	{
	}

	public static void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer)
	{
	}

	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
	{
	}

	public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
	{
	}

	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
	{
	}

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass)
	{
	}

	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass)
	{
	}

	public static void DrawTexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass)
	{
	}

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
	{
	}

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
	{
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, [DefaultValue("null")] Camera camera, [DefaultValue("0")] int submeshIndex, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("true")] bool castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("true")] bool useLightProbes)
	{
	}

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, [DefaultValue("null")] LightProbeProxyVolume lightProbeProxyVolume)
	{
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, [DefaultValue("matrices.Length")] int count, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("ShadowCastingMode.On")] ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("0")] int layer, [DefaultValue("null")] Camera camera, [DefaultValue("LightProbeUsage.BlendProbes")] LightProbeUsage lightProbeUsage, [DefaultValue("null")] LightProbeProxyVolume lightProbeProxyVolume)
	{
	}

	public static void Blit(Texture source, RenderTexture dest)
	{
	}

	public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
	{
	}

	public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
	{
	}

	public static void Blit(Texture source, RenderTexture dest, Material mat)
	{
	}

	public static void Blit(Texture source, Material mat, [DefaultValue("-1")] int pass)
	{
	}

	public static void Blit(Texture source, Material mat)
	{
	}

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
	{
	}

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
	{
	}

	[ExcludeFromDocs]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
	}

	[ExcludeFromDocs]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
	{
	}

	[ExcludeFromDocs]
	public static void DrawTexture(Rect screenRect, Texture texture)
	{
	}

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt)
	{
	}

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel)
	{
	}

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
	{
	}

	private static void GetActiveColorBuffer_Injected(out RenderBuffer ret)
	{
		ret = default(RenderBuffer);
	}

	private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret)
	{
		ret = default(RenderBuffer);
	}

	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
	}

	private static void Internal_SetMRTSimple_Injected(RenderBuffer[] color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
	}

	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix)
	{
	}

	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
	}

	private static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset)
	{
	}
}
