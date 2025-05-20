using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace System.Drawing;

internal sealed class ComIStreamMarshaler : ICustomMarshaler
{
	private delegate int QueryInterfaceDelegate(IntPtr @this, [In] ref Guid riid, IntPtr ppvObject);

	private delegate int AddRefDelegate(IntPtr @this);

	private delegate int ReleaseDelegate(IntPtr @this);

	private delegate int ReadDelegate(IntPtr @this, [Out] byte[] pv, int cb, IntPtr pcbRead);

	private delegate int WriteDelegate(IntPtr @this, byte[] pv, int cb, IntPtr pcbWritten);

	private delegate int SeekDelegate(IntPtr @this, long dlibMove, int dwOrigin, IntPtr plibNewPosition);

	private delegate int SetSizeDelegate(IntPtr @this, long libNewSize);

	private delegate int CopyToDelegate(IntPtr @this, IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);

	private delegate int CommitDelegate(IntPtr @this, int grfCommitFlags);

	private delegate int RevertDelegate(IntPtr @this);

	private delegate int LockRegionDelegate(IntPtr @this, long libOffset, long cb, int dwLockType);

	private delegate int UnlockRegionDelegate(IntPtr @this, long libOffset, long cb, int dwLockType);

	private delegate int StatDelegate(IntPtr @this, out STATSTG pstatstg, int grfStatFlag);

	private delegate int CloneDelegate(IntPtr @this, out IntPtr ppstm);

	[StructLayout((LayoutKind)0)]
	private sealed class IStreamInterface
	{
		internal IntPtr lpVtbl;

		internal IntPtr gcHandle;
	}

	[StructLayout((LayoutKind)0)]
	private sealed class IStreamVtbl
	{
		internal QueryInterfaceDelegate QueryInterface;

		internal AddRefDelegate AddRef;

		internal ReleaseDelegate Release;

		internal ReadDelegate Read;

		internal WriteDelegate Write;

		internal SeekDelegate Seek;

		internal SetSizeDelegate SetSize;

		internal CopyToDelegate CopyTo;

		internal CommitDelegate Commit;

		internal RevertDelegate Revert;

		internal LockRegionDelegate LockRegion;

		internal UnlockRegionDelegate UnlockRegion;

		internal StatDelegate Stat;

		internal CloneDelegate Clone;
	}

	private sealed class ManagedToNativeWrapper
	{
		[StructLayout((LayoutKind)0)]
		private sealed class ReleaseSlot
		{
			internal ReleaseDelegate Release;
		}

		private static readonly Guid IID_IUnknown;

		private static readonly Guid IID_IStream;

		private static readonly MethodInfo exceptionGetHResult;

		private static readonly IStreamVtbl managedVtable;

		private static IntPtr comVtable;

		private static int vtableRefCount;

		private IStream managedInterface;

		private IntPtr comInterface;

		private GCHandle gcHandle;

		private int refCount;

		static ManagedToNativeWrapper()
		{
		}

		private ManagedToNativeWrapper(IStream managedInterface)
		{
		}

		private void Dispose()
		{
		}

		private static void OnShutdown(object sender, EventArgs e)
		{
		}

		private static void CreateVtable()
		{
		}

		private static void DisposeVtable()
		{
		}

		internal static IStream GetUnderlyingInterface(IntPtr comInterface, bool outParam)
		{
			return null;
		}

		internal static IntPtr GetInterface(IStream managedInterface)
		{
			return (IntPtr)0;
		}

		internal static void ReleaseInterface(IntPtr comInterface)
		{
		}

		private static int GetHRForException(Exception e)
		{
			return 0;
		}

		private static ManagedToNativeWrapper GetObject(IntPtr @this)
		{
			return null;
		}

		private static int QueryInterface(IntPtr @this, ref Guid riid, IntPtr ppvObject)
		{
			return 0;
		}

		private static int AddRef(IntPtr @this)
		{
			return 0;
		}

		private static int Release(IntPtr @this)
		{
			return 0;
		}

		private static int Read(IntPtr @this, byte[] pv, int cb, IntPtr pcbRead)
		{
			return 0;
		}

		private static int Write(IntPtr @this, byte[] pv, int cb, IntPtr pcbWritten)
		{
			return 0;
		}

		private static int Seek(IntPtr @this, long dlibMove, int dwOrigin, IntPtr plibNewPosition)
		{
			return 0;
		}

		private static int SetSize(IntPtr @this, long libNewSize)
		{
			return 0;
		}

		private static int CopyTo(IntPtr @this, IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
		{
			return 0;
		}

		private static int Commit(IntPtr @this, int grfCommitFlags)
		{
			return 0;
		}

		private static int Revert(IntPtr @this)
		{
			return 0;
		}

		private static int LockRegion(IntPtr @this, long libOffset, long cb, int dwLockType)
		{
			return 0;
		}

		private static int UnlockRegion(IntPtr @this, long libOffset, long cb, int dwLockType)
		{
			return 0;
		}

		private static int Stat(IntPtr @this, out STATSTG pstatstg, int grfStatFlag)
		{
			pstatstg = default(STATSTG);
			return 0;
		}

		private static int Clone(IntPtr @this, out IntPtr ppstm)
		{
			ppstm = default(IntPtr);
			return 0;
		}
	}

	private sealed class NativeToManagedWrapper : IStream
	{
		private IntPtr comInterface;

		private IStreamVtbl managedVtable;

		private NativeToManagedWrapper(IntPtr comInterface, bool outParam)
		{
		}

		~NativeToManagedWrapper()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		internal static IntPtr GetUnderlyingInterface(IStream managedInterface)
		{
			return (IntPtr)0;
		}

		internal static IStream GetInterface(IntPtr comInterface, bool outParam)
		{
			return null;
		}

		internal static void ReleaseInterface(IStream managedInterface)
		{
		}

		private static void ThrowExceptionForHR(int result)
		{
		}

		public void Read(byte[] pv, int cb, IntPtr pcbRead)
		{
		}

		public void Write(byte[] pv, int cb, IntPtr pcbWritten)
		{
		}

		public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
		{
		}

		public void SetSize(long libNewSize)
		{
		}

		public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
		{
		}

		public void Commit(int grfCommitFlags)
		{
		}

		public void Revert()
		{
		}

		public void LockRegion(long libOffset, long cb, int dwLockType)
		{
		}

		public void UnlockRegion(long libOffset, long cb, int dwLockType)
		{
		}

		public void Stat(out STATSTG pstatstg, int grfStatFlag)
		{
			pstatstg = default(STATSTG);
		}

		public void Clone(out IStream ppstm)
		{
			ppstm = null;
		}
	}

	private static readonly ComIStreamMarshaler defaultInstance;

	private ComIStreamMarshaler()
	{
	}

	private static ICustomMarshaler GetInstance(string cookie)
	{
		return null;
	}

	public IntPtr MarshalManagedToNative(object managedObj)
	{
		return (IntPtr)0;
	}

	public void CleanUpNativeData(IntPtr pNativeData)
	{
	}

	public object MarshalNativeToManaged(IntPtr pNativeData)
	{
		return null;
	}

	public void CleanUpManagedData(object managedObj)
	{
	}

	public int GetNativeDataSize()
	{
		return 0;
	}
}
