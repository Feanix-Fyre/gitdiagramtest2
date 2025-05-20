namespace UnityEngine.InputSystem.Haptics;

internal struct DualMotorRumble
{
	public float lowFrequencyMotorSpeed { get; private set; }

	public float highFrequencyMotorSpeed { get; private set; }

	public bool isRumbling => false;

	public void PauseHaptics(InputDevice device)
	{
	}

	public void ResumeHaptics(InputDevice device)
	{
	}

	public void ResetHaptics(InputDevice device)
	{
	}

	public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency)
	{
	}
}
