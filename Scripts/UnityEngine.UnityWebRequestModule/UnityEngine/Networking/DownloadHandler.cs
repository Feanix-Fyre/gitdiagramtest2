using System;
using System.Runtime.InteropServices;
using System.Text;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable
{
	[NonSerialized]
	[VisibleToOtherModules]
	internal IntPtr m_Ptr;

	public byte[] data => null;

	public string text => null;

	[NativeMethod(IsThreadSafe = true)]
	private void Release()
	{
	}

	[VisibleToOtherModules]
	internal DownloadHandler()
	{
	}

	~DownloadHandler()
	{
	}

	public virtual void Dispose()
	{
	}

	protected virtual NativeArray<byte> GetNativeData()
	{
		return default(NativeArray<byte>);
	}

	protected virtual byte[] GetData()
	{
		return null;
	}

	protected virtual string GetText()
	{
		return null;
	}

	private Encoding GetTextEncoder()
	{
		return null;
	}

	private string GetContentType()
	{
		return null;
	}

	[RequiredByNativeCode]
	protected virtual bool ReceiveData(byte[] data, int dataLength)
	{
		return false;
	}

	[RequiredByNativeCode]
	protected virtual void ReceiveContentLengthHeader(ulong contentLength)
	{
	}

	[Obsolete("Use ReceiveContentLengthHeader")]
	protected virtual void ReceiveContentLength(int contentLength)
	{
	}

	[RequiredByNativeCode]
	protected virtual void CompleteContent()
	{
	}

	[RequiredByNativeCode]
	protected virtual float GetProgress()
	{
		return 0f;
	}

	[VisibleToOtherModules]
	[NativeThrows]
	internal unsafe static byte* InternalGetByteArray(DownloadHandler dh, out int length)
	{
		length = default(int);
		return null;
	}

	internal static byte[] InternalGetByteArray(DownloadHandler dh)
	{
		return null;
	}

	internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray)
	{
		return default(NativeArray<byte>);
	}

	internal static void DisposeNativeArray(ref NativeArray<byte> data)
	{
	}

	internal unsafe static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length)
	{
	}
}
