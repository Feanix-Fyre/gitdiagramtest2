using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Internal;

internal class ColumnMover : PointerManipulator
{
	private float m_StartPos;

	private float m_LastPos;

	private bool m_Active;

	private bool m_Moving;

	private bool m_Cancelled;

	private MultiColumnCollectionHeader m_Header;

	private VisualElement m_PreviewElement;

	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement;

	private Column m_ColumnToMove;

	private float m_ColumnToMovePos;

	private float m_ColumnToMoveWidth;

	private Column m_DestinationColumn;

	private bool m_MoveBeforeDestination;

	public ColumnLayout columnLayout { get; set; }

	public bool active
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool moving
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event Action<ColumnMover> activeChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ColumnMover> movingChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void RegisterCallbacksOnTarget()
	{
	}

	protected override void UnregisterCallbacksFromTarget()
	{
	}

	protected void OnMouseDown(MouseDownEvent evt)
	{
	}

	protected void OnMouseMove(MouseMoveEvent evt)
	{
	}

	protected void OnMouseUp(MouseUpEvent evt)
	{
	}

	private void OnMouseCaptureOut(MouseCaptureOutEvent evt)
	{
	}

	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
	{
	}

	private static bool IsNotMouseEvent(int pointerId)
	{
		return false;
	}

	protected void ProcessCancelEvent(EventBase evt, int pointerId)
	{
	}

	private void OnKeyDown(KeyDownEvent e)
	{
	}

	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	private void ProcessMoveEvent(EventBase e, Vector2 localPosition)
	{
	}

	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	private void BeginDragMove(float pos)
	{
	}

	internal void DragMove(float pos)
	{
	}

	private void UpdatePreviewPosition()
	{
	}

	private void UpdateMoveLocation()
	{
	}

	private void EndDragMove(bool cancelled)
	{
	}
}
