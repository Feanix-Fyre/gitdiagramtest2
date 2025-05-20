using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents a weak reference, which references an object while still allowing that object to be reclaimed by garbage collection.</summary>
[Serializable]
[ComVisible(true)]
public class WeakReference : ISerializable
{
	private bool isLongReference;

	private GCHandle gcHandle;

	/// <summary>Gets an indication whether the object referenced by the current <see cref="T:System.WeakReference" /> object has been garbage collected.</summary>
	/// <returns>
	///   <see langword="true" /> if the object referenced by the current <see cref="T:System.WeakReference" /> object has not been garbage collected and is still accessible; otherwise, <see langword="false" />.</returns>
	public virtual bool IsAlive => false;

	/// <summary>Gets or sets the object (the target) referenced by the current <see cref="T:System.WeakReference" /> object.</summary>
	/// <returns>
	///   <see langword="null" /> if the object referenced by the current <see cref="T:System.WeakReference" /> object has been garbage collected; otherwise, a reference to the object referenced by the current <see cref="T:System.WeakReference" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">The reference to the target object is invalid. This exception can be thrown while setting this property if the value is a null reference or if the object has been finalized during the set operation.</exception>
	public virtual object Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets an indication whether the object referenced by the current <see cref="T:System.WeakReference" /> object is tracked after it is finalized.</summary>
	/// <returns>
	///   <see langword="true" /> if the object the current <see cref="T:System.WeakReference" /> object refers to is tracked after finalization; or <see langword="false" /> if the object is only tracked until finalization.</returns>
	public virtual bool TrackResurrection => false;

	private void AllocateHandle(object target)
	{
	}

	protected WeakReference()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference" /> class, referencing the specified object.</summary>
	/// <param name="target">The object to track or <see langword="null" />.</param>
	public WeakReference(object target)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference" /> class, referencing the specified object and using the specified resurrection tracking.</summary>
	/// <param name="target">An object to track.</param>
	/// <param name="trackResurrection">Indicates when to stop tracking the object. If <see langword="true" />, the object is tracked after finalization; if <see langword="false" />, the object is only tracked until finalization.</param>
	public WeakReference(object target, bool trackResurrection)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference" /> class, using deserialized data from the specified serialization and stream objects.</summary>
	/// <param name="info">An object that holds all the data needed to serialize or deserialize the current <see cref="T:System.WeakReference" /> object.</param>
	/// <param name="context">(Reserved) Describes the source and destination of the serialized stream specified by <paramref name="info" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected WeakReference(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Discards the reference to the target represented by the current <see cref="T:System.WeakReference" /> object.</summary>
	~WeakReference()
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data needed to serialize the current <see cref="T:System.WeakReference" /> object.</summary>
	/// <param name="info">An object that holds all the data needed to serialize or deserialize the current <see cref="T:System.WeakReference" /> object.</param>
	/// <param name="context">(Reserved) The location where serialized data is stored and retrieved.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
/// <summary>Represents a typed weak reference, which references an object while still allowing that object to be reclaimed by garbage collection.</summary>
/// <typeparam name="T">The type of the object referenced.</typeparam>
[Serializable]
public sealed class WeakReference<T> : ISerializable where T : class
{
	private GCHandle handle;

	private bool trackResurrection;

	/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference`1" /> class that references the specified object.</summary>
	/// <param name="target">The object to reference, or <see langword="null" />.</param>
	public WeakReference(T target)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.WeakReference`1" /> class that references the specified object and uses the specified resurrection tracking.</summary>
	/// <param name="target">The object to reference, or <see langword="null" />.</param>
	/// <param name="trackResurrection">
	///   <see langword="true" /> to track the object after finalization; <see langword="false" /> to track the object only until finalization.</param>
	public WeakReference(T target, bool trackResurrection)
	{
	}

	private WeakReference(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data necessary to serialize the current <see cref="T:System.WeakReference`1" /> object.</summary>
	/// <param name="info">An object that holds all the data necessary to serialize or deserialize the current <see cref="T:System.WeakReference`1" /> object.</param>
	/// <param name="context">The location where serialized data is stored and retrieved.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the target object that is referenced by this <see cref="T:System.WeakReference`1" /> object.</summary>
	/// <param name="target">The new target object.</param>
	public void SetTarget(T target)
	{
	}

	/// <summary>Tries to retrieve the target object that is referenced by the current <see cref="T:System.WeakReference`1" /> object.</summary>
	/// <param name="target">When this method returns, contains the target object, if it is available. This parameter is treated as uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the target was retrieved; otherwise, <see langword="false" />.</returns>
	public bool TryGetTarget(out T target)
	{
		target = null;
		return false;
	}

	/// <summary>Discards the reference to the target that is represented by the current <see cref="T:System.WeakReference`1" /> object.</summary>
	~WeakReference()
	{
	}
}
