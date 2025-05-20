using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

/// <summary>Generates IDs for objects.</summary>
[Serializable]
[ComVisible(true)]
public class ObjectIDGenerator
{
	internal int m_currentCount;

	internal int m_currentSize;

	internal long[] m_ids;

	internal object[] m_objs;

	private static readonly int[] sizes;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" /> class.</summary>
	public ObjectIDGenerator()
	{
	}

	private int FindElement(object obj, out bool found)
	{
		found = default(bool);
		return 0;
	}

	/// <summary>Returns the ID for the specified object, generating a new ID if the specified object has not already been identified by the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />.</summary>
	/// <param name="obj">The object you want an ID for.</param>
	/// <param name="firstTime">
	///   <see langword="true" /> if <paramref name="obj" /> was not previously known to the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />; otherwise, <see langword="false" />.</param>
	/// <returns>The object's ID is used for serialization. <paramref name="firstTime" /> is set to <see langword="true" /> if this is the first time the object has been identified; otherwise, it is set to <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" /> has been asked to keep track of too many objects.</exception>
	public virtual long GetId(object obj, out bool firstTime)
	{
		firstTime = default(bool);
		return 0L;
	}

	/// <summary>Determines whether an object has already been assigned an ID.</summary>
	/// <param name="obj">The object you are asking for.</param>
	/// <param name="firstTime">
	///   <see langword="true" /> if <paramref name="obj" /> was not previously known to the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />; otherwise, <see langword="false" />.</param>
	/// <returns>The object ID of <paramref name="obj" /> if previously known to the <see cref="T:System.Runtime.Serialization.ObjectIDGenerator" />; otherwise, zero.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is <see langword="null" />.</exception>
	public virtual long HasId(object obj, out bool firstTime)
	{
		firstTime = default(bool);
		return 0L;
	}

	private void Rehash()
	{
	}
}
