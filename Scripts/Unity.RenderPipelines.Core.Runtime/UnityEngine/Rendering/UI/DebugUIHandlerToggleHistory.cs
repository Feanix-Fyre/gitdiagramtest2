using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
{
	[CompilerGenerated]
	private sealed class _003CRefreshAfterSanitization_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DebugUIHandlerToggleHistory _003C_003E4__this;

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
		public _003CRefreshAfterSanitization_003Ed__4(int _003C_003E1__state)
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

	private Toggle[] historyToggles;

	private const float k_XOffset = 230f;

	internal override void SetWidget(DebugUI.Widget widget)
	{
	}

	protected internal override void UpdateValueLabel()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshAfterSanitization_003Ed__4))]
	private IEnumerator RefreshAfterSanitization()
	{
		return null;
	}
}
