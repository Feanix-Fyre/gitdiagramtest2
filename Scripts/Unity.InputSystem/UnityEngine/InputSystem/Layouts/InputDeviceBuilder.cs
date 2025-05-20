using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts;

internal struct InputDeviceBuilder : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct RefInstance : IDisposable
	{
		public void Dispose()
		{
		}
	}

	private InputDevice m_Device;

	private InputControlLayout.CacheRefInstance m_LayoutCacheRef;

	private Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides;

	private List<uint> m_StateOffsetToControlMap;

	private StringBuilder m_StringBuilder;

	private const uint kSizeForControlUsingStateFromOtherControl = uint.MaxValue;

	private static InputDeviceBuilder s_Instance;

	private static int s_InstanceRef;

	internal static ref InputDeviceBuilder instance
	{
		get
		{
			throw null;
		}
	}

	public void Setup(InternedString layout, InternedString variants, InputDeviceDescription deviceDescription = default(InputDeviceDescription))
	{
	}

	public InputDevice Finish()
	{
		return null;
	}

	public void Dispose()
	{
	}

	private void Reset()
	{
	}

	private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent)
	{
		return null;
	}

	private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent)
	{
		return null;
	}

	private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls)
	{
	}

	private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride = null)
	{
		return null;
	}

	private void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem)
	{
	}

	private string ChildControlOverridePath(InputControl parent, InternedString controlName)
	{
		return null;
	}

	private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem)
	{
	}

	private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem)
	{
		return null;
	}

	private static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout)
	{
	}

	private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl)
	{
	}

	private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName)
	{
	}

	private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName)
	{
	}

	private static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName)
	{
	}

	private static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem)
	{
	}

	private static InputControlLayout FindOrLoadLayout(string name)
	{
		return null;
	}

	private static void ComputeStateLayout(InputControl control)
	{
	}

	private void FinalizeControlHierarchy()
	{
	}

	private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex)
	{
	}

	private void InsertControlBitRangeNode(ref InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset)
	{
	}

	private ushort GetBestMidPoint(InputDevice.ControlBitRangeNode parent, ushort startOffset)
	{
		return 0;
	}

	private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex)
	{
	}

	private void AddChildren(ref InputDevice.ControlBitRangeNode parent, InputDevice.ControlBitRangeNode left, InputDevice.ControlBitRangeNode right)
	{
	}

	private ushort GetControlIndex(InputControl control)
	{
		return 0;
	}

	internal static RefInstance Ref()
	{
		return default(RefInstance);
	}
}
