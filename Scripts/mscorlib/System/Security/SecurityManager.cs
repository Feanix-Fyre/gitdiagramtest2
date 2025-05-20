using System.Runtime.InteropServices;

namespace System.Security;

/// <summary>Provides the main access point for classes interacting with the security system. This class cannot be inherited.</summary>
[ComVisible(true)]
public static class SecurityManager
{
	/// <summary>Gets or sets a value indicating whether security is enabled.</summary>
	/// <returns>
	///   <see langword="true" /> if security is enabled; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Security.SecurityException">The code that calls this method does not have <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlPolicy" />.</exception>
	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled => false;

	internal static void EnsureElevatedPermissions()
	{
	}
}
