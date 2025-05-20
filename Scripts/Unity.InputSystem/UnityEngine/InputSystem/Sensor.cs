using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(isGenericTypeOfDevice = true)]
public class Sensor : InputDevice
{
	public float samplingFrequency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
