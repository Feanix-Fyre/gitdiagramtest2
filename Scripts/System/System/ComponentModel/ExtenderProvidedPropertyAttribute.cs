namespace System.ComponentModel;

/// <summary>Specifies a property that is offered by an extender provider. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class ExtenderProvidedPropertyAttribute : Attribute
{
	/// <summary>Gets the property that is being provided.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> encapsulating the property that is being provided.</returns>
	public PropertyDescriptor ExtenderProperty { get; private set; }

	/// <summary>Gets the extender provider that is providing the property.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.IExtenderProvider" /> that is providing the property.</returns>
	public IExtenderProvider Provider { get; private set; }

	/// <summary>Gets the type of object that can receive the property.</summary>
	/// <returns>A <see cref="T:System.Type" /> describing the type of object that can receive the property.</returns>
	public Type ReceiverType { get; private set; }

	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ExtenderProvidedPropertyAttribute" /> class.</summary>
	public ExtenderProvidedPropertyAttribute()
	{
	}

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
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

	/// <summary>Provides an indication whether the value of this instance is the default value for the derived class.</summary>
	/// <returns>
	///   <see langword="true" /> if this instance is the default attribute for the class; otherwise, <see langword="false" />.</returns>
	public override bool IsDefaultAttribute()
	{
		return false;
	}
}
