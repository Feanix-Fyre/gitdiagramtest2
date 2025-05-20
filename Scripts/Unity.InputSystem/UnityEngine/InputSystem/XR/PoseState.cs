using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.XR;

namespace UnityEngine.InputSystem.XR;

[StructLayout((LayoutKind)2, Size = 60)]
public struct PoseState : IInputStateTypeInfo
{
	internal const int kSizeInBytes = 60;

	internal static readonly FourCC s_Format;

	[FieldOffset(0)]
	[InputControl(displayName = "Is Tracked", layout = "Button", sizeInBits = 8u)]
	public bool isTracked;

	[FieldOffset(4)]
	[InputControl(displayName = "Tracking State", layout = "Integer")]
	public InputTrackingState trackingState;

	[FieldOffset(8)]
	[InputControl(displayName = "Position", noisy = true)]
	public Vector3 position;

	[FieldOffset(20)]
	[InputControl(displayName = "Rotation", noisy = true)]
	public Quaternion rotation;

	[FieldOffset(36)]
	[InputControl(displayName = "Velocity", noisy = true)]
	public Vector3 velocity;

	[FieldOffset(48)]
	[InputControl(displayName = "Angular Velocity", noisy = true)]
	public Vector3 angularVelocity;

	public FourCC format => default(FourCC);

	public PoseState(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity)
	{
		this.isTracked = false;
		this.trackingState = default(InputTrackingState);
		this.position = default(Vector3);
		this.rotation = default(Quaternion);
		this.velocity = default(Vector3);
		this.angularVelocity = default(Vector3);
	}
}
