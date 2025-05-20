using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

internal struct GravityState : IInputStateTypeInfo
{
	[InputControl(displayName = "Gravity", processors = "CompensateDirection", noisy = true)]
	public Vector3 gravity;

	public static FourCC kFormat => default(FourCC);

	public FourCC format => default(FourCC);
}
