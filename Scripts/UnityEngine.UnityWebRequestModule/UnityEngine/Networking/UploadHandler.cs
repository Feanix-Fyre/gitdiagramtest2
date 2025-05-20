using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable
{
	[NonSerialized]
	internal IntPtr m_Ptr;

	public string contentType
	{
		set
		{
		}
	}

	[NativeMethod(IsThreadSafe = true)]
	private void Release()
	{
	}

	internal UploadHandler()
	{
	}

	~UploadHandler()
	{
	}

	public virtual void Dispose()
	{
	}

	internal virtual void SetContentType(string newContentType)
	{
	}

	[NativeMethod("SetContentType")]
	private void InternalSetContentType(string newContentType)
	{
	}
}
