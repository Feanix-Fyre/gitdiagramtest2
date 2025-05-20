using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.XPath;

namespace System.Xml.Schema;

/// <summary>Represents the typed value of a validated XML element or attribute. The <see cref="T:System.Xml.Schema.XmlAtomicValue" /> class cannot be inherited.</summary>
public sealed class XmlAtomicValue : XPathItem, ICloneable
{
	[StructLayout((LayoutKind)2)]
	private struct Union
	{
		[FieldOffset(0)]
		public bool boolVal;

		[FieldOffset(0)]
		public double dblVal;

		[FieldOffset(0)]
		public long i64Val;

		[FieldOffset(0)]
		public int i32Val;

		[FieldOffset(0)]
		public DateTime dtVal;
	}

	private class NamespacePrefixForQName : IXmlNamespaceResolver
	{
		public string prefix;

		public string ns;

		public NamespacePrefixForQName(string prefix, string ns)
		{
		}

		public string LookupNamespace(string prefix)
		{
			return null;
		}

		public string LookupPrefix(string namespaceName)
		{
			return null;
		}

		public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}
	}

	private XmlSchemaType xmlType;

	private object objVal;

	private TypeCode clrType;

	private Union unionVal;

	private NamespacePrefixForQName nsPrefix;

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaType" /> for the validated XML element or attribute.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaType" /> for the validated XML element or attribute.</returns>
	public override XmlSchemaType XmlType => null;

	/// <summary>Gets the Microsoft .NET Framework type of the validated XML element or attribute.</summary>
	/// <returns>The .NET Framework type of the validated XML element or attribute. The default value is <see cref="T:System.String" />.</returns>
	public override Type ValueType => null;

	/// <summary>Gets the current validated XML element or attribute as a boxed object of the most appropriate Microsoft .NET Framework type according to its schema type.</summary>
	/// <returns>The current validated XML element or attribute as a boxed object of the most appropriate .NET Framework type.</returns>
	public override object TypedValue => null;

	/// <summary>Gets the validated XML element or attribute's value as a <see cref="T:System.Boolean" />.</summary>
	/// <returns>The validated XML element or attribute's value as a <see cref="T:System.Boolean" />.</returns>
	/// <exception cref="T:System.FormatException">The validated XML element or attribute's value is not in the correct format for the <see cref="T:System.Boolean" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Boolean" /> is not valid.</exception>
	public override bool ValueAsBoolean => false;

	/// <summary>Gets the validated XML element or attribute's value as a <see cref="T:System.DateTime" />.</summary>
	/// <returns>The validated XML element or attribute's value as a <see cref="T:System.DateTime" />.</returns>
	/// <exception cref="T:System.FormatException">The validated XML element or attribute's value is not in the correct format for the <see cref="T:System.DateTime" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.DateTime" /> is not valid.</exception>
	public override DateTime ValueAsDateTime => default(DateTime);

	/// <summary>Gets the validated XML element or attribute's value as a <see cref="T:System.Double" />.</summary>
	/// <returns>The validated XML element or attribute's value as a <see cref="T:System.Double" />.</returns>
	/// <exception cref="T:System.FormatException">The validated XML element or attribute's value is not in the correct format for the <see cref="T:System.Double" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Double" /> is not valid.</exception>
	/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
	public override double ValueAsDouble => 0.0;

	/// <summary>Gets the validated XML element or attribute's value as an <see cref="T:System.Int32" />.</summary>
	/// <returns>The validated XML element or attribute's value as an <see cref="T:System.Int32" />.</returns>
	/// <exception cref="T:System.FormatException">The validated XML element or attribute's value is not in the correct format for the <see cref="T:System.Int32" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int32" /> is not valid.</exception>
	/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
	public override int ValueAsInt => 0;

	/// <summary>Gets the validated XML element or attribute's value as an <see cref="T:System.Int64" />.</summary>
	/// <returns>The validated XML element or attribute's value as an <see cref="T:System.Int64" />.</returns>
	/// <exception cref="T:System.FormatException">The validated XML element or attribute's value is not in the correct format for the <see cref="T:System.Int64" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int64" /> is not valid.</exception>
	/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
	public override long ValueAsLong => 0L;

	/// <summary>Gets the <see langword="string" /> value of the validated XML element or attribute.</summary>
	/// <returns>The <see langword="string" /> value of the validated XML element or attribute.</returns>
	public override string Value => null;

	internal XmlAtomicValue(XmlSchemaType xmlType, bool value)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, double value)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, int value)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, long value)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, string value)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, object value)
	{
	}

	internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlAtomicValue.Clone" />.</summary>
	/// <returns>Returns a copy of this <see cref="T:System.Xml.Schema.XmlAtomicValue" /> object.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Returns the validated XML element or attribute's value as the type specified using the <see cref="T:System.Xml.IXmlNamespaceResolver" /> object specified to resolve namespace prefixes.</summary>
	/// <param name="type">The type to return the validated XML element or attribute's value as.</param>
	/// <param name="nsResolver">The <see cref="T:System.Xml.IXmlNamespaceResolver" /> object used to resolve namespace prefixes.</param>
	/// <returns>The value of the validated XML element or attribute as the type requested.</returns>
	/// <exception cref="T:System.FormatException">The validated XML element or attribute's value is not in the correct format for the target type.</exception>
	/// <exception cref="T:System.InvalidCastException">The attempted cast is not valid.</exception>
	/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	/// <summary>Gets the <see langword="string" /> value of the validated XML element or attribute.</summary>
	/// <returns>The <see langword="string" /> value of the validated XML element or attribute.</returns>
	public override string ToString()
	{
		return null;
	}

	private string GetPrefixFromQName(string value)
	{
		return null;
	}
}
