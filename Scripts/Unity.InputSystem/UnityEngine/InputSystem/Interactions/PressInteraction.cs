using System.ComponentModel;

namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Press")]
public class PressInteraction : IInputInteraction
{
	[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to 'Default Press Point' in the global input settings.")]
	public float pressPoint;

	[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
	public PressBehavior behavior;

	private bool m_WaitingForRelease;

	private float pressPointOrDefault => 0f;

	private float releasePointOrDefault => 0f;

	public void Process(ref InputInteractionContext context)
	{
	}

	public void Reset()
	{
	}
}
