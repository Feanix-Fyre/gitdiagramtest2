using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct CameraProperties : IEquatable<CameraProperties>
{
	private const int k_NumLayers = 32;

	private Rect screenRect;

	private Vector3 viewDir;

	private float projectionNear;

	private float projectionFar;

	private float cameraNear;

	private float cameraFar;

	private float cameraAspect;

	private Matrix4x4 cameraToWorld;

	private Matrix4x4 actualWorldToClip;

	private Matrix4x4 cameraClipToWorld;

	private Matrix4x4 cameraWorldToClip;

	private Matrix4x4 implicitProjection;

	private Matrix4x4 stereoWorldToClipLeft;

	private Matrix4x4 stereoWorldToClipRight;

	private Matrix4x4 worldToCamera;

	private Vector3 up;

	private Vector3 right;

	private Vector3 transformDirection;

	private Vector3 cameraEuler;

	private Vector3 velocity;

	private float farPlaneWorldSpaceLength;

	private uint rendererCount;

	private const int k_PlaneCount = 6;

	internal unsafe fixed byte m_ShadowCullPlanes[96];

	internal unsafe fixed byte m_CameraCullPlanes[96];

	private float baseFarDistance;

	private Vector3 shadowCullCenter;

	internal unsafe fixed float layerCullDistances[32];

	private int layerCullSpherical;

	private CoreCameraValues coreCameraValues;

	private uint cameraType;

	private int projectionIsOblique;

	private int isImplicitProjectionMatrix;

	public Plane GetShadowCullingPlane(int index)
	{
		return default(Plane);
	}

	public Plane GetCameraCullingPlane(int index)
	{
		return default(Plane);
	}

	public bool Equals(CameraProperties other)
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
}
