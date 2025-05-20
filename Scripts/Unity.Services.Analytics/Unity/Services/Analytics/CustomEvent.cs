using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Services.Analytics;

public class CustomEvent : Event, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomEvent _003C_003E4__this;

		private Dictionary<string, string>.Enumerator _003C_003E7__wrap1;

		private Dictionary<string, long>.Enumerator _003C_003E7__wrap2;

		private Dictionary<string, double>.Enumerator _003C_003E7__wrap3;

		private Dictionary<string, bool>.Enumerator _003C_003E7__wrap4;

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
		public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		private void _003C_003Em__Finally3()
		{
		}

		private void _003C_003Em__Finally4()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public string this[string key]
	{
		set
		{
		}
	}

	public CustomEvent(string name)
		: base(null)
	{
	}

	public void Add(string key, object value)
	{
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__4))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
