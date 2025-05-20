using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Net.NetworkInformation;

/// <summary>Stores a set of <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> types.</summary>
[DefaultMember("Item")]
public class GatewayIPAddressInformationCollection : ICollection<GatewayIPAddressInformation>, IEnumerable<GatewayIPAddressInformation>, IEnumerable
{
	private Collection<GatewayIPAddressInformation> addresses;

	/// <summary>Gets the number of <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> types in this collection.</summary>
	/// <returns>An <see cref="T:System.Int32" /> value that contains the number of <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> types in this collection.</returns>
	public virtual int Count => 0;

	/// <summary>Gets a value that indicates whether access to this collection is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	public virtual bool IsReadOnly => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformationCollection" /> class.</summary>
	protected internal GatewayIPAddressInformationCollection()
	{
	}

	/// <summary>Copies the elements in this collection to a one-dimensional array of type <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" />.</summary>
	/// <param name="array">A one-dimensional array that receives a copy of the collection.</param>
	/// <param name="offset">The zero-based index in <paramref name="array" /> at which the copy begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in this <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> is greater than the available space from <paramref name="count" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The elements in this <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset)
	{
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" /> because this operation is not supported for this collection.</summary>
	/// <param name="address">The object to be added to the collection.</param>
	public virtual void Add(GatewayIPAddressInformation address)
	{
	}

	internal void InternalAdd(GatewayIPAddressInformation address)
	{
	}

	/// <summary>Checks whether the collection contains the specified <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> object.</summary>
	/// <param name="address">The <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> object to be searched in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformation" /> object exists in the collection; otherwise <see langword="false" />.</returns>
	public virtual bool Contains(GatewayIPAddressInformation address)
	{
		return false;
	}

	/// <summary>Returns an object that can be used to iterate through this collection.</summary>
	/// <returns>An object that implements the <see cref="T:System.Collections.IEnumerator" /> interface and provides access to the <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> types in this collection.</returns>
	public virtual IEnumerator<GatewayIPAddressInformation> GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an object that can be used to iterate through this collection.</summary>
	/// <returns>An object that implements the <see cref="T:System.Collections.IEnumerator" /> interface and provides access to the <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformation" /> types in this collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" /> because this operation is not supported for this collection.</summary>
	/// <param name="address">The object to be removed.</param>
	/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
	public virtual bool Remove(GatewayIPAddressInformation address)
	{
		return false;
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" /> because this operation is not supported for this collection.</summary>
	public virtual void Clear()
	{
	}
}
