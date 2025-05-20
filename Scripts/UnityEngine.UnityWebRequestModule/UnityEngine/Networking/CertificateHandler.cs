using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler
{
	[NonSerialized]
	internal IntPtr m_Ptr;

	[NativeMethod(IsThreadSafe = true)]
	private void Release()
	{
	}

	protected virtual bool ValidateCertificate(byte[] certificateData)
	{
		return false;
	}

	[RequiredByNativeCode]
	internal bool ValidateCertificateNative(byte[] certificateData)
	{
		return false;
	}

	public void Dispose()
	{
	}
}
