using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security;

/// <summary>Defines the underlying structure of all code access permissions.</summary>
[Serializable]
[MonoTODO("CAS support is experimental (and unsupported).")]
[ComVisible(true)]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Security.CodeAccessPermission" /> class.</summary>
	protected CodeAccessPermission()
	{
	}

	/// <summary>Forces a <see cref="T:System.Security.SecurityException" /> at run time if all callers higher in the call stack have not been granted the permission specified by the current instance.</summary>
	/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have the permission specified by the current instance.  
	///  -or-  
	///  A caller higher in the call stack has called <see cref="M:System.Security.CodeAccessPermission.Deny" /> on the current permission object.</exception>
	[Conditional("MONO_FEATURE_CAS")]
	public void Demand()
	{
	}

	/// <summary>Determines whether the specified <see cref="T:System.Security.CodeAccessPermission" /> object is equal to the current <see cref="T:System.Security.CodeAccessPermission" />.</summary>
	/// <param name="obj">The <see cref="T:System.Security.CodeAccessPermission" /> object to compare with the current <see cref="T:System.Security.CodeAccessPermission" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Security.CodeAccessPermission" /> object is equal to the current <see cref="T:System.Security.CodeAccessPermission" />; otherwise, <see langword="false" />.</returns>
	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Gets a hash code for the <see cref="T:System.Security.CodeAccessPermission" /> object that is suitable for use in hashing algorithms and data structures such as a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Security.CodeAccessPermission" /> object.</returns>
	[ComVisible(false)]
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>When implemented by a derived class, determines whether the current permission is a subset of the specified permission.</summary>
	/// <param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission.</param>
	/// <returns>
	///   <see langword="true" /> if the current permission is a subset of the specified permission; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not <see langword="null" /> and is not of the same type as the current permission.</exception>
	public abstract bool IsSubsetOf(IPermission target);

	/// <summary>Creates and returns a string representation of the current permission object.</summary>
	/// <returns>A string representation of the current permission object.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, creates an XML encoding of the security object and its current state.</summary>
	/// <returns>An XML encoding of the security object, including any state information.</returns>
	public abstract SecurityElement ToXml();

	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted)
	{
		return default(PermissionState);
	}

	void IPermission.Demand()
	{
	}
}
