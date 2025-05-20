namespace Microsoft.Win32.SafeHandles;

internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeFindHandle()
		: base(ownsHandle: false)
	{
	}

	protected override bool ReleaseHandle()
	{
		return false;
	}
}
