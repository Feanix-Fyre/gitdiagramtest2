using System;
using UnityEngine.Bindings;

namespace UnityEngine.Jobs;

[NativeType(Header = "Runtime/Transform/ScriptBindings/TransformAccess.bindings.h", CodegenOptions = CodegenOptions.Custom)]
public struct TransformAccessArray : IDisposable
{
	private IntPtr m_TransformArray;

	public bool isCreated => false;

	public Transform this[int index] => null;

	public int length => 0;

	public TransformAccessArray(int capacity, int desiredJobCount = -1)
	{
		m_TransformArray = (IntPtr)0;
	}

	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array)
	{
		array = default(TransformAccessArray);
	}

	public void Dispose()
	{
	}

	internal IntPtr GetTransformAccessArrayForSchedule()
	{
		return (IntPtr)0;
	}

	public void Add(Transform transform)
	{
	}

	public void RemoveAtSwapBack(int index)
	{
	}

	[NativeMethod(Name = "TransformAccessArrayBindings::Create", IsFreeFunction = true)]
	private static IntPtr Create(int capacity, int desiredJobCount)
	{
		return (IntPtr)0;
	}

	[NativeMethod(Name = "DestroyTransformAccessArray", IsFreeFunction = true)]
	private static void DestroyTransformAccessArray(IntPtr transformArray)
	{
	}

	[NativeMethod(Name = "TransformAccessArrayBindings::AddTransform", IsFreeFunction = true)]
	private static void Add(IntPtr transformArrayIntPtr, Transform transform)
	{
	}

	[NativeMethod(Name = "TransformAccessArrayBindings::RemoveAtSwapBack", IsFreeFunction = true, ThrowsException = true)]
	private static void RemoveAtSwapBack(IntPtr transformArrayIntPtr, int index)
	{
	}

	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedTransformAccess", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr)
	{
		return (IntPtr)0;
	}

	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedToUserIndex", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr)
	{
		return (IntPtr)0;
	}

	[NativeMethod(Name = "TransformAccessArrayBindings::GetLength", IsFreeFunction = true)]
	internal static int GetLength(IntPtr transformArrayIntPtr)
	{
		return 0;
	}

	[NativeMethod(Name = "TransformAccessArrayBindings::GetTransform", IsFreeFunction = true, ThrowsException = true)]
	internal static Transform GetTransform(IntPtr transformArrayIntPtr, int index)
	{
		return null;
	}
}
