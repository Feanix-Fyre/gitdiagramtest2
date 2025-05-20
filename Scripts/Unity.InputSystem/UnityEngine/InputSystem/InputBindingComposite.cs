using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public abstract class InputBindingComposite
{
	[CompilerGenerated]
	private sealed class _003CGetPartNames_003Ed__12 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string composite;

		public string _003C_003E3__composite;

		private FieldInfo[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		string IEnumerator<string>.Current
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
		public _003CGetPartNames_003Ed__12(int _003C_003E1__state)
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
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	internal static TypeTable s_Composites;

	public abstract Type valueType { get; }

	public abstract int valueSizeInBytes { get; }

	public unsafe abstract void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);

	public abstract object ReadValueAsObject(ref InputBindingCompositeContext context);

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context)
	{
		return 0f;
	}

	protected virtual void FinishSetup(ref InputBindingCompositeContext context)
	{
	}

	internal void CallFinishSetup(ref InputBindingCompositeContext context)
	{
	}

	internal static Type GetValueType(string composite)
	{
		return null;
	}

	public static string GetExpectedControlLayoutName(string composite, string part)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetPartNames_003Ed__12))]
	internal static IEnumerable<string> GetPartNames(string composite)
	{
		return null;
	}

	internal static string GetDisplayFormatString(string composite)
	{
		return null;
	}
}
public abstract class InputBindingComposite<TValue> : InputBindingComposite where TValue : struct
{
	public override Type valueType => null;

	public override int valueSizeInBytes => 0;

	public abstract TValue ReadValue(ref InputBindingCompositeContext context);

	public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
	{
	}

	public override object ReadValueAsObject(ref InputBindingCompositeContext context)
	{
		return null;
	}
}
