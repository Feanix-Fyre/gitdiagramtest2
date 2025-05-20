namespace System.Windows.Forms;

/// <summary>Contains information that enables a <see cref="T:System.Windows.Forms.Binding" /> to resolve a data binding to either the property of an object or the property of the current object in a list of objects.</summary>
public struct BindingMemberInfo
{
	private string data_member;

	private string data_field;

	private string data_path;

	/// <summary>Gets the property name of the data-bound object.</summary>
	/// <returns>The property name of the data-bound object. This can be an empty string ("").</returns>
	public string BindingField => null;

	/// <summary>Gets the property name, or the period-delimited hierarchy of property names, that comes before the property name of the data-bound object.</summary>
	/// <returns>The property name, or the period-delimited hierarchy of property names, that comes before the data-bound object property name.</returns>
	public string BindingPath => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingMemberInfo" /> class.</summary>
	/// <param name="dataMember">A navigation path that resolves to either the property of an object or the property of the current object in a list of objects.</param>
	public BindingMemberInfo(string dataMember)
	{
		data_member = null;
		data_field = null;
		data_path = null;
	}

	/// <summary>Determines whether the specified object is equal to this <see cref="T:System.Windows.Forms.BindingMemberInfo" />.</summary>
	/// <param name="otherObject">The object to compare for equality.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="otherObject" /> is a <see cref="T:System.Windows.Forms.BindingMemberInfo" /> and both <see cref="P:System.Windows.Forms.BindingMemberInfo.BindingMember" /> strings are equal; otherwise <see langword="false" />.</returns>
	public override bool Equals(object otherObject)
	{
		return false;
	}

	/// <summary>Returns the hash code for this <see cref="T:System.Windows.Forms.BindingMemberInfo" />.</summary>
	/// <returns>The hash code for this <see cref="T:System.Windows.Forms.BindingMemberInfo" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
