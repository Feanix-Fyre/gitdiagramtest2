using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.InputSystem;

public struct InputBindingCompositeContext
{
	public struct PartBinding
	{
		public int part { get; set; }

		public InputControl control { get; set; }
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct DefaultComparer<TValue> : IComparer<TValue> where TValue : IComparable<TValue>
	{
		public int Compare(TValue x, TValue y)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_controls_003Ed__2 : IEnumerable<PartBinding>, IEnumerable, IEnumerator<PartBinding>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private PartBinding _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public InputBindingCompositeContext _003C_003E4__this;

		public InputBindingCompositeContext _003C_003E3___003C_003E4__this;

		private int _003CtotalBindingCount_003E5__2;

		private int _003CbindingIndex_003E5__3;

		private InputActionState.BindingState _003CbindingState_003E5__4;

		private int _003CcontrolStartIndex_003E5__5;

		private int _003Ci_003E5__6;

		PartBinding IEnumerator<PartBinding>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(PartBinding);
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
		public _003Cget_controls_003Ed__2(int _003C_003E1__state)
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
		IEnumerator<PartBinding> IEnumerable<PartBinding>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	internal InputActionState m_State;

	internal int m_BindingIndex;

	public IEnumerable<PartBinding> controls
	{
		[IteratorStateMachine(typeof(_003Cget_controls_003Ed__2))]
		get
		{
			return null;
		}
	}

	public float EvaluateMagnitude(int partNumber)
	{
		return 0f;
	}

	public TValue ReadValue<TValue>(int partNumber) where TValue : struct, IComparable<TValue>
	{
		return default(TValue);
	}

	public TValue ReadValue<TValue>(int partNumber, out InputControl sourceControl) where TValue : struct, IComparable<TValue>
	{
		sourceControl = null;
		return default(TValue);
	}

	public TValue ReadValue<TValue, TComparer>(int partNumber, TComparer comparer = default(TComparer)) where TValue : struct where TComparer : IComparer<TValue>
	{
		return default(TValue);
	}

	public TValue ReadValue<TValue, TComparer>(int partNumber, out InputControl sourceControl, TComparer comparer = default(TComparer)) where TValue : struct where TComparer : IComparer<TValue>
	{
		sourceControl = null;
		return default(TValue);
	}

	public bool ReadValueAsButton(int partNumber)
	{
		return false;
	}

	public unsafe void ReadValue(int partNumber, void* buffer, int bufferSize)
	{
	}

	public object ReadValueAsObject(int partNumber)
	{
		return null;
	}

	public double GetPressTime(int partNumber)
	{
		return 0.0;
	}
}
