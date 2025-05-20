using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles;

/// <summary>Provides a base class for Win32 safe handle implementations in which the value of -1 indicates an invalid handle.</summary>
public abstract class SafeHandleMinusOneIsInvalid : SafeHandle
{
	/// <summary>Gets a value that indicates whether the handle is invalid.</summary>
	/// <returns>
	///   <see langword="true" /> if the handle is not valid; otherwise, <see langword="false" />.</returns>
	public override bool IsInvalid => false;

	/// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid" /> class, specifying whether the handle is to be reliably released.</summary>
	/// <param name="ownsHandle">
	///   <see langword="true" /> to reliably release the handle during the finalization phase; <see langword="false" /> to prevent reliable release (not recommended).</param>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected SafeHandleMinusOneIsInvalid(bool ownsHandle)
		: base((IntPtr)0, ownsHandle: false)
	{
	}
}
