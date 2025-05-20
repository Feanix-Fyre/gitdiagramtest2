using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI;

[AddComponentMenu("UI/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
{
	public enum Direction
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3
	}

	[Serializable]
	public class ScrollEvent : UnityEvent<float>
	{
	}

	private enum Axis
	{
		Horizontal = 0,
		Vertical = 1
	}

	[CompilerGenerated]
	private sealed class _003CClickRepeat_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Scrollbar _003C_003E4__this;

		public Vector2 screenPosition;

		public Camera camera;

		object IEnumerator<object>.Current
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
		public _003CClickRepeat_003Ed__58(int _003C_003E1__state)
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

	[SerializeField]
	private RectTransform m_HandleRect;

	[SerializeField]
	private Direction m_Direction;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_Value;

	[Range(0f, 1f)]
	[SerializeField]
	private float m_Size;

	[Range(0f, 11f)]
	[SerializeField]
	private int m_NumberOfSteps;

	[Space(6f)]
	[SerializeField]
	private ScrollEvent m_OnValueChanged;

	private RectTransform m_ContainerRect;

	private Vector2 m_Offset;

	private DrivenRectTransformTracker m_Tracker;

	private Coroutine m_PointerDownRepeat;

	private bool isPointerDownAndNotDragging;

	private bool m_DelayedUpdateVisuals;

	public RectTransform handleRect
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Direction direction
	{
		get
		{
			return default(Direction);
		}
		set
		{
		}
	}

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float size
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int numberOfSteps
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ScrollEvent onValueChanged
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private float stepSize => 0f;

	private Axis axis => default(Axis);

	private bool reverseValue => false;

	Transform ICanvasElement.transform => null;

	protected Scrollbar()
	{
	}

	public virtual void SetValueWithoutNotify(float input)
	{
	}

	public virtual void Rebuild(CanvasUpdate executing)
	{
	}

	public virtual void LayoutComplete()
	{
	}

	public virtual void GraphicUpdateComplete()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected virtual void Update()
	{
	}

	private void UpdateCachedReferences()
	{
	}

	private void Set(float input, bool sendCallback = true)
	{
	}

	protected override void OnRectTransformDimensionsChange()
	{
	}

	private void UpdateVisuals()
	{
	}

	private void UpdateDrag(PointerEventData eventData)
	{
	}

	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
	{
	}

	private bool MayDrag(PointerEventData eventData)
	{
		return false;
	}

	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	protected IEnumerator ClickRepeat(PointerEventData eventData)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CClickRepeat_003Ed__58))]
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
	{
		return null;
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	public override void OnMove(AxisEventData eventData)
	{
	}

	public override Selectable FindSelectableOnLeft()
	{
		return null;
	}

	public override Selectable FindSelectableOnRight()
	{
		return null;
	}

	public override Selectable FindSelectableOnUp()
	{
		return null;
	}

	public override Selectable FindSelectableOnDown()
	{
		return null;
	}

	public virtual void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	public void SetDirection(Direction direction, bool includeRectLayouts)
	{
	}
}
