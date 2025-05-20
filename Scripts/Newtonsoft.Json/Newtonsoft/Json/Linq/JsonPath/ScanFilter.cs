using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class ScanFilter : PathFilter
{
	[CompilerGenerated]
	private sealed class _003CExecuteFilter_003Ed__2 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private JToken _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<JToken> current;

		public IEnumerable<JToken> _003C_003E3__current;

		public ScanFilter _003C_003E4__this;

		private IEnumerator<JToken> _003C_003E7__wrap1;

		private JToken _003Cc_003E5__3;

		private JToken _003Cvalue_003E5__4;

		JToken? IEnumerator<JToken>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object? IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CExecuteFilter_003Ed__2(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<JToken?>? IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	internal string? Name;

	public ScanFilter(string? name)
	{
	}

	[IteratorStateMachine(typeof(_003CExecuteFilter_003Ed__2))]
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings? settings)
	{
		return null;
	}
}
