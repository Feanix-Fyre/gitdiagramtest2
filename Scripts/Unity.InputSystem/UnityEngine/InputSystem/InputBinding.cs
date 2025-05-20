using System;

namespace UnityEngine.InputSystem;

[Serializable]
public struct InputBinding : IEquatable<InputBinding>
{
	[Flags]
	public enum DisplayStringOptions
	{
		DontUseShortDisplayNames = 1,
		DontOmitDevice = 2,
		DontIncludeInteractions = 4,
		IgnoreBindingOverrides = 8
	}

	[Flags]
	internal enum MatchOptions
	{
		EmptyGroupMatchesAny = 1
	}

	[Flags]
	internal enum Flags
	{
		None = 0,
		Composite = 4,
		PartOfComposite = 8
	}

	public const char Separator = ';';

	internal const string kSeparatorString = ";";

	[SerializeField]
	private string m_Name;

	[SerializeField]
	internal string m_Id;

	[Tooltip("Path of the control to bind to. Matched at runtime to controls from InputDevices present at the time.\n\nCan either be graphically from the control picker dropdown UI or edited manually in text mode by clicking the 'T' button. Internally, both methods result in control path strings that look like, for example, \"<Gamepad>/buttonSouth\".")]
	[SerializeField]
	private string m_Path;

	[SerializeField]
	private string m_Interactions;

	[SerializeField]
	private string m_Processors;

	[SerializeField]
	internal string m_Groups;

	[SerializeField]
	private string m_Action;

	[SerializeField]
	internal Flags m_Flags;

	[NonSerialized]
	private string m_OverridePath;

	[NonSerialized]
	private string m_OverrideInteractions;

	[NonSerialized]
	private string m_OverrideProcessors;

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Guid id
	{
		get
		{
			return default(Guid);
		}
		set
		{
		}
	}

	public string path
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string overridePath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string interactions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string overrideInteractions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string processors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string overrideProcessors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string groups
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string action
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isComposite
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isPartOfComposite
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool hasOverrides => false;

	public string effectivePath => null;

	public string effectiveInteractions => null;

	public string effectiveProcessors => null;

	internal bool isEmpty => false;

	public InputBinding(string path, string action = null, string groups = null, string processors = null, string interactions = null, string name = null)
	{
		m_Name = null;
		m_Id = null;
		m_Path = null;
		m_Interactions = null;
		m_Processors = null;
		m_Groups = null;
		m_Action = null;
		m_Flags = default(Flags);
		m_OverridePath = null;
		m_OverrideInteractions = null;
		m_OverrideProcessors = null;
	}

	public string GetNameOfComposite()
	{
		return null;
	}

	internal void GenerateId()
	{
	}

	internal void RemoveOverrides()
	{
	}

	public static InputBinding MaskByGroup(string group)
	{
		return default(InputBinding);
	}

	public static InputBinding MaskByGroups(params string[] groups)
	{
		return default(InputBinding);
	}

	public bool Equals(InputBinding other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static bool operator ==(InputBinding left, InputBinding right)
	{
		return false;
	}

	public static bool operator !=(InputBinding left, InputBinding right)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToDisplayString(DisplayStringOptions options = (DisplayStringOptions)0, InputControl control = null)
	{
		return null;
	}

	public string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options = (DisplayStringOptions)0, InputControl control = null)
	{
		deviceLayoutName = null;
		controlPath = null;
		return null;
	}

	internal bool TriggersAction(InputAction action)
	{
		return false;
	}

	public bool Matches(InputBinding binding)
	{
		return false;
	}

	internal bool Matches(ref InputBinding binding, MatchOptions options = (MatchOptions)0)
	{
		return false;
	}
}
