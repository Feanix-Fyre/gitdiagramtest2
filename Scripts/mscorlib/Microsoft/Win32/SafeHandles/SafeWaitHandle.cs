using System;
using System.Runtime.ConstrainedExecution;

namespace Microsoft.Win32.SafeHandles;

/// <summary>Represents a wrapper class for a wait handle.</summary>
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	/// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" /> class.</summary>
	/// <param name="existingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param>
	/// <param name="ownsHandle">
	///   <see langword="true" /> to reliably release the handle during the finalization phase; <see langword="false" /> to prevent reliable release (not recommended).</param>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle)
		: base(ownsHandle: false)
	{
	}

	protected override bool ReleaseHandle()
	{
		return false;
	}
}
