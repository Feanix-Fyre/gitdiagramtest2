using System.Runtime.InteropServices;

namespace System.Security.Principal;

/// <summary>Represents the Windows user prior to an impersonation operation.</summary>
[ComVisible(true)]
public class WindowsImpersonationContext : IDisposable
{
	private IntPtr _token;

	private bool undo;

	internal WindowsImpersonationContext(IntPtr token)
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Security.Principal.WindowsImpersonationContext" />.</summary>
	[ComVisible(false)]
	public void Dispose()
	{
	}

	/// <summary>Reverts the user context to the Windows user represented by this object.</summary>
	/// <exception cref="T:System.Security.SecurityException">An attempt is made to use this method for any purpose other than to revert identity to self.</exception>
	public void Undo()
	{
	}

	private static bool CloseToken(IntPtr token)
	{
		return false;
	}

	private static IntPtr DuplicateToken(IntPtr token)
	{
		return (IntPtr)0;
	}

	private static bool SetCurrentToken(IntPtr token)
	{
		return false;
	}

	private static bool RevertToSelf()
	{
		return false;
	}
}
