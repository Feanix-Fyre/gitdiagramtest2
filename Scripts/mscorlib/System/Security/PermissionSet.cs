using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security;

/// <summary>Represents a collection that can contain many different types of permissions.</summary>
[Serializable]
[ComVisible(true)]
[MonoTODO("CAS support is experimental (and unsupported).")]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback
{
	private static object[] psUnrestricted;

	private PermissionState state;

	private ArrayList list;

	private bool _declsec;

	private bool[] _ignored;

	private static object[] action;

	/// <summary>Gets the number of permission objects contained in the permission set.</summary>
	/// <returns>The number of permission objects contained in the <see cref="T:System.Security.PermissionSet" />.</returns>
	public virtual int Count => 0;

	/// <summary>Gets a value indicating whether the collection is guaranteed to be thread safe.</summary>
	/// <returns>Always <see langword="false" />.</returns>
	public virtual bool IsSynchronized => false;

	/// <summary>Gets the root object of the current collection.</summary>
	/// <returns>The root object of the current collection.</returns>
	public virtual object SyncRoot => null;

	internal PermissionSet()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.PermissionSet" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
	/// <param name="state">One of the enumeration values that specifies the permission set's access to resources.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
	public PermissionSet(PermissionState state)
	{
	}

	internal PermissionSet(IPermission perm)
	{
	}

	/// <summary>Copies the permission objects of the set to the indicated location in an <see cref="T:System.Array" />.</summary>
	/// <param name="array">The target array to which to copy.</param>
	/// <param name="index">The starting position in the array to begin copying (zero based).</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="array" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="array" /> parameter has more than one dimension.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">The <paramref name="index" /> parameter is out of the range of the <paramref name="array" /> parameter.</exception>
	public virtual void CopyTo(Array array, int index)
	{
	}

	/// <summary>Forces a <see cref="T:System.Security.SecurityException" /> at run time if all callers higher in the call stack have not been granted the permissions specified by the current instance.</summary>
	/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have the permission demanded.</exception>
	public void Demand()
	{
	}

	internal void CasOnlyDemand(int skip)
	{
	}

	/// <summary>Returns an enumerator for the permissions of the set.</summary>
	/// <returns>An enumerator object for the permissions of the set.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Gets a value indicating whether the <see cref="T:System.Security.PermissionSet" /> is empty.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Security.PermissionSet" /> is empty; otherwise, <see langword="false" />.</returns>
	public bool IsEmpty()
	{
		return false;
	}

	/// <summary>Determines whether the <see cref="T:System.Security.PermissionSet" /> is <see langword="Unrestricted" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Security.PermissionSet" /> is <see langword="Unrestricted" />; otherwise, <see langword="false" />.</returns>
	public bool IsUnrestricted()
	{
		return false;
	}

	/// <summary>Returns a string representation of the <see cref="T:System.Security.PermissionSet" />.</summary>
	/// <returns>A representation of the <see cref="T:System.Security.PermissionSet" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Creates an XML encoding of the security object and its current state.</summary>
	/// <returns>An XML encoding of the security object, including any state information.</returns>
	public virtual SecurityElement ToXml()
	{
		return null;
	}

	/// <summary>Runs when the entire object graph has been deserialized.</summary>
	/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
	[MonoTODO("may not be required")]
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	/// <summary>Determines whether the specified <see cref="T:System.Security.PermissionSet" /> or <see cref="T:System.Security.NamedPermissionSet" /> object is equal to the current <see cref="T:System.Security.PermissionSet" />.</summary>
	/// <param name="obj">The object to compare with the current <see cref="T:System.Security.PermissionSet" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified object is equal to the current <see cref="T:System.Security.PermissionSet" /> object; otherwise, <see langword="false" />.</returns>
	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Gets a hash code for the <see cref="T:System.Security.PermissionSet" /> object that is suitable for use in hashing algorithms and data structures such as a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Security.PermissionSet" /> object.</returns>
	[ComVisible(false)]
	public override int GetHashCode()
	{
		return 0;
	}
}
