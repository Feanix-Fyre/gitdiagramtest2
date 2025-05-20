using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

internal struct GyroscopeState : IInputStateTypeInfo
{
	[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = true)]
	public Vector3 angularVelocity;

	public static FourCC kFormat => default(FourCC);

	public FourCC format => default(FourCC);
}
