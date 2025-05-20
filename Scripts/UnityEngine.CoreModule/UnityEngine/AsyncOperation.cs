using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[RequiredByNativeCode]
public class AsyncOperation : YieldInstruction
{
	internal IntPtr m_Ptr;

	private Action<AsyncOperation> m_completeCallback;

	public bool isDone
	{
		[NativeMethod("IsDone")]
		get
		{
			return false;
		}
	}

	public float progress
	{
		[NativeMethod("GetProgress")]
		get
		{
			return 0f;
		}
	}

	public bool allowSceneActivation
	{
		[NativeMethod("SetAllowSceneActivation")]
		set
		{
		}
	}

	public event Action<AsyncOperation> completed
	{
		add
		{
		}
		remove
		{
		}
	}

	[NativeMethod(IsThreadSafe = true)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
	private static void InternalDestroy(IntPtr ptr)
	{
	}

	~AsyncOperation()
	{
	}

	[RequiredByNativeCode]
	internal void InvokeCompletionEvent()
	{
	}
}
