using System.Collections.Generic;

namespace UnityEngine.Rendering.UI;

internal class DebugUIHandlerPersistentCanvas : MonoBehaviour
{
	public RectTransform panel;

	public RectTransform valuePrefab;

	private List<DebugUIHandlerValue> m_Items;

	private List<DebugUI.ValueTuple> m_ValueTupleWidgets;

	internal void Toggle(DebugUI.Value widget, string displayName = null)
	{
	}

	internal void Toggle(DebugUI.ValueTuple widget, int? forceTupleIndex = null)
	{
	}

	internal bool IsEmpty()
	{
		return false;
	}

	internal void Clear()
	{
	}
}
