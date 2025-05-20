using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
public sealed class UploadHandlerRaw : UploadHandler
{
	private NativeArray<byte> m_Payload;

	private unsafe static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength)
	{
		return (IntPtr)0;
	}

	public UploadHandlerRaw(byte[] data)
	{
	}

	public UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership)
	{
	}

	public override void Dispose()
	{
	}
}
