using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Interpreter;

internal sealed class InterpretedFrame
{
	[CompilerGenerated]
	private sealed class _003CGetStackTraceDebugInfo_003Ed__29 : IEnumerable<InterpretedFrameInfo>, IEnumerable, IEnumerator<InterpretedFrameInfo>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private InterpretedFrameInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public InterpretedFrame _003C_003E4__this;

		private InterpretedFrame _003Cframe_003E5__2;

		InterpretedFrameInfo IEnumerator<InterpretedFrameInfo>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(InterpretedFrameInfo);
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
		public _003CGetStackTraceDebugInfo_003Ed__29(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<InterpretedFrameInfo> IEnumerable<InterpretedFrameInfo>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[ThreadStatic]
	private static InterpretedFrame s_currentFrame;

	internal readonly Interpreter Interpreter;

	internal InterpretedFrame _parent;

	private readonly int[] _continuations;

	private int _continuationIndex;

	private int _pendingContinuation;

	private object _pendingValue;

	public readonly object[] Data;

	public readonly IStrongBox[] Closure;

	public int StackIndex;

	public int InstructionIndex;

	public string Name => null;

	public InterpretedFrame Parent => null;

	internal InterpretedFrame(Interpreter interpreter, IStrongBox[] closure)
	{
	}

	public DebugInfo GetDebugInfo(int instructionIndex)
	{
		return null;
	}

	public void Push(object value)
	{
	}

	public void Push(bool value)
	{
	}

	public void Push(int value)
	{
	}

	public void Push(byte value)
	{
	}

	public void Push(sbyte value)
	{
	}

	public void Push(short value)
	{
	}

	public void Push(ushort value)
	{
	}

	public object Pop()
	{
		return null;
	}

	internal void SetStackDepth(int depth)
	{
	}

	public object Peek()
	{
		return null;
	}

	public void Dup()
	{
	}

	[IteratorStateMachine(typeof(_003CGetStackTraceDebugInfo_003Ed__29))]
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo()
	{
		return null;
	}

	internal void SaveTraceToException(Exception exception)
	{
	}

	internal InterpretedFrame Enter()
	{
		return null;
	}

	internal void Leave(InterpretedFrame prevFrame)
	{
	}

	internal bool IsJumpHappened()
	{
		return false;
	}

	public void RemoveContinuation()
	{
	}

	public void PushContinuation(int continuation)
	{
	}

	public int YieldToCurrentContinuation()
	{
		return 0;
	}

	public int YieldToPendingContinuation()
	{
		return 0;
	}

	internal void PushPendingContinuation()
	{
	}

	internal void PopPendingContinuation()
	{
	}

	public int Goto(int labelIndex, object value, bool gotoExceptionHandler)
	{
		return 0;
	}
}
