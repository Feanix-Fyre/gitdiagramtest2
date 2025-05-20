using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class InputEvent : EventBase<InputEvent>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CpreviousData_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CnewData_003Ek__BackingField;

	protected string previousData
	{
		[CompilerGenerated]
		set
		{
			_003CpreviousData_003Ek__BackingField = value;
		}
	}

	protected string newData
	{
		[CompilerGenerated]
		set
		{
			_003CnewData_003Ek__BackingField = value;
		}
	}

	static InputEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static InputEvent GetPooled(string previousData, string newData)
	{
		return null;
	}
}
