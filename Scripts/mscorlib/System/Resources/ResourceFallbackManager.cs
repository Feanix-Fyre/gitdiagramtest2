using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Resources;

internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__5 : IEnumerator<CultureInfo>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private CultureInfo _003C_003E2__current;

		public ResourceFallbackManager _003C_003E4__this;

		private bool _003CreachedNeutralResourcesCulture_003E5__2;

		private CultureInfo _003CcurrentCulture_003E5__3;

		CultureInfo IEnumerator<CultureInfo>.Current
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
		public _003CGetEnumerator_003Ed__5(int _003C_003E1__state)
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

	private CultureInfo m_startingCulture;

	private CultureInfo m_neutralResourcesCulture;

	private bool m_useParents;

	internal ResourceFallbackManager(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__5))]
	public IEnumerator<CultureInfo> GetEnumerator()
	{
		return null;
	}
}
