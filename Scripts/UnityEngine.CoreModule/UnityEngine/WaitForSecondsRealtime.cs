namespace UnityEngine;

public class WaitForSecondsRealtime : CustomYieldInstruction
{
	private float m_WaitUntilTime;

	public float waitTime { get; set; }

	public override bool keepWaiting => false;

	public WaitForSecondsRealtime(float time)
	{
	}

	public override void Reset()
	{
	}
}
