using System.ComponentModel;

namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Hold")]
public class HoldInteraction : IInputInteraction
{
	public float duration;

	public float pressPoint;

	private double m_TimePressed;

	private float durationOrDefault => 0f;

	private float pressPointOrDefault => 0f;

	public void Process(ref InputInteractionContext context)
	{
	}

	public void Reset()
	{
	}
}
