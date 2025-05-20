namespace UnityEngine.Rendering;

internal static class Hammersley
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.11\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
	private struct Hammersley2dSeq16
	{
		[HLSLArray(16, typeof(Vector4))]
		public unsafe fixed float hammersley2dSeq16[64];
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.11\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
	private struct Hammersley2dSeq32
	{
		[HLSLArray(32, typeof(Vector4))]
		public unsafe fixed float hammersley2dSeq32[128];
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.11\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
	private struct Hammersley2dSeq64
	{
		[HLSLArray(64, typeof(Vector4))]
		public unsafe fixed float hammersley2dSeq64[256];
	}

	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@14.0.11\\Runtime\\ShaderLibrary\\Sampling\\Hammersley.cs", needAccessors = false, generateCBuffer = true)]
	private struct Hammersley2dSeq256
	{
		[HLSLArray(256, typeof(Vector4))]
		public unsafe fixed float hammersley2dSeq256[1024];
	}

	private static float[] k_Hammersley2dSeq16;

	private static float[] k_Hammersley2dSeq32;

	private static float[] k_Hammersley2dSeq64;

	private static float[] k_Hammersley2dSeq256;

	private static readonly int s_hammersley2DSeq16Id;

	private static readonly int s_hammersley2DSeq32Id;

	private static readonly int s_hammersley2DSeq64Id;

	private static readonly int s_hammersley2DSeq256Id;

	public static void Initialize()
	{
	}

	public static void BindConstants(CommandBuffer cmd, ComputeShader cs)
	{
	}
}
