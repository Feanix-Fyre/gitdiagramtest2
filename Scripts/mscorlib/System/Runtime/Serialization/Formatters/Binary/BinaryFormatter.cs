using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary;

/// <summary>Serializes and deserializes an object, or an entire graph of connected objects, in binary format.</summary>
[ComVisible(true)]
public sealed class BinaryFormatter
{
	internal ISurrogateSelector m_surrogates;

	internal StreamingContext m_context;

	internal SerializationBinder m_binder;

	internal FormatterTypeStyle m_typeFormat;

	internal FormatterAssemblyStyle m_assemblyFormat;

	internal TypeFilterLevel m_securityLevel;

	internal object[] m_crossAppDomainArray;

	private static Dictionary<Type, TypeInformation> typeNameCache;

	/// <summary>Gets or sets the behavior of the deserializer with regards to finding and loading assemblies.</summary>
	/// <returns>One of the <see cref="T:System.Runtime.Serialization.Formatters.FormatterAssemblyStyle" /> values that specifies the deserializer behavior.</returns>
	public FormatterAssemblyStyle AssemblyFormat
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that controls type substitution during serialization and deserialization.</summary>
	/// <returns>The surrogate selector to use with this formatter.</returns>
	public ISurrogateSelector SurrogateSelector
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> class with default values.</summary>
	public BinaryFormatter()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> class with a given surrogate selector and streaming context.</summary>
	/// <param name="selector">The <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> to use. Can be <see langword="null" />.</param>
	/// <param name="context">The source and destination for the serialized data.</param>
	public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
	{
	}

	/// <summary>Deserializes the specified stream into an object graph.</summary>
	/// <param name="serializationStream">The stream from which to deserialize the object graph.</param>
	/// <returns>The top (root) of the object graph.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0.  
	///  -or-  
	///  The target type is a <see cref="T:System.Decimal" />, but the value is out of range of the <see cref="T:System.Decimal" /> type.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public object Deserialize(Stream serializationStream)
	{
		return null;
	}

	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
	{
		return null;
	}

	/// <summary>Deserializes the specified stream into an object graph. The provided <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> handles any headers in that stream.</summary>
	/// <param name="serializationStream">The stream from which to deserialize the object graph.</param>
	/// <param name="handler">The <see cref="T:System.Runtime.Remoting.Messaging.HeaderHandler" /> that handles any headers in the <paramref name="serializationStream" />. Can be <see langword="null" />.</param>
	/// <returns>The deserialized object or the top object (root) of the object graph.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <paramref name="serializationStream" /> supports seeking, but its length is 0.  
	///  -or-  
	///  The target type is a <see cref="T:System.Decimal" />, but the value is out of range of the <see cref="T:System.Decimal" /> type.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public object Deserialize(Stream serializationStream, HeaderHandler handler)
	{
		return null;
	}

	/// <summary>Serializes the object, or graph of objects with the specified top (root), to the given stream.</summary>
	/// <param name="serializationStream">The stream to which the graph is to be serialized.</param>
	/// <param name="graph">The object at the root of the graph to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="graph" /> is null.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An error has occurred during serialization, such as if an object in the <paramref name="graph" /> parameter is not marked as serializable.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public void Serialize(Stream serializationStream, object graph)
	{
	}

	/// <summary>Serializes the object, or graph of objects with the specified top (root), to the given stream attaching the provided headers.</summary>
	/// <param name="serializationStream">The stream to which the object is to be serialized.</param>
	/// <param name="graph">The object at the root of the graph to serialize.</param>
	/// <param name="headers">Remoting headers to include in the serialization. Can be <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="serializationStream" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An error has occurred during serialization, such as if an object in the <paramref name="graph" /> parameter is not marked as serializable.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public void Serialize(Stream serializationStream, object graph, Header[] headers)
	{
	}

	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck)
	{
	}

	internal static TypeInformation GetTypeInformation(Type type)
	{
		return null;
	}
}
