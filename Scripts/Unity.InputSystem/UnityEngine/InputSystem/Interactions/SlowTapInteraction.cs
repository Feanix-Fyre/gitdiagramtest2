using System.ComponentModel;

namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Long Tap")]
public class SlowTapInteraction : IInputInteraction
{
	public float duration;

	public float pressPoint;

	private double m_SlowTapStartTime;

	private float durationOrDefault => 0f;

	private float pressPointOrDefault => 0f;

	public void Process(ref InputInteractionContext context)
	{
	}

	public void Reset()
	{
	}
}
