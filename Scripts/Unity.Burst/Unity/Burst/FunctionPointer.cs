using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Burst;

public readonly struct FunctionPointer<T> : IFunctionPointer
{
	[NativeDisableUnsafePtrRestriction]
	private readonly IntPtr _ptr;

	public IntPtr Value => (IntPtr)0;

	public T Invoke => default(T);

	public bool IsCreated => false;

	public FunctionPointer(IntPtr ptr)
	{
		_ptr = (IntPtr)0;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckIsCreated()
	{
	}

	IFunctionPointer IFunctionPointer.FromIntPtr(IntPtr ptr)
	{
		return null;
	}
}
