using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

internal struct AttitudeState : IInputStateTypeInfo
{
	[InputControl(displayName = "Attitude", processors = "CompensateRotation", noisy = true)]
	public Quaternion attitude;

	public static FourCC kFormat => default(FourCC);

	public FourCC format => default(FourCC);
}
