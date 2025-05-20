using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices;

/// <summary>Provides a controlled memory buffer that can be used for reading and writing. Attempts to access memory outside the controlled buffer (underruns and overruns) raise exceptions.</summary>
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	private static readonly UIntPtr Uninitialized;

	private UIntPtr _numBytes;

	/// <summary>Obtains a pointer from a <see cref="T:System.Runtime.InteropServices.SafeBuffer" /> object for a block of memory.</summary>
	/// <param name="pointer">A byte pointer, passed by reference, to receive the pointer from within the <see cref="T:System.Runtime.InteropServices.SafeBuffer" /> object. You must set this pointer to <see langword="null" /> before you call this method.</param>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> method has not been called.</exception>
	[CLSCompliant(false)]
	public unsafe void AcquirePointer(ref byte* pointer)
	{
	}

	/// <summary>Releases a pointer that was obtained by the <see cref="M:System.Runtime.InteropServices.SafeBuffer.AcquirePointer(System.Byte*@)" /> method.</summary>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="Overload:System.Runtime.InteropServices.SafeBuffer.Initialize" /> method has not been called.</exception>
	public void ReleasePointer()
	{
	}

	private static InvalidOperationException NotInitialized()
	{
		return null;
	}
}
