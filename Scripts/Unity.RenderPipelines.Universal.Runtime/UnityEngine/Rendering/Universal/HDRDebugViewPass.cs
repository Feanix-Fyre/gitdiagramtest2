namespace UnityEngine.Rendering.Universal;

internal class HDRDebugViewPass : ScriptableRenderPass
{
	private enum HDRDebugPassId
	{
		CIExyPrepass = 0,
		DebugViewPass = 1
	}

	private class PassData
	{
		internal Material material;

		internal HDRDebugMode hdrDebugMode;

		internal Vector4 luminanceParameters;

		internal CameraData cameraData;
	}

	internal class ShaderConstants
	{
		public static readonly int _DebugHDRModeId;

		public static readonly int _HDRDebugParamsId;

		public static readonly int _xyTextureId;

		public static readonly int _SizeOfHDRXYMapping;

		public static readonly int _CIExyUAVIndex;
	}

	private PassData m_PassData;

	private RTHandle m_CIExyTarget;

	private RTHandle m_PassthroughRT;

	private RTHandle m_CameraTargetHandle;

	public HDRDebugViewPass(Material mat)
	{
	}

	public static void ConfigureDescriptor(ref RenderTextureDescriptor descriptor)
	{
	}

	public static void ConfigureDescriptorForCIEPrepass(ref RenderTextureDescriptor descriptor)
	{
	}

	internal static Vector4 GetLuminanceParameters(ref CameraData cameraData)
	{
		return default(Vector4);
	}

	private static void ExecuteCIExyPrepass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle xyTarget, RTHandle destTexture)
	{
	}

	private static void ExecuteHDRDebugViewFinalPass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle destination, RTHandle xyTarget)
	{
	}

	public void Dispose()
	{
	}

	public void Setup(ref CameraData cameraData, HDRDebugMode hdrdebugMode)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void ExecutePass(CommandBuffer cmd, PassData data, RTHandle sourceTexture, RTHandle xyTarget)
	{
	}
}
