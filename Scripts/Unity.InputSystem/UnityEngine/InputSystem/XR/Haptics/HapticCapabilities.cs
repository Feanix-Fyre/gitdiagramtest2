namespace UnityEngine.InputSystem.XR.Haptics;

public struct HapticCapabilities
{
	public uint numChannels { get; private set; }

	public uint frequencyHz { get; private set; }

	public uint maxBufferSize { get; private set; }

	public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize)
	{
		this.numChannels = 0u;
		this.frequencyHz = 0u;
		this.maxBufferSize = 0u;
	}
}
