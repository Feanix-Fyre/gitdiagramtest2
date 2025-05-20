using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
public sealed class GraphicsBuffer : IDisposable
{
	[Flags]
	public enum Target
	{
		Vertex = 1,
		Index = 2,
		CopySource = 4,
		CopyDestination = 8,
		Structured = 0x10,
		Raw = 0x20,
		Append = 0x40,
		Counter = 0x80,
		IndirectArguments = 0x100,
		Constant = 0x200
	}

	[Flags]
	public enum UsageFlags
	{
		None = 0,
		LockBufferForWrite = 1
	}

	internal IntPtr m_Ptr;

	public string name
	{
		set
		{
		}
	}

	~GraphicsBuffer()
	{
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	private static bool RequiresCompute(Target target)
	{
		return false;
	}

	private static bool IsVertexIndexOrCopyOnly(Target target)
	{
		return false;
	}

	[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer(Target target, UsageFlags usageFlags, int count, int stride)
	{
		return (IntPtr)0;
	}

	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	private static void DestroyBuffer(GraphicsBuffer buf)
	{
	}

	public GraphicsBuffer(Target target, int count, int stride)
	{
	}

	private void InternalInitialization(Target target, UsageFlags usageFlags, int count, int stride)
	{
	}

	public void Release()
	{
	}

	public void SetData<T>(NativeArray<T> data) where T : struct
	{
	}

	public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
	{
	}

	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = true, ThrowsException = true)]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
	{
	}

	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = true)]
	private void SetName(string name)
	{
	}
}
