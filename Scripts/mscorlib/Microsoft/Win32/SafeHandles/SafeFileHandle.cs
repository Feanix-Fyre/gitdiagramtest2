using System;

namespace Microsoft.Win32.SafeHandles;

/// <summary>Represents a wrapper class for a file handle.</summary>
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	/// <summary>Initializes a new instance of the <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> class.</summary>
	/// <param name="preexistingHandle">An <see cref="T:System.IntPtr" /> object that represents the pre-existing handle to use.</param>
	/// <param name="ownsHandle">
	///   <see langword="true" /> to reliably release the handle during the finalization phase; <see langword="false" /> to prevent reliable release (not recommended).</param>
	public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle: false)
	{
	}

	protected override bool ReleaseHandle()
	{
		return false;
	}
}
