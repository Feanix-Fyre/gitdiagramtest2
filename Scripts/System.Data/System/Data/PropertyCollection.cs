using System.Collections;
using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents a collection of properties that can be added to <see cref="T:System.Data.DataColumn" />, <see cref="T:System.Data.DataSet" />, or <see cref="T:System.Data.DataTable" />.</summary>
[Serializable]
public class PropertyCollection : Hashtable, ICloneable
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.PropertyCollection" /> class.</summary>
	public PropertyCollection()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.PropertyCollection" /> class.</summary>
	/// <param name="info">The data needed to serialize or deserialize an object.</param>
	/// <param name="context">The source and destination of a given serialized stream.</param>
	protected PropertyCollection(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Data.PropertyCollection" /> object.</summary>
	/// <returns>Returns <see cref="T:System.Object" />, a shallow copy of the <see cref="T:System.Data.PropertyCollection" /> object.</returns>
	public override object Clone()
	{
		return null;
	}
}
