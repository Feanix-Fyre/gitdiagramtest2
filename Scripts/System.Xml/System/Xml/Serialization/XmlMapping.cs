using System.Collections;

namespace System.Xml.Serialization;

/// <summary>Supports mappings between .NET Framework types and XML Schema data types. </summary>
public abstract class XmlMapping
{
	private ObjectMap map;

	private ArrayList relatedMaps;

	private SerializationFormat format;

	private SerializationSource source;

	internal string _elementName;

	internal string _namespace;

	private string key;

	/// <summary>Get the name of the mapped element.</summary>
	/// <returns>The name of the mapped element.</returns>
	public string ElementName => null;

	/// <summary>Gets the namespace of the mapped element.</summary>
	/// <returns>The namespace of the mapped element.</returns>
	public string Namespace => null;

	internal ObjectMap ObjectMap
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ArrayList RelatedMaps
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal SerializationFormat Format
	{
		get
		{
			return default(SerializationFormat);
		}
		set
		{
		}
	}

	internal SerializationSource Source => null;

	internal XmlMapping(string elementName, string ns)
	{
	}

	/// <summary>Sets the key used to look up the mapping.</summary>
	/// <param name="key">A <see cref="T:System.String" /> that contains the lookup key.</param>
	public void SetKey(string key)
	{
	}
}
