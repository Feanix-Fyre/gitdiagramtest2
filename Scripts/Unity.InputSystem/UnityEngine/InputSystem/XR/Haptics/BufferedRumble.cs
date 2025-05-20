namespace UnityEngine.InputSystem.XR.Haptics;

public struct BufferedRumble
{
	public HapticCapabilities capabilities { get; private set; }

	private InputDevice device { get; set; }

	public BufferedRumble(InputDevice device)
	{
		capabilities = default(HapticCapabilities);
		this.device = null;
	}

	public void EnqueueRumble(byte[] samples)
	{
	}
}
