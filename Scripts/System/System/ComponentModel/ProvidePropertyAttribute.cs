namespace System.ComponentModel;

/// <summary>Specifies the name of the property that an implementer of <see cref="T:System.ComponentModel.IExtenderProvider" /> offers to other components. This class cannot be inherited</summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class ProvidePropertyAttribute : Attribute
{
	/// <summary>Gets the name of a property that this class provides.</summary>
	/// <returns>The name of a property that this class provides.</returns>
	public string PropertyName { get; }

	/// <summary>Gets the name of the data type this property can extend.</summary>
	/// <returns>The name of the data type this property can extend.</returns>
	public string ReceiverTypeName { get; }

	/// <summary>Gets a unique identifier for this attribute.</summary>
	/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
	public override object TypeId => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ProvidePropertyAttribute" /> class with the name of the property and its <see cref="T:System.Type" />.</summary>
	/// <param name="propertyName">The name of the property extending to an object of the specified type.</param>
	/// <param name="receiverType">The <see cref="T:System.Type" /> of the data type of the object that can receive the property.</param>
	public ProvidePropertyAttribute(string propertyName, Type receiverType)
	{
	}

	/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />.</summary>
	/// <param name="obj">The object to test the value equality of.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A hash code for the current <see cref="T:System.ComponentModel.ProvidePropertyAttribute" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
