using System.ComponentModel;

namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Tap")]
public class TapInteraction : IInputInteraction
{
	public float duration;

	public float pressPoint;

	private double m_TapStartTime;

	private float durationOrDefault => 0f;

	private float pressPointOrDefault => 0f;

	private float releasePointOrDefault => 0f;

	public void Process(ref InputInteractionContext context)
	{
	}

	public void Reset()
	{
	}
}
