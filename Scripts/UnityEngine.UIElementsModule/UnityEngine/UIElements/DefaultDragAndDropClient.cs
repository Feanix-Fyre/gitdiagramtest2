using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop
{
	private readonly Hashtable m_GenericData;

	private Label m_DraggedInfoLabel;

	private DragVisualMode m_VisualMode;

	private IEnumerable<Object> m_UnityObjectReferences;

	public override object source => null;

	public DragAndDropData data => null;

	public override object GetGenericData(string key)
	{
		return null;
	}

	public void StartDrag(StartDragArgs args, Vector3 pointerPosition)
	{
	}

	public void UpdateDrag(Vector3 pointerPosition)
	{
	}

	public void AcceptDrag()
	{
	}

	public void SetVisualMode(DragVisualMode mode)
	{
	}

	public void DragCleanup()
	{
	}
}
