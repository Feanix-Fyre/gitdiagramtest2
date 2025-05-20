using System.Collections;

namespace System.ComponentModel;

/// <summary>Provides supplemental metadata to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
public abstract class TypeDescriptionProvider
{
	private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
	{
	}

	private readonly TypeDescriptionProvider _parent;

	private EmptyCustomTypeDescriptor _emptyDescriptor;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> class.</summary>
	protected TypeDescriptionProvider()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> class using a parent type description provider.</summary>
	/// <param name="parent">The parent type description provider.</param>
	protected TypeDescriptionProvider(TypeDescriptionProvider parent)
	{
	}

	/// <summary>Creates an object that can substitute for another data type.</summary>
	/// <param name="provider">An optional service provider.</param>
	/// <param name="objectType">The type of object to create. This parameter is never <see langword="null" />.</param>
	/// <param name="argTypes">An optional array of types that represent the parameter types to be passed to the object's constructor. This array can be <see langword="null" /> or of zero length.</param>
	/// <param name="args">An optional array of parameter values to pass to the object's constructor.</param>
	/// <returns>The substitute <see cref="T:System.Object" />.</returns>
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
	{
		return null;
	}

	/// <summary>Gets a per-object cache, accessed as an <see cref="T:System.Collections.IDictionary" /> of key/value pairs.</summary>
	/// <param name="instance">The object for which to get the cache.</param>
	/// <returns>An <see cref="T:System.Collections.IDictionary" /> if the provided object supports caching; otherwise, <see langword="null" />.</returns>
	public virtual IDictionary GetCache(object instance)
	{
		return null;
	}

	/// <summary>Gets an extended custom type descriptor for the given object.</summary>
	/// <param name="instance">The object for which to get the extended type descriptor.</param>
	/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide extended metadata for the object.</returns>
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
	{
		return null;
	}

	/// <summary>Gets the extender providers for the specified object.</summary>
	/// <param name="instance">The object to get extender providers for.</param>
	/// <returns>An array of extender providers for <paramref name="instance" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="instance" /> is <see langword="null" />.</exception>
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
	{
		return null;
	}

	/// <summary>Gets the name of the specified component, or <see langword="null" /> if the component has no name.</summary>
	/// <param name="component">The specified component.</param>
	/// <returns>The name of the specified component.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="component" /> is <see langword="null" />.</exception>
	public virtual string GetFullComponentName(object component)
	{
		return null;
	}

	/// <summary>Performs normal reflection against a type.</summary>
	/// <param name="objectType">The type of object for which to retrieve the <see cref="T:System.Reflection.IReflect" />.</param>
	/// <returns>The type of reflection for this <paramref name="objectType" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="objectType" /> is <see langword="null" />.</exception>
	public Type GetReflectionType(Type objectType)
	{
		return null;
	}

	/// <summary>Performs normal reflection against the given object.</summary>
	/// <param name="instance">An instance of the type (should not be <see langword="null" />).</param>
	/// <returns>The type of reflection for this <paramref name="instance" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="instance" /> is <see langword="null" />.</exception>
	public Type GetReflectionType(object instance)
	{
		return null;
	}

	/// <summary>Performs normal reflection against the given object with the given type.</summary>
	/// <param name="objectType">The type of object for which to retrieve the <see cref="T:System.Reflection.IReflect" />.</param>
	/// <param name="instance">An instance of the type. Can be <see langword="null" />.</param>
	/// <returns>The type of reflection for this <paramref name="objectType" />.</returns>
	public virtual Type GetReflectionType(Type objectType, object instance)
	{
		return null;
	}

	/// <summary>Gets a custom type descriptor for the given type.</summary>
	/// <param name="objectType">The type of object for which to retrieve the type descriptor.</param>
	/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
	{
		return null;
	}

	/// <summary>Gets a custom type descriptor for the given object.</summary>
	/// <param name="instance">An instance of the type. Can be <see langword="null" /> if no instance was passed to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</param>
	/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="instance" /> is <see langword="null" />.</exception>
	public ICustomTypeDescriptor GetTypeDescriptor(object instance)
	{
		return null;
	}

	/// <summary>Gets a custom type descriptor for the given type and object.</summary>
	/// <param name="objectType">The type of object for which to retrieve the type descriptor.</param>
	/// <param name="instance">An instance of the type. Can be <see langword="null" /> if no instance was passed to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</param>
	/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
	{
		return null;
	}
}
