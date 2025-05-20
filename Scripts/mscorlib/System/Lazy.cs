using System.Diagnostics;
using System.Threading;

namespace System;

/// <summary>Provides support for lazy initialization.</summary>
/// <typeparam name="T">The type of object that is being lazily initialized.</typeparam>
[Serializable]
[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[DebuggerTypeProxy(typeof(LazyDebugView<>))]
public class Lazy<T>
{
	private LazyHelper _state;

	private Func<T> _factory;

	private T _value;

	/// <summary>Gets a value that indicates whether a value has been created for this <see cref="T:System.Lazy`1" /> instance.</summary>
	/// <returns>
	///   <see langword="true" /> if a value has been created for this <see cref="T:System.Lazy`1" /> instance; otherwise, <see langword="false" />.</returns>
	public bool IsValueCreated => false;

	/// <summary>Gets the lazily initialized value of the current <see cref="T:System.Lazy`1" /> instance.</summary>
	/// <returns>The lazily initialized value of the current <see cref="T:System.Lazy`1" /> instance.</returns>
	/// <exception cref="T:System.MemberAccessException">The <see cref="T:System.Lazy`1" /> instance is initialized to use the default constructor of the type that is being lazily initialized, and permissions to access the constructor are missing.</exception>
	/// <exception cref="T:System.MissingMemberException">The <see cref="T:System.Lazy`1" /> instance is initialized to use the default constructor of the type that is being lazily initialized, and that type does not have a public, parameterless constructor.</exception>
	/// <exception cref="T:System.InvalidOperationException">The initialization function tries to access <see cref="P:System.Lazy`1.Value" /> on this instance.</exception>
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public T Value => default(T);

	private static T CreateViaDefaultConstructor()
	{
		return default(T);
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Lazy`1" /> class. When lazy initialization occurs, the default constructor of the target type is used.</summary>
	public Lazy()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Lazy`1" /> class. When lazy initialization occurs, the specified initialization function is used.</summary>
	/// <param name="valueFactory">The delegate that is invoked to produce the lazily initialized value when it is needed.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="valueFactory" /> is <see langword="null" />.</exception>
	public Lazy(Func<T> valueFactory)
	{
	}

	private Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor)
	{
	}

	private void ViaConstructor()
	{
	}

	private void ViaFactory(LazyThreadSafetyMode mode)
	{
	}

	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor)
	{
	}

	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue)
	{
	}

	private void PublicationOnlyViaConstructor(LazyHelper initializer)
	{
	}

	private void PublicationOnlyViaFactory(LazyHelper initializer)
	{
	}

	private void PublicationOnlyWaitForOtherThreadToPublish()
	{
	}

	private T CreateValue()
	{
		return default(T);
	}

	/// <summary>Creates and returns a string representation of the <see cref="P:System.Lazy`1.Value" /> property for this instance.</summary>
	/// <returns>The result of calling the <see cref="M:System.Object.ToString" /> method on the <see cref="P:System.Lazy`1.Value" /> property for this instance, if the value has been created (that is, if the <see cref="P:System.Lazy`1.IsValueCreated" /> property returns <see langword="true" />). Otherwise, a string indicating that the value has not been created.</returns>
	/// <exception cref="T:System.NullReferenceException">The <see cref="P:System.Lazy`1.Value" /> property is <see langword="null" />.</exception>
	public override string ToString()
	{
		return null;
	}
}
