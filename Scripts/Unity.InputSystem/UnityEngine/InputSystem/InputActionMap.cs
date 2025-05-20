using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[Serializable]
public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Flags]
	private enum Flags
	{
		NeedToResolveBindings = 1,
		BindingResolutionNeedsFullReResolve = 2,
		ControlsForEachActionInitialized = 4,
		BindingsForEachActionInitialized = 8
	}

	internal struct DeviceArray
	{
		private bool m_HaveValue;

		private int m_DeviceCount;

		private InputDevice[] m_DeviceArray;

		public int IndexOf(InputDevice device)
		{
			return 0;
		}

		public bool Remove(InputDevice device)
		{
			return false;
		}

		public ReadOnlyArray<InputDevice>? Get()
		{
			return null;
		}

		public bool Set(ReadOnlyArray<InputDevice>? devices)
		{
			return false;
		}
	}

	[Serializable]
	internal struct BindingOverrideListJson
	{
		public List<BindingOverrideJson> bindings;
	}

	[Serializable]
	internal struct BindingOverrideJson
	{
		public string action;

		public string id;

		public string path;

		public string interactions;

		public string processors;

		public static BindingOverrideJson FromBinding(InputBinding binding, string actionName)
		{
			return default(BindingOverrideJson);
		}

		public static BindingOverrideJson FromBinding(InputBinding binding)
		{
			return default(BindingOverrideJson);
		}

		public static InputBinding ToBinding(BindingOverrideJson bindingOverride)
		{
			return default(InputBinding);
		}
	}

	[Serializable]
	internal struct BindingJson
	{
		public string name;

		public string id;

		public string path;

		public string interactions;

		public string processors;

		public string groups;

		public string action;

		public bool isComposite;

		public bool isPartOfComposite;

		public InputBinding ToBinding()
		{
			return default(InputBinding);
		}

		public static BindingJson FromBinding(ref InputBinding binding)
		{
			return default(BindingJson);
		}
	}

	[Serializable]
	internal struct ReadActionJson
	{
		public string name;

		public string type;

		public string id;

		public string expectedControlType;

		public string expectedControlLayout;

		public string processors;

		public string interactions;

		public bool passThrough;

		public bool initialStateCheck;

		public BindingJson[] bindings;

		public InputAction ToAction(string actionName = null)
		{
			return null;
		}
	}

	[Serializable]
	internal struct WriteActionJson
	{
		public string name;

		public string type;

		public string id;

		public string expectedControlType;

		public string processors;

		public string interactions;

		public bool initialStateCheck;

		public static WriteActionJson FromAction(InputAction action)
		{
			return default(WriteActionJson);
		}
	}

	[Serializable]
	internal struct ReadMapJson
	{
		public string name;

		public string id;

		public ReadActionJson[] actions;

		public BindingJson[] bindings;
	}

	[Serializable]
	internal struct WriteMapJson
	{
		public string name;

		public string id;

		public WriteActionJson[] actions;

		public BindingJson[] bindings;

		public static WriteMapJson FromMap(InputActionMap map)
		{
			return default(WriteMapJson);
		}
	}

	[Serializable]
	internal struct WriteFileJson
	{
		public WriteMapJson[] maps;

		public static WriteFileJson FromMap(InputActionMap map)
		{
			return default(WriteFileJson);
		}

		public static WriteFileJson FromMaps(IEnumerable<InputActionMap> maps)
		{
			return default(WriteFileJson);
		}
	}

	[Serializable]
	internal struct ReadFileJson
	{
		public ReadActionJson[] actions;

		public ReadMapJson[] maps;

		public InputActionMap[] ToMaps()
		{
			return null;
		}
	}

	[SerializeField]
	internal string m_Name;

	[SerializeField]
	internal string m_Id;

	[SerializeField]
	internal InputActionAsset m_Asset;

	[SerializeField]
	internal InputAction[] m_Actions;

	[SerializeField]
	internal InputBinding[] m_Bindings;

	[NonSerialized]
	private InputBinding[] m_BindingsForEachAction;

	[NonSerialized]
	private InputControl[] m_ControlsForEachAction;

	[NonSerialized]
	internal int m_EnabledActionsCount;

	[NonSerialized]
	internal InputAction m_SingletonAction;

	[NonSerialized]
	internal int m_MapIndexInState;

	[NonSerialized]
	internal InputActionState m_State;

	[NonSerialized]
	internal InputBinding? m_BindingMask;

	[NonSerialized]
	private Flags m_Flags;

	[NonSerialized]
	internal int m_ParameterOverridesCount;

	[NonSerialized]
	internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;

	[NonSerialized]
	internal DeviceArray m_Devices;

	[NonSerialized]
	internal CallbackArray<Action<InputAction.CallbackContext>> m_ActionCallbacks;

	[NonSerialized]
	internal Dictionary<string, int> m_ActionIndexByNameOrId;

	internal static int s_DeferBindingResolution;

	public string name => null;

	public InputActionAsset asset => null;

	public Guid id => default(Guid);

	internal Guid idDontGenerate => default(Guid);

	public bool enabled => false;

	public ReadOnlyArray<InputAction> actions => default(ReadOnlyArray<InputAction>);

	public ReadOnlyArray<InputBinding> bindings => default(ReadOnlyArray<InputBinding>);

	IEnumerable<InputBinding> IInputActionCollection2.bindings => null;

	public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

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

	public ReadOnlyArray<InputDevice>? devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputAction this[string actionNameOrId] => null;

	private bool needToResolveBindings
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool bindingResolutionNeedsFullReResolve
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool controlsForEachActionInitialized
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool bindingsForEachActionInitialized
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event Action<InputAction.CallbackContext> actionTriggered
	{
		add
		{
		}
		remove
		{
		}
	}

	public InputActionMap()
	{
	}

	public InputActionMap(string name)
	{
	}

	public void Dispose()
	{
	}

	internal int FindActionIndex(string nameOrId)
	{
		return 0;
	}

	private void SetUpActionLookupTable()
	{
	}

	internal void ClearActionLookupTable()
	{
	}

	private int FindActionIndex(Guid id)
	{
		return 0;
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public InputAction FindAction(Guid id)
	{
		return null;
	}

	public bool IsUsableWithDevice(InputDevice device)
	{
		return false;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputActionMap Clone()
	{
		return null;
	}

	object ICloneable.Clone()
	{
		return null;
	}

	public bool Contains(InputAction action)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action)
	{
		return default(ReadOnlyArray<InputBinding>);
	}

	internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action)
	{
		return default(ReadOnlyArray<InputControl>);
	}

	private void SetUpPerActionControlAndBindingArrays()
	{
	}

	internal void OnWantToChangeSetup()
	{
	}

	internal void OnSetupChanged()
	{
	}

	internal void OnBindingModified()
	{
	}

	internal void ClearCachedActionData(bool onlyControls = false)
	{
	}

	internal void GenerateId()
	{
	}

	internal bool LazyResolveBindings(bool fullResolve)
	{
		return false;
	}

	internal bool ResolveBindingsIfNecessary()
	{
		return false;
	}

	internal void ResolveBindings()
	{
	}

	public int FindBinding(InputBinding mask, out InputAction action)
	{
		action = null;
		return 0;
	}

	internal int FindBindingRelativeToMap(InputBinding mask)
	{
		return 0;
	}

	public static InputActionMap[] FromJson(string json)
	{
		return null;
	}

	public static string ToJson(IEnumerable<InputActionMap> maps)
	{
		return null;
	}

	public string ToJson()
	{
		return null;
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
