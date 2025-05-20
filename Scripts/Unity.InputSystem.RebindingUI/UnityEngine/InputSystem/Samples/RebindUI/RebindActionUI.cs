using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.InputSystem.Samples.RebindUI;

public class RebindActionUI : MonoBehaviour
{
	[Serializable]
	public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
	{
	}

	[Serializable]
	public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
	{
	}

	[SerializeField]
	[Tooltip("Reference to action that is to be rebound from the UI.")]
	private InputActionReference m_Action;

	[SerializeField]
	private string m_BindingId;

	[SerializeField]
	private InputBinding.DisplayStringOptions m_DisplayStringOptions;

	[Tooltip("Text label that will receive the name of the action. Optional. Set to None to have the rebind UI not show a label for the action.")]
	[SerializeField]
	private Text m_ActionLabel;

	[Tooltip("Text label that will receive the current, formatted binding string.")]
	[SerializeField]
	private Text m_BindingText;

	[Tooltip("Optional UI that will be shown while a rebind is in progress.")]
	[SerializeField]
	private GameObject m_RebindOverlay;

	[Tooltip("Optional text label that will be updated with prompt for user input.")]
	[SerializeField]
	private Text m_RebindText;

	[SerializeField]
	[Tooltip("Event that is triggered when the way the binding is display should be updated. This allows displaying bindings in custom ways, e.g. using images instead of text.")]
	private UpdateBindingUIEvent m_UpdateBindingUIEvent;

	[SerializeField]
	[Tooltip("Event that is triggered when an interactive rebind is being initiated. This can be used, for example, to implement custom UI behavior while a rebind is in progress. It can also be used to further customize the rebind.")]
	private InteractiveRebindEvent m_RebindStartEvent;

	[SerializeField]
	[Tooltip("Event that is triggered when an interactive rebind is complete or has been aborted.")]
	private InteractiveRebindEvent m_RebindStopEvent;

	private InputActionRebindingExtensions.RebindingOperation m_RebindOperation;

	private static List<RebindActionUI> s_RebindActionUIs;

	public InputActionReference actionReference
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string bindingId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputBinding.DisplayStringOptions displayStringOptions
	{
		get
		{
			return default(InputBinding.DisplayStringOptions);
		}
		set
		{
		}
	}

	public Text actionLabel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Text bindingText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Text rebindPrompt
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject rebindOverlay
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UpdateBindingUIEvent updateBindingUIEvent => null;

	public InteractiveRebindEvent startRebindEvent => null;

	public InteractiveRebindEvent stopRebindEvent => null;

	public InputActionRebindingExtensions.RebindingOperation ongoingRebind => null;

	public bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
	{
		action = null;
		bindingIndex = default(int);
		return false;
	}

	public void UpdateBindingDisplay()
	{
	}

	public void ResetToDefault()
	{
	}

	public void StartInteractiveRebind()
	{
	}

	private void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	private static void OnActionChange(object obj, InputActionChange change)
	{
	}

	private void UpdateActionLabel()
	{
	}
}
