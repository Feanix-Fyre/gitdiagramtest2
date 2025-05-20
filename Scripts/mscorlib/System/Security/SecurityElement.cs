using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security;

/// <summary>Represents the XML object model for encoding security objects. This class cannot be inherited.</summary>
[Serializable]
[ComVisible(true)]
public sealed class SecurityElement
{
	internal class SecurityAttribute
	{
		private string _name;

		private string _value;

		public string Name => null;

		public string Value => null;

		public SecurityAttribute(string name, string value)
		{
		}
	}

	private string text;

	private string tag;

	private ArrayList attributes;

	private ArrayList children;

	private static readonly char[] invalid_tag_chars;

	private static readonly char[] invalid_text_chars;

	private static readonly char[] invalid_attr_name_chars;

	private static readonly char[] invalid_attr_value_chars;

	private static readonly char[] invalid_chars;

	/// <summary>Gets or sets the array of child elements of the XML element.</summary>
	/// <returns>The ordered child elements of the XML element as security elements.</returns>
	/// <exception cref="T:System.ArgumentException">A child of the XML parent node is <see langword="null" />.</exception>
	public ArrayList Children => null;

	/// <summary>Gets or sets the tag name of an XML element.</summary>
	/// <returns>The tag name of an XML element.</returns>
	/// <exception cref="T:System.ArgumentNullException">The tag is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The tag is not valid in XML.</exception>
	public string Tag => null;

	/// <summary>Gets or sets the text within an XML element.</summary>
	/// <returns>The value of the text within an XML element.</returns>
	/// <exception cref="T:System.ArgumentException">The text is not valid in XML.</exception>
	public string Text
	{
		set
		{
		}
	}

	internal string m_strText
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityElement" /> class with the specified tag.</summary>
	/// <param name="tag">The tag name of an XML element.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="tag" /> parameter is invalid in XML.</exception>
	public SecurityElement(string tag)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityElement" /> class with the specified tag and text.</summary>
	/// <param name="tag">The tag name of the XML element.</param>
	/// <param name="text">The text content within the element.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="tag" /> parameter or <paramref name="text" /> parameter is invalid in XML.</exception>
	public SecurityElement(string tag, string text)
	{
	}

	/// <summary>Adds a name/value attribute to an XML element.</summary>
	/// <param name="name">The name of the attribute.</param>
	/// <param name="value">The value of the attribute.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter or <paramref name="value" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter or <paramref name="value" /> parameter is invalid in XML.  
	///  -or-  
	///  An attribute with the name specified by the <paramref name="name" /> parameter already exists.</exception>
	public void AddAttribute(string name, string value)
	{
	}

	/// <summary>Adds a child element to the XML element.</summary>
	/// <param name="child">The child element to add.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="child" /> parameter is <see langword="null" />.</exception>
	public void AddChild(SecurityElement child)
	{
	}

	/// <summary>Replaces invalid XML characters in a string with their valid XML equivalent.</summary>
	/// <param name="str">The string within which to escape invalid characters.</param>
	/// <returns>The input string with invalid characters replaced.</returns>
	public static string Escape(string str)
	{
		return null;
	}

	private static string Unescape(string str)
	{
		return null;
	}

	/// <summary>Determines whether a string is a valid attribute name.</summary>
	/// <param name="name">The attribute name to test for validity.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="name" /> parameter is a valid XML attribute name; otherwise, <see langword="false" />.</returns>
	public static bool IsValidAttributeName(string name)
	{
		return false;
	}

	/// <summary>Determines whether a string is a valid attribute value.</summary>
	/// <param name="value">The attribute value to test for validity.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter is a valid XML attribute value; otherwise, <see langword="false" />.</returns>
	public static bool IsValidAttributeValue(string value)
	{
		return false;
	}

	/// <summary>Determines whether a string is a valid tag.</summary>
	/// <param name="tag">The tag to test for validity.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="tag" /> parameter is a valid XML tag; otherwise, <see langword="false" />.</returns>
	public static bool IsValidTag(string tag)
	{
		return false;
	}

	/// <summary>Determines whether a string is valid as text within an XML element.</summary>
	/// <param name="text">The text to test for validity.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="text" /> parameter is a valid XML text element; otherwise, <see langword="false" />.</returns>
	public static bool IsValidText(string text)
	{
		return false;
	}

	/// <summary>Finds a child by its tag name.</summary>
	/// <param name="tag">The tag for which to search in child elements.</param>
	/// <returns>The first child XML element with the specified tag value, or <see langword="null" /> if no child element with <paramref name="tag" /> exists.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is <see langword="null" />.</exception>
	public SecurityElement SearchForChildByTag(string tag)
	{
		return null;
	}

	/// <summary>Produces a string representation of an XML element and its constituent attributes, child elements, and text.</summary>
	/// <returns>The XML element and its contents.</returns>
	public override string ToString()
	{
		return null;
	}

	private void ToXml(ref StringBuilder s, int level)
	{
	}

	internal SecurityAttribute GetAttribute(string name)
	{
		return null;
	}

	internal string SearchForTextOfLocalName(string strLocalName)
	{
		return null;
	}
}
