using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security;

/// <summary>Defines a permission set that has a name and description associated with it. This class cannot be inherited.</summary>
[Serializable]
[ComVisible(true)]
public sealed class NamedPermissionSet : PermissionSet
{
	private string name;

	private string description;

	/// <summary>Gets or sets the name of the current named permission set.</summary>
	/// <returns>The name of the named permission set.</returns>
	/// <exception cref="T:System.ArgumentException">The name is <see langword="null" /> or is an empty string ("").</exception>
	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal NamedPermissionSet()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.NamedPermissionSet" /> class with the specified name in either an unrestricted or a fully restricted state.</summary>
	/// <param name="name">The name for the new named permission set.</param>
	/// <param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is <see langword="null" /> or is an empty string ("").</exception>
	public NamedPermissionSet(string name, PermissionState state)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.Security.NamedPermissionSet" /> class with the specified name.</summary>
	/// <param name="name">The name for the new named permission set.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is <see langword="null" /> or is an empty string ("").</exception>
	public NamedPermissionSet(string name)
	{
	}

	/// <summary>Creates an XML element description of the named permission set.</summary>
	/// <returns>The XML representation of the named permission set.</returns>
	public override SecurityElement ToXml()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Security.NamedPermissionSet" /> object is equal to the current <see cref="T:System.Security.NamedPermissionSet" />.</summary>
	/// <param name="obj">The <see cref="T:System.Security.NamedPermissionSet" /> object to compare with the current <see cref="T:System.Security.NamedPermissionSet" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Security.NamedPermissionSet" /> is equal to the current <see cref="T:System.Security.NamedPermissionSet" /> object; otherwise, <see langword="false" />.</returns>
	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Gets a hash code for the <see cref="T:System.Security.NamedPermissionSet" /> object that is suitable for use in hashing algorithms and data structures such as a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Security.NamedPermissionSet" /> object.</returns>
	[ComVisible(false)]
	public override int GetHashCode()
	{
		return 0;
	}
}
