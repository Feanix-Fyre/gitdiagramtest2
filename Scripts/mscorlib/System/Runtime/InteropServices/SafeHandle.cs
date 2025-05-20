using System.Runtime.ConstrainedExecution;

namespace System.Runtime.InteropServices;

/// <summary>Represents a wrapper class for operating system handles. This class must be inherited.</summary>
[StructLayout((LayoutKind)0)]
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	/// <summary>Specifies the handle to be wrapped.</summary>
	protected IntPtr handle;

	private int _state;

	private bool _ownsHandle;

	private bool _fullyInitialized;

	private const int RefCount_Mask = 2147483644;

	private const int RefCount_One = 4;

	/// <summary>Gets a value indicating whether the handle is closed.</summary>
	/// <returns>
	///   <see langword="true" /> if the handle is closed; otherwise, <see langword="false" />.</returns>
	public bool IsClosed
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return false;
		}
	}

	/// <summary>When overridden in a derived class, gets a value indicating whether the handle value is invalid.</summary>
	/// <returns>
	///   <see langword="true" /> if the handle value is invalid; otherwise, <see langword="false" />.</returns>
	public abstract bool IsInvalid
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.SafeHandle" /> class with the specified invalid handle value.</summary>
	/// <param name="invalidHandleValue">The value of an invalid handle (usually 0 or -1).  Your implementation of <see cref="P:System.Runtime.InteropServices.SafeHandle.IsInvalid" /> should return <see langword="true" /> for this value.</param>
	/// <param name="ownsHandle">
	///   <see langword="true" /> to reliably let <see cref="T:System.Runtime.InteropServices.SafeHandle" /> release the handle during the finalization phase; otherwise, <see langword="false" /> (not recommended).</param>
	/// <exception cref="T:System.TypeLoadException">The derived class resides in an assembly without unmanaged code access permission.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle)
	{
	}

	/// <summary>Frees all resources associated with the handle.</summary>
	~SafeHandle()
	{
	}

	/// <summary>Sets the handle to the specified pre-existing handle.</summary>
	/// <param name="handle">The pre-existing handle to use.</param>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected void SetHandle(IntPtr handle)
	{
	}

	/// <summary>Returns the value of the <see cref="F:System.Runtime.InteropServices.SafeHandle.handle" /> field.</summary>
	/// <returns>An <see langword="IntPtr" /> representing the value of the <see cref="F:System.Runtime.InteropServices.SafeHandle.handle" /> field. If the handle has been marked invalid with <see cref="M:System.Runtime.InteropServices.SafeHandle.SetHandleAsInvalid" />, this method still returns the original handle value, which can be a stale value.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public IntPtr DangerousGetHandle()
	{
		return (IntPtr)0;
	}

	/// <summary>Marks the handle for releasing and freeing resources.</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Close()
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Runtime.InteropServices.SafeHandle" /> class.</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Runtime.InteropServices.SafeHandle" /> class specifying whether to perform a normal dispose operation.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> for a normal dispose operation; <see langword="false" /> to finalize the handle.</param>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected virtual void Dispose(bool disposing)
	{
	}

	/// <summary>When overridden in a derived class, executes the code required to free the handle.</summary>
	/// <returns>
	///   <see langword="true" /> if the handle is released successfully; otherwise, in the event of a catastrophic failure, <see langword="false" />. In this case, it generates a releaseHandleFailed Managed Debugging Assistant.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected abstract bool ReleaseHandle();

	/// <summary>Marks a handle as no longer used.</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void SetHandleAsInvalid()
	{
	}

	/// <summary>Manually increments the reference counter on <see cref="T:System.Runtime.InteropServices.SafeHandle" /> instances.</summary>
	/// <param name="success">
	///   <see langword="true" /> if the reference counter was successfully incremented; otherwise, <see langword="false" />.</param>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public void DangerousAddRef(ref bool success)
	{
	}

	/// <summary>Manually decrements the reference counter on a <see cref="T:System.Runtime.InteropServices.SafeHandle" /> instance.</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void DangerousRelease()
	{
	}

	private void InternalDispose()
	{
	}

	private void InternalFinalize()
	{
	}

	private void DangerousReleaseInternal(bool dispose)
	{
	}
}
