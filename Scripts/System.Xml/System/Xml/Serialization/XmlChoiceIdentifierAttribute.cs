using System.Text;

namespace System.Xml.Serialization;

/// <summary>Specifies that the member can be further detected by using an enumeration.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
public class XmlChoiceIdentifierAttribute : Attribute
{
	private string memberName;

	/// <summary>Gets or sets the name of the field that returns the enumeration to use when detecting types.</summary>
	/// <returns>The name of a field that returns an enumeration.</returns>
	public string MemberName => null;

	internal void AddKeyHash(StringBuilder sb)
	{
	}
}
