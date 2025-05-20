namespace UnityEngine.Rendering.Universal.Internal;

public static class NormalReconstruction
{
	private static readonly int s_NormalReconstructionMatrixID;

	private static Matrix4x4[] s_NormalReconstructionMatrix;

	public static void SetupProperties(CommandBuffer cmd, in CameraData cameraData)
	{
	}
}
