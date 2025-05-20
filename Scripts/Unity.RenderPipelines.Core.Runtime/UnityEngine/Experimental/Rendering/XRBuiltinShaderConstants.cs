using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

public static class XRBuiltinShaderConstants
{
	public static readonly int unity_StereoCameraProjection;

	public static readonly int unity_StereoCameraInvProjection;

	public static readonly int unity_StereoMatrixV;

	public static readonly int unity_StereoMatrixInvV;

	public static readonly int unity_StereoMatrixP;

	public static readonly int unity_StereoMatrixInvP;

	public static readonly int unity_StereoMatrixVP;

	public static readonly int unity_StereoMatrixInvVP;

	public static readonly int unity_StereoWorldSpaceCameraPos;

	private static Matrix4x4[] s_cameraProjMatrix;

	private static Matrix4x4[] s_invCameraProjMatrix;

	private static Matrix4x4[] s_viewMatrix;

	private static Matrix4x4[] s_invViewMatrix;

	private static Matrix4x4[] s_projMatrix;

	private static Matrix4x4[] s_invProjMatrix;

	private static Matrix4x4[] s_viewProjMatrix;

	private static Matrix4x4[] s_invViewProjMatrix;

	private static Vector4[] s_worldSpaceCameraPos;

	public static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex)
	{
	}

	public static void SetBuiltinShaderConstants(CommandBuffer cmd)
	{
	}

	public static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture)
	{
	}
}
