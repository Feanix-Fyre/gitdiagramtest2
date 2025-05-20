using System;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;

namespace UnityEngine.InputSystem;

[Serializable]
public sealed class InputAction : ICloneable, IDisposable
{
	[Flags]
	internal enum ActionFlags
	{
		WantsInitialStateCheck = 1
	}

	public struct CallbackContext
	{
		internal InputActionState m_State;

		internal int m_ActionIndex;

		private int actionIndex => 0;

		private int bindingIndex => 0;

		private int controlIndex => 0;

		private int interactionIndex => 0;

		public InputActionPhase phase => default(InputActionPhase);

		public bool started => false;

		public bool performed => false;

		public bool canceled => false;

		public InputAction action => null;

		public InputControl control => null;

		public IInputInteraction interaction => null;

		public double time => 0.0;

		public double startTime => 0.0;

		public double duration => 0.0;

		public Type valueType => null;

		public int valueSizeInBytes => 0;

		public unsafe void ReadValue(void* buffer, int bufferSize)
		{
		}

		public TValue ReadValue<TValue>() where TValue : struct
		{
			return default(TValue);
		}

		public bool ReadValueAsButton()
		{
			return false;
		}

		public object ReadValueAsObject()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Tooltip("Human readable name of the action. Must be unique within its action map (case is ignored). Can be changed without breaking references to the action.")]
	[SerializeField]
	internal string m_Name;

	[Tooltip("Determines how the action triggers.\n\nA Value action will start and perform when a control moves from its default value and then perform on every value change. It will cancel when controls go back to default value. Also, when enabled, a Value action will respond right away to a control's current value.\n\nA Button action will start when a button is pressed and perform when the press threshold (see 'Default Button Press Point' in settings) is reached. It will cancel when the button is going below the release threshold (see 'Button Release Threshold' in settings). Also, if a button is already pressed when the action is enabled, the button has to be released first.\n\nA Pass-Through action will not explicitly start and will never cancel. Instead, for every value change on any bound control, the action will perform.")]
	[SerializeField]
	internal InputActionType m_Type;

	[Tooltip("The type of control expected by the action (e.g. \"Button\" or \"Stick\"). This will limit the controls shown when setting up bindings in the UI and will also limit which controls can be bound interactively to the action.")]
	[FormerlySerializedAs("m_ExpectedControlLayout")]
	[SerializeField]
	internal string m_ExpectedControlType;

	[SerializeField]
	[Tooltip("Unique ID of the action (GUID). Used to reference the action from bindings such that actions can be renamed without breaking references.")]
	internal string m_Id;

	[SerializeField]
	internal string m_Processors;

	[SerializeField]
	internal string m_Interactions;

	[SerializeField]
	internal InputBinding[] m_SingletonActionBindings;

	[SerializeField]
	internal ActionFlags m_Flags;

	[NonSerialized]
	internal InputBinding? m_BindingMask;

	[NonSerialized]
	internal int m_BindingsStartIndex;

	[NonSerialized]
	internal int m_BindingsCount;

	[NonSerialized]
	internal int m_ControlStartIndex;

	[NonSerialized]
	internal int m_ControlCount;

	[NonSerialized]
	internal int m_ActionIndexInState;

	[NonSerialized]
	internal InputActionMap m_ActionMap;

	[NonSerialized]
	internal CallbackArray<Action<CallbackContext>> m_OnStarted;

	[NonSerialized]
	internal CallbackArray<Action<CallbackContext>> m_OnCanceled;

	[NonSerialized]
	internal CallbackArray<Action<CallbackContext>> m_OnPerformed;

	public string name => null;

	public InputActionType type => default(InputActionType);

	public Guid id => default(Guid);

	internal Guid idDontGenerate => default(Guid);

	public string expectedControlType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string processors => null;

	public string interactions => null;

	public InputActionMap actionMap => null;

	public InputBinding? bindingMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputBinding> bindings => default(ReadOnlyArray<InputBinding>);

	public ReadOnlyArray<InputControl> controls => default(ReadOnlyArray<InputControl>);

	public InputActionPhase phase => default(InputActionPhase);

	public bool inProgress => false;

	public bool enabled => false;

	public bool triggered => false;

	public InputControl activeControl => null;

	public bool wantsInitialStateCheck
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isSingletonAction => false;

	private InputActionState.TriggerState currentState => default(InputActionState.TriggerState);

	public event Action<CallbackContext> started
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<CallbackContext> canceled
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<CallbackContext> performed
	{
		add
		{
		}
		remove
		{
		}
	}

	public InputAction()
	{
	}

	public InputAction(string name = null, InputActionType type = InputActionType.Value, string binding = null, string interactions = null, string processors = null, string expectedControlType = null)
	{
	}

	public void Dispose()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputAction Clone()
	{
		return null;
	}

	object ICloneable.Clone()
	{
		return null;
	}

	public TValue ReadValue<TValue>() where TValue : struct
	{
		return default(TValue);
	}

	public object ReadValueAsObject()
	{
		return null;
	}

	public void Reset()
	{
	}

	public bool IsPressed()
	{
		return false;
	}

	public bool IsInProgress()
	{
		return false;
	}

	public bool WasPressedThisFrame()
	{
		return false;
	}

	public bool WasReleasedThisFrame()
	{
		return false;
	}

	public bool WasPerformedThisFrame()
	{
		return false;
	}

	public float GetTimeoutCompletionPercentage()
	{
		return 0f;
	}

	internal string MakeSureIdIsInPlace()
	{
		return null;
	}

	internal void GenerateId()
	{
	}

	internal InputActionMap GetOrCreateActionMap()
	{
		return null;
	}

	private void CreateInternalActionMapForSingletonAction()
	{
	}

	internal void RequestInitialStateCheckOnEnabledAction()
	{
	}

	internal bool ActiveControlIsValid(InputControl control)
	{
		return false;
	}

	internal InputBinding? FindEffectiveBindingMask()
	{
		return null;
	}

	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction)
	{
		return 0;
	}

	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap)
	{
		return 0;
	}
}
