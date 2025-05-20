using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.UI;

[AddComponentMenu("UI/Button", 30)]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
{
	[Serializable]
	public class ButtonClickedEvent : UnityEvent
	{
	}

	[CompilerGenerated]
	private sealed class _003COnFinishSubmit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Button _003C_003E4__this;

		private float _003CfadeTime_003E5__2;

		private float _003CelapsedTime_003E5__3;

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
		public _003COnFinishSubmit_003Ed__9(int _003C_003E1__state)
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
	[FormerlySerializedAs("onClick")]
	private ButtonClickedEvent m_OnClick;

	public ButtonClickedEvent onClick
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected Button()
	{
	}

	private void Press()
	{
	}

	public virtual void OnPointerClick(PointerEventData eventData)
	{
	}

	public virtual void OnSubmit(BaseEventData eventData)
	{
	}

	[IteratorStateMachine(typeof(_003COnFinishSubmit_003Ed__9))]
	private IEnumerator OnFinishSubmit()
	{
		return null;
	}
}
