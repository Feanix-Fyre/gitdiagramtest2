using System.Diagnostics;

namespace System.ComponentModel;

/// <summary>Specifies the class used to implement design-time services for a component.</summary>
[Conditional("FALSE")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
public sealed class DesignerAttribute : Attribute
{
	private readonly string designerTypeName;

	private readonly string designerBaseTypeName;

	private string typeId;

	/// <summary>Gets the name of the base type of this designer.</summary>
	/// <returns>The name of the base type of this designer.</returns>
	public string DesignerBaseTypeName => null;

	/// <summary>Gets the name of the designer type associated with this designer attribute.</summary>
	/// <returns>The name of the designer type associated with this designer attribute.</returns>
	public string DesignerTypeName => null;

	/// <summary>Gets a unique ID for this attribute type.</summary>
	/// <returns>A unique ID for this attribute type.</returns>
	public override object TypeId => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class using the name of the type that provides design-time services.</summary>
	/// <param name="designerTypeName">The concatenation of the fully qualified name of the type that provides design-time services for the component this attribute is bound to, and the name of the assembly this type resides in.</param>
	public DesignerAttribute(string designerTypeName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class using the type that provides design-time services.</summary>
	/// <param name="designerType">A <see cref="T:System.Type" /> that represents the class that provides design-time services for the component this attribute is bound to.</param>
	public DesignerAttribute(Type designerType)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class using the designer type and the base class for the designer.</summary>
	/// <param name="designerTypeName">The concatenation of the fully qualified name of the type that provides design-time services for the component this attribute is bound to, and the name of the assembly this type resides in.</param>
	/// <param name="designerBaseTypeName">The fully qualified name of the base class to associate with the designer class.</param>
	public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class, using the name of the designer class and the base class for the designer.</summary>
	/// <param name="designerTypeName">The concatenation of the fully qualified name of the type that provides design-time services for the component this attribute is bound to, and the name of the assembly this type resides in.</param>
	/// <param name="designerBaseType">A <see cref="T:System.Type" /> that represents the base class to associate with the <paramref name="designerTypeName" />.</param>
	public DesignerAttribute(string designerTypeName, Type designerBaseType)
	{
	}

	/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DesignerAttribute" />.</summary>
	/// <param name="obj">The object to test the value equality of.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
