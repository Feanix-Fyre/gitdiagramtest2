using System;

namespace UnityEngine.InputSystem;

public static class InputActionSetupExtensions
{
	public struct BindingSyntax
	{
		private readonly InputActionMap m_ActionMap;

		private readonly InputAction m_Action;

		internal readonly int m_BindingIndexInMap;

		public bool valid => false;

		public int bindingIndex => 0;

		public InputBinding binding => default(InputBinding);

		internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null)
		{
			m_ActionMap = null;
			m_Action = null;
			m_BindingIndexInMap = 0;
		}

		public BindingSyntax WithName(string name)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithPath(string path)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithGroup(string group)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithGroups(string groups)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithInteraction(string interaction)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithInteractions(string interactions)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithInteraction<TInteraction>() where TInteraction : IInputInteraction
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithProcessor(string processor)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithProcessors(string processors)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax WithProcessor<TProcessor>()
		{
			return default(BindingSyntax);
		}

		public BindingSyntax Triggering(InputAction action)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax To(InputBinding binding)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax NextBinding()
		{
			return default(BindingSyntax);
		}

		public BindingSyntax PreviousBinding()
		{
			return default(BindingSyntax);
		}

		public BindingSyntax NextPartBinding(string partName)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax PreviousPartBinding(string partName)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax NextCompositeBinding(string compositeName = null)
		{
			return default(BindingSyntax);
		}

		public BindingSyntax PreviousCompositeBinding(string compositeName = null)
		{
			return default(BindingSyntax);
		}

		private BindingSyntax Iterate(bool next)
		{
			return default(BindingSyntax);
		}

		private BindingSyntax IterateCompositeBinding(bool next, string compositeName)
		{
			return default(BindingSyntax);
		}

		private BindingSyntax IteratePartBinding(bool next, string partName)
		{
			return default(BindingSyntax);
		}

		public void Erase()
		{
		}

		public BindingSyntax InsertPartBinding(string partName, string path)
		{
			return default(BindingSyntax);
		}
	}

	public struct CompositeSyntax
	{
		private readonly InputAction m_Action;

		private readonly InputActionMap m_ActionMap;

		private int m_BindingIndexInMap;

		public int bindingIndex => 0;

		internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex)
		{
			m_Action = null;
			m_ActionMap = null;
			m_BindingIndexInMap = 0;
		}

		public CompositeSyntax With(string name, string binding, string groups = null, string processors = null)
		{
			return default(CompositeSyntax);
		}
	}

	public struct ControlSchemeSyntax
	{
		private readonly InputActionAsset m_Asset;

		private readonly int m_ControlSchemeIndex;

		private InputControlScheme m_ControlScheme;

		internal ControlSchemeSyntax(InputActionAsset asset, int index)
		{
			m_Asset = null;
			m_ControlSchemeIndex = 0;
			m_ControlScheme = default(InputControlScheme);
		}

		internal ControlSchemeSyntax(InputControlScheme controlScheme)
		{
			m_Asset = null;
			m_ControlSchemeIndex = 0;
			m_ControlScheme = default(InputControlScheme);
		}

		public ControlSchemeSyntax WithBindingGroup(string bindingGroup)
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax WithRequiredDevice<TDevice>() where TDevice : InputDevice
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax WithOptionalDevice<TDevice>() where TDevice : InputDevice
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax OrWithRequiredDevice<TDevice>() where TDevice : InputDevice
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax OrWithOptionalDevice<TDevice>() where TDevice : InputDevice
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax WithRequiredDevice(string controlPath)
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax WithOptionalDevice(string controlPath)
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax OrWithRequiredDevice(string controlPath)
		{
			return default(ControlSchemeSyntax);
		}

		public ControlSchemeSyntax OrWithOptionalDevice(string controlPath)
		{
			return default(ControlSchemeSyntax);
		}

		private string DeviceTypeToControlPath<TDevice>() where TDevice : InputDevice
		{
			return null;
		}

		public InputControlScheme Done()
		{
			return default(InputControlScheme);
		}

		private void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags)
		{
		}
	}

	public static InputActionMap AddActionMap(this InputActionAsset asset, string name)
	{
		return null;
	}

	public static void AddActionMap(this InputActionAsset asset, InputActionMap map)
	{
	}

	public static void RemoveActionMap(this InputActionAsset asset, InputActionMap map)
	{
	}

	public static void RemoveActionMap(this InputActionAsset asset, string nameOrId)
	{
	}

	public static InputAction AddAction(this InputActionMap map, string name, InputActionType type = InputActionType.Value, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null)
	{
		return null;
	}

	public static void RemoveAction(this InputAction action)
	{
	}

	public static void RemoveAction(this InputActionAsset asset, string nameOrId)
	{
	}

	public static BindingSyntax AddBinding(this InputAction action, string path, string interactions = null, string processors = null, string groups = null)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax AddBinding(this InputAction action, InputControl control)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax AddBinding(this InputAction action, InputBinding binding = default(InputBinding))
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, InputBinding binding)
	{
		return default(BindingSyntax);
	}

	public static CompositeSyntax AddCompositeBinding(this InputAction action, string composite, string interactions = null, string processors = null)
	{
		return default(CompositeSyntax);
	}

	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1)
	{
		return 0;
	}

	public static BindingSyntax ChangeBinding(this InputAction action, int index)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeBinding(this InputAction action, string name)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeBinding(this InputActionMap actionMap, int index)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeBindingWithId(this InputAction action, string id)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeBindingWithId(this InputAction action, Guid id)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeBindingWithGroup(this InputAction action, string group)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeBindingWithPath(this InputAction action, string path)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeBinding(this InputAction action, InputBinding match)
	{
		return default(BindingSyntax);
	}

	public static BindingSyntax ChangeCompositeBinding(this InputAction action, string compositeName)
	{
		return default(BindingSyntax);
	}

	public static void Rename(this InputAction action, string newName)
	{
	}

	public static void AddControlScheme(this InputActionAsset asset, InputControlScheme controlScheme)
	{
	}

	public static ControlSchemeSyntax AddControlScheme(this InputActionAsset asset, string name)
	{
		return default(ControlSchemeSyntax);
	}

	public static void RemoveControlScheme(this InputActionAsset asset, string name)
	{
	}

	public static InputControlScheme WithBindingGroup(this InputControlScheme scheme, string bindingGroup)
	{
		return default(InputControlScheme);
	}

	public static InputControlScheme WithDevice(this InputControlScheme scheme, string controlPath, bool required)
	{
		return default(InputControlScheme);
	}

	public static InputControlScheme WithRequiredDevice(this InputControlScheme scheme, string controlPath)
	{
		return default(InputControlScheme);
	}

	public static InputControlScheme WithOptionalDevice(this InputControlScheme scheme, string controlPath)
	{
		return default(InputControlScheme);
	}

	public static InputControlScheme OrWithRequiredDevice(this InputControlScheme scheme, string controlPath)
	{
		return default(InputControlScheme);
	}

	public static InputControlScheme OrWithOptionalDevice(this InputControlScheme scheme, string controlPath)
	{
		return default(InputControlScheme);
	}
}
