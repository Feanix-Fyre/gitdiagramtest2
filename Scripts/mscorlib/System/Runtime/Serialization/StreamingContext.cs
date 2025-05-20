using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

/// <summary>Describes the source and destination of a given serialized stream, and provides an additional caller-defined context.</summary>
[Serializable]
[ComVisible(true)]
public readonly struct StreamingContext
{
	internal readonly object m_additionalContext;

	internal readonly StreamingContextStates m_state;

	/// <summary>Gets context specified as part of the additional context.</summary>
	/// <returns>The context specified as part of the additional context.</returns>
	public object Context => null;

	/// <summary>Gets the source or destination of the transmitted data.</summary>
	/// <returns>During serialization, the destination of the transmitted data. During deserialization, the source of the data.</returns>
	public StreamingContextStates State => default(StreamingContextStates);

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class with a given context state.</summary>
	/// <param name="state">A bitwise combination of the <see cref="T:System.Runtime.Serialization.StreamingContextStates" /> values that specify the source or destination context for this <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
	public StreamingContext(StreamingContextStates state)
	{
		m_additionalContext = null;
		m_state = default(StreamingContextStates);
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class with a given context state, and some additional information.</summary>
	/// <param name="state">A bitwise combination of the <see cref="T:System.Runtime.Serialization.StreamingContextStates" /> values that specify the source or destination context for this <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
	/// <param name="additional">Any additional information to be associated with the <see cref="T:System.Runtime.Serialization.StreamingContext" />. This information is available to any object that implements <see cref="T:System.Runtime.Serialization.ISerializable" /> or any serialization surrogate. Most users do not need to set this parameter.</param>
	public StreamingContext(StreamingContextStates state, object additional)
	{
		m_additionalContext = null;
		m_state = default(StreamingContextStates);
	}

	/// <summary>Determines whether two <see cref="T:System.Runtime.Serialization.StreamingContext" /> instances contain the same values.</summary>
	/// <param name="obj">An object to compare with the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if the specified object is an instance of <see cref="T:System.Runtime.Serialization.StreamingContext" /> and equals the value of the current instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a hash code of this object.</summary>
	/// <returns>The <see cref="T:System.Runtime.Serialization.StreamingContextStates" /> value that contains the source or destination of the serialization for this <see cref="T:System.Runtime.Serialization.StreamingContext" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
