using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath;

internal class ArraySliceFilter : PathFilter
{
	[CompilerGenerated]
	private sealed class _003CExecuteFilter_003Ed__12 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private JToken _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ArraySliceFilter _003C_003E4__this;

		private IEnumerable<JToken> current;

		public IEnumerable<JToken> _003C_003E3__current;

		private JsonSelectSettings settings;

		public JsonSelectSettings _003C_003E3__settings;

		private IEnumerator<JToken> _003C_003E7__wrap1;

		private JArray _003Ca_003E5__3;

		private int _003CstepCount_003E5__4;

		private int _003CstopIndex_003E5__5;

		private bool _003CpositiveStep_003E5__6;

		private int _003Ci_003E5__7;

		JToken IEnumerator<JToken>.Current
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
		public _003CExecuteFilter_003Ed__12(int _003C_003E1__state)
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
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public int? Start { get; set; }

	public int? End { get; set; }

	public int? Step { get; set; }

	[IteratorStateMachine(typeof(_003CExecuteFilter_003Ed__12))]
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings? settings)
	{
		return null;
	}

	private bool IsValid(int index, int stopIndex, bool positiveStep)
	{
		return false;
	}
}
