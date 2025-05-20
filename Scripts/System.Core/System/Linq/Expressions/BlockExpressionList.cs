using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__18 : IEnumerator<Expression>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private Expression _003C_003E2__current;

		public BlockExpressionList _003C_003E4__this;

		private int _003Ci_003E5__2;

		Expression IEnumerator<Expression>.Current
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
		public _003CGetEnumerator_003Ed__18(int _003C_003E1__state)
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

	private readonly BlockExpression _block;

	private readonly Expression _arg0;

	public Expression this[int index]
	{
		get
		{
			return null;
		}
		[ExcludeFromCodeCoverage]
		set
		{
		}
	}

	public int Count => 0;

	[ExcludeFromCodeCoverage]
	public bool IsReadOnly => false;

	internal BlockExpressionList(BlockExpression provider, Expression arg0)
	{
	}

	public int IndexOf(Expression item)
	{
		return 0;
	}

	[ExcludeFromCodeCoverage]
	public void Insert(int index, Expression item)
	{
	}

	[ExcludeFromCodeCoverage]
	public void RemoveAt(int index)
	{
	}

	[ExcludeFromCodeCoverage]
	public void Add(Expression item)
	{
	}

	[ExcludeFromCodeCoverage]
	public void Clear()
	{
	}

	public bool Contains(Expression item)
	{
		return false;
	}

	public void CopyTo(Expression[] array, int index)
	{
	}

	[ExcludeFromCodeCoverage]
	public bool Remove(Expression item)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__18))]
	public IEnumerator<Expression> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
