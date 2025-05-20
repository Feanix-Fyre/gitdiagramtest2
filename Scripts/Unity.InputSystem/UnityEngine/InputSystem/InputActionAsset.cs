using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable
{
	[Serializable]
	internal struct WriteFileJson
	{
		public string name;

		public InputActionMap.WriteMapJson[] maps;

		public InputControlScheme.SchemeJson[] controlSchemes;
	}

	[Serializable]
	internal struct ReadFileJson
	{
		public string name;

		public InputActionMap.ReadMapJson[] maps;

		public InputControlScheme.SchemeJson[] controlSchemes;

		public void ToAsset(InputActionAsset asset)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__31 : IEnumerator<InputAction>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private InputAction _003C_003E2__current;

		public InputActionAsset _003C_003E4__this;

		private int _003Ci_003E5__2;

		private ReadOnlyArray<InputAction> _003Cactions_003E5__3;

		private int _003CactionCount_003E5__4;

		private int _003Cn_003E5__5;

		InputAction IEnumerator<InputAction>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_bindings_003Ed__8 : IEnumerable<InputBinding>, IEnumerable, IEnumerator<InputBinding>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private InputBinding _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public InputActionAsset _003C_003E4__this;

		private int _003CnumActionMaps_003E5__2;

		private int _003Ci_003E5__3;

		private InputBinding[] _003Cbindings_003E5__4;

		private int _003CnumBindings_003E5__5;

		private int _003Cn_003E5__6;

		InputBinding IEnumerator<InputBinding>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(InputBinding);
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003Cget_bindings_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<InputBinding> IEnumerable<InputBinding>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public const string Extension = "inputactions";

	[SerializeField]
	internal InputActionMap[] m_ActionMaps;

	[SerializeField]
	internal InputControlScheme[] m_ControlSchemes;

	[NonSerialized]
	internal InputActionState m_SharedStateForAllMaps;

	[NonSerialized]
	internal InputBinding? m_BindingMask;

	[NonSerialized]
	internal int m_ParameterOverridesCount;

	[NonSerialized]
	internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;

	[NonSerialized]
	internal InputActionMap.DeviceArray m_Devices;

	public bool enabled => false;

	public ReadOnlyArray<InputActionMap> actionMaps => default(ReadOnlyArray<InputActionMap>);

	public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

	public IEnumerable<InputBinding> bindings
	{
		[IteratorStateMachine(typeof(_003Cget_bindings_003Ed__8))]
		get
		{
			return null;
		}
	}

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

	public string ToJson()
	{
		return null;
	}

	public void LoadFromJson(string json)
	{
	}

	public static InputActionAsset FromJson(string json)
	{
		return null;
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public int FindBinding(InputBinding mask, out InputAction action)
	{
		action = null;
		return 0;
	}

	public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public InputActionMap FindActionMap(Guid id)
	{
		return null;
	}

	public InputAction FindAction(Guid guid)
	{
		return null;
	}

	public int FindControlSchemeIndex(string name)
	{
		return 0;
	}

	public InputControlScheme? FindControlScheme(string name)
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

	public bool Contains(InputAction action)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__31))]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal void MarkAsDirty()
	{
	}

	internal void OnWantToChangeSetup()
	{
	}

	internal void OnSetupChanged()
	{
	}

	private void ReResolveIfNecessary(bool fullResolve)
	{
	}

	internal void ResolveBindingsIfNecessary()
	{
	}

	private void OnDestroy()
	{
	}
}
