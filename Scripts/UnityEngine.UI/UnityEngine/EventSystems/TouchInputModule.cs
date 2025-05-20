using System;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Touch Input Module")]
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
public class TouchInputModule : PointerInputModule
{
	private Vector2 m_LastMousePosition;

	private Vector2 m_MousePosition;

	private PointerEventData m_InputPointerEvent;

	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	private bool m_ForceModuleActive;

	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnStandalone
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool forceModuleActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected TouchInputModule()
	{
	}

	public override void UpdateModule()
	{
	}

	public override bool IsModuleSupported()
	{
		return false;
	}

	public override bool ShouldActivateModule()
	{
		return false;
	}

	private bool UseFakeInput()
	{
		return false;
	}

	public override void Process()
	{
	}

	private void FakeTouches()
	{
	}

	private void ProcessTouchEvents()
	{
	}

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
	}

	public override void DeactivateModule()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
