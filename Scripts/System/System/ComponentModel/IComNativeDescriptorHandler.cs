namespace System.ComponentModel;

/// <summary>Provides a top-level mapping layer between a COM object and a <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
[Obsolete("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
public interface IComNativeDescriptorHandler
{
	/// <summary>Gets the attributes for the specified component.</summary>
	/// <param name="component">The component to get attributes for.</param>
	/// <returns>A collection of attributes for <paramref name="component" />.</returns>
	AttributeCollection GetAttributes(object component);

	/// <summary>Gets the class name for the specified component.</summary>
	/// <param name="component">The component to get the class name for.</param>
	/// <returns>The name of the class that corresponds with <paramref name="component" />.</returns>
	string GetClassName(object component);

	/// <summary>Gets the type converter for the specified component.</summary>
	/// <param name="component">The component to get the <see cref="T:System.ComponentModel.TypeConverter" /> for.</param>
	/// <returns>The <see cref="T:System.ComponentModel.TypeConverter" /> for <paramref name="component" />.</returns>
	TypeConverter GetConverter(object component);

	/// <summary>Gets the default event for the specified component.</summary>
	/// <param name="component">The component to get the default event for.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptor" /> that represents <paramref name="component" />'s default event.</returns>
	EventDescriptor GetDefaultEvent(object component);

	/// <summary>Gets the default property for the specified component.</summary>
	/// <param name="component">The component to get the default property for.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that represents <paramref name="component" />'s default property.</returns>
	PropertyDescriptor GetDefaultProperty(object component);

	/// <summary>Gets the editor for the specified component.</summary>
	/// <param name="component">The component to get the editor for.</param>
	/// <param name="baseEditorType">The base type of the editor for <paramref name="component" />.</param>
	/// <returns>The editor for <paramref name="component" />.</returns>
	object GetEditor(object component, Type baseEditorType);

	/// <summary>Gets the events for the specified component.</summary>
	/// <param name="component">The component to get events for.</param>
	/// <returns>A collection of event descriptors for <paramref name="component" />.</returns>
	EventDescriptorCollection GetEvents(object component);

	/// <summary>Gets the events with the specified attributes for the specified component.</summary>
	/// <param name="component">The component to get events for.</param>
	/// <param name="attributes">The attributes used to filter events.</param>
	/// <returns>A collection of event descriptors for <paramref name="component" />.</returns>
	EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

	/// <summary>Gets the properties with the specified attributes for the specified component.</summary>
	/// <param name="component">The component to get events for.</param>
	/// <param name="attributes">The attributes used to filter properties.</param>
	/// <returns>A collection of property descriptors for <paramref name="component" />.</returns>
	PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);
}
