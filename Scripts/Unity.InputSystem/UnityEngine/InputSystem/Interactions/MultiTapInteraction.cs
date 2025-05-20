namespace UnityEngine.InputSystem.Interactions;

public class MultiTapInteraction : IInputInteraction<float>, IInputInteraction
{
	private enum TapPhase
	{
		None = 0,
		WaitingForNextRelease = 1,
		WaitingForNextPress = 2
	}

	[Tooltip("The maximum time (in seconds) allowed to elapse between pressing and releasing a control for it to register as a tap.")]
	public float tapTime;

	[Tooltip("The maximum delay (in seconds) allowed between each tap. If this time is exceeded, the multi-tap is canceled.")]
	public float tapDelay;

	[Tooltip("How many taps need to be performed in succession. Two means double-tap, three means triple-tap, and so on.")]
	public int tapCount;

	public float pressPoint;

	private TapPhase m_CurrentTapPhase;

	private int m_CurrentTapCount;

	private double m_CurrentTapStartTime;

	private double m_LastTapReleaseTime;

	private float tapTimeOrDefault => 0f;

	internal float tapDelayOrDefault => 0f;

	private float pressPointOrDefault => 0f;

	private float releasePointOrDefault => 0f;

	public void Process(ref InputInteractionContext context)
	{
	}

	public void Reset()
	{
	}
}
