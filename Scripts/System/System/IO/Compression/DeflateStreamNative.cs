using System.Runtime.InteropServices;
using Mono.Util;

namespace System.IO.Compression;

internal class DeflateStreamNative
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate int UnmanagedReadOrWrite(IntPtr buffer, int length, IntPtr data);

	private sealed class SafeDeflateStreamHandle : SafeHandle
	{
		public override bool IsInvalid => false;

		private SafeDeflateStreamHandle()
			: base((IntPtr)0, ownsHandle: false)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}

	private UnmanagedReadOrWrite feeder;

	private Stream base_stream;

	private SafeDeflateStreamHandle z_stream;

	private GCHandle data;

	private bool disposed;

	private byte[] io_buffer;

	private Exception last_error;

	private DeflateStreamNative()
	{
	}

	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
	{
		return null;
	}

	~DeflateStreamNative()
	{
	}

	public void Dispose(bool disposing)
	{
	}

	public void Flush()
	{
	}

	public int ReadZStream(IntPtr buffer, int length)
	{
		return 0;
	}

	public void WriteZStream(IntPtr buffer, int length)
	{
	}

	[MonoPInvokeCallback(typeof(UnmanagedReadOrWrite))]
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
	{
		return 0;
	}

	private int UnmanagedRead(IntPtr buffer, int length)
	{
		return 0;
	}

	[MonoPInvokeCallback(typeof(UnmanagedReadOrWrite))]
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
	{
		return 0;
	}

	private int UnmanagedWrite(IntPtr buffer, int length)
	{
		return 0;
	}

	private void CheckResult(int result, string where)
	{
	}

	[PreserveSig]
	private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data);

	[PreserveSig]
	private static extern int CloseZStream(IntPtr stream);

	[PreserveSig]
	private static extern int Flush(SafeDeflateStreamHandle stream);

	[PreserveSig]
	private static extern int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length);

	[PreserveSig]
	private static extern int WriteZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length);
}
