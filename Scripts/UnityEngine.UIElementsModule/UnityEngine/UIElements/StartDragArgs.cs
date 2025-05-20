using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal struct StartDragArgs
{
	public string title { get; }

	public DragVisualMode visualMode { get; }

	internal Hashtable genericData { get; private set; }

	internal IEnumerable<Object> unityObjectReferences { get; private set; }

	public StartDragArgs(string title, DragVisualMode visualMode)
	{
		this.title = null;
		this.visualMode = default(DragVisualMode);
		genericData = null;
		unityObjectReferences = null;
	}

	public void SetGenericData(string key, object data)
	{
	}
}
