using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents a multicast delegate; that is, a delegate that can have more than one element in its invocation list.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class MulticastDelegate : Delegate
{
	private Delegate[] delegates;

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data needed to serialize this instance.</summary>
	/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
	/// <param name="context">(Reserved) The location where serialized data is stored and retrieved.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A serialization error occurred.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	protected sealed override object DynamicInvokeImpl(object[] args)
	{
		return null;
	}

	/// <summary>Determines whether this multicast delegate and the specified object are equal.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> and this instance have the same invocation lists; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism.</exception>
	public sealed override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism.</exception>
	public sealed override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a static method represented by the current <see cref="T:System.MulticastDelegate" />.</summary>
	/// <returns>A static method represented by the current <see cref="T:System.MulticastDelegate" />.</returns>
	protected override MethodInfo GetMethodImpl()
	{
		return null;
	}

	/// <summary>Returns the invocation list of this multicast delegate, in invocation order.</summary>
	/// <returns>An array of delegates whose invocation lists collectively match the invocation list of this instance.</returns>
	/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism.</exception>
	public sealed override Delegate[] GetInvocationList()
	{
		return null;
	}

	/// <summary>Combines this <see cref="T:System.Delegate" /> with the specified <see cref="T:System.Delegate" /> to form a new delegate.</summary>
	/// <param name="follow">The delegate to combine with this delegate.</param>
	/// <returns>A delegate that is the new root of the <see cref="T:System.MulticastDelegate" /> invocation list.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="follow" /> does not have the same type as this instance.</exception>
	/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism.</exception>
	protected sealed override Delegate CombineImpl(Delegate follow)
	{
		return null;
	}

	private int LastIndexOf(Delegate[] haystack, Delegate[] needle)
	{
		return 0;
	}

	/// <summary>Removes an element from the invocation list of this <see cref="T:System.MulticastDelegate" /> that is equal to the specified delegate.</summary>
	/// <param name="value">The delegate to search for in the invocation list.</param>
	/// <returns>If <paramref name="value" /> is found in the invocation list for this instance, then a new <see cref="T:System.Delegate" /> without <paramref name="value" /> in its invocation list; otherwise, this instance with its original invocation list.</returns>
	/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism.</exception>
	protected sealed override Delegate RemoveImpl(Delegate value)
	{
		return null;
	}
}
