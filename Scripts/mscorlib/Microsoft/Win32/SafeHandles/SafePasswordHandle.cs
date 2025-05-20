using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles;

internal sealed class SafePasswordHandle : SafeHandle
{
	public override bool IsInvalid => false;

	private IntPtr CreateHandle(string password)
	{
		return (IntPtr)0;
	}

	private void FreeHandle()
	{
	}

	public SafePasswordHandle(string password)
		: base((IntPtr)0, ownsHandle: false)
	{
	}

	protected override bool ReleaseHandle()
	{
		return false;
	}

	protected override void Dispose(bool disposing)
	{
	}

	internal string Mono_DangerousGetString()
	{
		return null;
	}
}
