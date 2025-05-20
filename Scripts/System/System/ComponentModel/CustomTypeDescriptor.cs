namespace System.ComponentModel;

/// <summary>Provides a simple default implementation of the <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> interface.</summary>
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
{
	private readonly ICustomTypeDescriptor _parent;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CustomTypeDescriptor" /> class.</summary>
	protected CustomTypeDescriptor()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CustomTypeDescriptor" /> class using a parent custom type descriptor.</summary>
	/// <param name="parent">The parent custom type descriptor.</param>
	protected CustomTypeDescriptor(ICustomTypeDescriptor parent)
	{
	}

	/// <summary>Returns a collection of custom attributes for the type represented by this type descriptor.</summary>
	/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> containing the attributes for the type. The default is <see cref="F:System.ComponentModel.AttributeCollection.Empty" />.</returns>
	public virtual AttributeCollection GetAttributes()
	{
		return null;
	}

	/// <summary>Returns the fully qualified name of the class represented by this type descriptor.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the fully qualified class name of the type this type descriptor is describing. The default is <see langword="null" />.</returns>
	public virtual string GetClassName()
	{
		return null;
	}

	/// <summary>Returns the name of the class represented by this type descriptor.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of the component instance this type descriptor is describing. The default is <see langword="null" />.</returns>
	public virtual string GetComponentName()
	{
		return null;
	}

	/// <summary>Returns a type converter for the type represented by this type descriptor.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the type represented by this type descriptor. The default is a newly created <see cref="T:System.ComponentModel.TypeConverter" />.</returns>
	public virtual TypeConverter GetConverter()
	{
		return null;
	}

	/// <summary>Returns the event descriptor for the default event of the object represented by this type descriptor.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> for the default event on the object represented by this type descriptor. The default is <see langword="null" />.</returns>
	public virtual EventDescriptor GetDefaultEvent()
	{
		return null;
	}

	/// <summary>Returns the property descriptor for the default property of the object represented by this type descriptor.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> for the default property on the object represented by this type descriptor. The default is <see langword="null" />.</returns>
	public virtual PropertyDescriptor GetDefaultProperty()
	{
		return null;
	}

	/// <summary>Returns an editor of the specified type that is to be associated with the class represented by this type descriptor.</summary>
	/// <param name="editorBaseType">The base type of the editor to retrieve.</param>
	/// <returns>An editor of the given type that is to be associated with the class represented by this type descriptor. The default is <see langword="null" />.</returns>
	public virtual object GetEditor(Type editorBaseType)
	{
		return null;
	}

	/// <summary>Returns a collection of event descriptors for the object represented by this type descriptor.</summary>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> containing the event descriptors for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.EventDescriptorCollection.Empty" />.</returns>
	public virtual EventDescriptorCollection GetEvents()
	{
		return null;
	}

	/// <summary>Returns a filtered collection of event descriptors for the object represented by this type descriptor.</summary>
	/// <param name="attributes">An array of attributes to use as a filter. This can be <see langword="null" />.</param>
	/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> containing the event descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.EventDescriptorCollection.Empty" />.</returns>
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns a collection of property descriptors for the object represented by this type descriptor.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> containing the property descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
	public virtual PropertyDescriptorCollection GetProperties()
	{
		return null;
	}

	/// <summary>Returns a filtered collection of property descriptors for the object represented by this type descriptor.</summary>
	/// <param name="attributes">An array of attributes to use as a filter. This can be <see langword="null" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> containing the property descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
	{
		return null;
	}

	/// <summary>Returns an object that contains the property described by the specified property descriptor.</summary>
	/// <param name="pd">The property descriptor for which to retrieve the owning object.</param>
	/// <returns>An <see cref="T:System.Object" /> that owns the given property specified by the type descriptor. The default is <see langword="null" />.</returns>
	public virtual object GetPropertyOwner(PropertyDescriptor pd)
	{
		return null;
	}
}
