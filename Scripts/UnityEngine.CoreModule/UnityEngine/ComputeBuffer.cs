using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[NativeClass("GraphicsBuffer")]
[UsedByNativeCode]
public sealed class ComputeBuffer : IDisposable
{
	internal IntPtr m_Ptr;

	public int count => 0;

	public int stride => 0;

	public string name
	{
		set
		{
		}
	}

	~ComputeBuffer()
	{
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
	{
		return (IntPtr)0;
	}

	[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
	private static void DestroyBuffer(ComputeBuffer buf)
	{
	}

	public ComputeBuffer(int count, int stride)
	{
	}

	public ComputeBuffer(int count, int stride, ComputeBufferType type)
	{
	}

	private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth)
	{
	}

	public void Release()
	{
	}

	public void SetData(Array data)
	{
	}

	public void SetData<T>(NativeArray<T> data) where T : struct
	{
	}

	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
	{
	}

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = true, ThrowsException = true)]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
	}

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = true, ThrowsException = true)]
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
	{
	}

	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = true)]
	private void SetName(string name)
	{
	}
}
