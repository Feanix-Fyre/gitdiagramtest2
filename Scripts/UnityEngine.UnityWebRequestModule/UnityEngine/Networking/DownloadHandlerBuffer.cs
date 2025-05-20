using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
public sealed class DownloadHandlerBuffer : DownloadHandler
{
	private NativeArray<byte> m_NativeData;

	private static IntPtr Create(DownloadHandlerBuffer obj)
	{
		return (IntPtr)0;
	}

	private void InternalCreateBuffer()
	{
	}

	protected override NativeArray<byte> GetNativeData()
	{
		return default(NativeArray<byte>);
	}

	public override void Dispose()
	{
	}
}
