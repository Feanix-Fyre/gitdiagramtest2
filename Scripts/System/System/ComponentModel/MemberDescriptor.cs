using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.ComponentModel;

/// <summary>Represents a class member, such as a property or event. This is an abstract base class.</summary>
[ComVisible(true)]
public abstract class MemberDescriptor
{
	private string name;

	private string displayName;

	private int nameHash;

	private AttributeCollection attributeCollection;

	private Attribute[] attributes;

	private Attribute[] originalAttributes;

	private bool attributesFiltered;

	private bool attributesFilled;

	private int metadataVersion;

	private string category;

	private string description;

	private object lockCookie;

	/// <summary>Gets or sets an array of attributes.</summary>
	/// <returns>An array of type <see cref="T:System.Attribute" /> that contains the attributes of this member.</returns>
	protected virtual Attribute[] AttributeArray
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of attributes for this member.</summary>
	/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> that provides the attributes for this member, or an empty collection if there are no attributes in the <see cref="P:System.ComponentModel.MemberDescriptor.AttributeArray" />.</returns>
	public virtual AttributeCollection Attributes => null;

	/// <summary>Gets the name of the member.</summary>
	/// <returns>The name of the member.</returns>
	public virtual string Name => null;

	/// <summary>Gets the hash code for the name of the member, as specified in <see cref="M:System.String.GetHashCode" />.</summary>
	/// <returns>The hash code for the name of the member.</returns>
	protected virtual int NameHashCode => 0;

	/// <summary>Gets the name that can be displayed in a window, such as a Properties window.</summary>
	/// <returns>The name to display for the member.</returns>
	public virtual string DisplayName => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MemberDescriptor" /> class with the specified name of the member and an array of attributes.</summary>
	/// <param name="name">The name of the member.</param>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that contains the member attributes.</param>
	/// <exception cref="T:System.ArgumentException">The name is an empty string ("") or <see langword="null" />.</exception>
	protected MemberDescriptor(string name, Attribute[] attributes)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MemberDescriptor" /> class with the name in the specified <see cref="T:System.ComponentModel.MemberDescriptor" /> and the attributes in both the old <see cref="T:System.ComponentModel.MemberDescriptor" /> and the <see cref="T:System.Attribute" /> array.</summary>
	/// <param name="oldMemberDescriptor">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that has the name of the member and its attributes.</param>
	/// <param name="newAttributes">An array of <see cref="T:System.Attribute" /> objects with the attributes you want to add to the member.</param>
	protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
	{
	}

	private void CheckAttributesValid()
	{
	}

	/// <summary>Creates a collection of attributes using the array of attributes passed to the constructor.</summary>
	/// <returns>A new <see cref="T:System.ComponentModel.AttributeCollection" /> that contains the <see cref="P:System.ComponentModel.MemberDescriptor.AttributeArray" /> attributes.</returns>
	protected virtual AttributeCollection CreateAttributeCollection()
	{
		return null;
	}

	/// <summary>Compares this instance to the given object to see if they are equivalent.</summary>
	/// <param name="obj">The object to compare to the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if equivalent; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>When overridden in a derived class, adds the attributes of the inheriting class to the specified list of attributes in the parent class.</summary>
	/// <param name="attributeList">An <see cref="T:System.Collections.IList" /> that lists the attributes in the parent class. Initially, this is empty.</param>
	protected virtual void FillAttributes(IList attributeList)
	{
	}

	private void FilterAttributesIfNeeded()
	{
	}

	/// <summary>Finds the given method through reflection, searching only for public methods.</summary>
	/// <param name="componentClass">The component that contains the method.</param>
	/// <param name="name">The name of the method to find.</param>
	/// <param name="args">An array of parameters for the method, used to choose between overloaded methods.</param>
	/// <param name="returnType">The type to return for the method.</param>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> that represents the method, or <see langword="null" /> if the method is not found.</returns>
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
	{
		return null;
	}

	/// <summary>Finds the given method through reflection, with an option to search only public methods.</summary>
	/// <param name="componentClass">The component that contains the method.</param>
	/// <param name="name">The name of the method to find.</param>
	/// <param name="args">An array of parameters for the method, used to choose between overloaded methods.</param>
	/// <param name="returnType">The type to return for the method.</param>
	/// <param name="publicOnly">Whether to restrict search to public methods.</param>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> that represents the method, or <see langword="null" /> if the method is not found.</returns>
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
	{
		return null;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A hash code for the current <see cref="T:System.ComponentModel.MemberDescriptor" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Retrieves the object that should be used during invocation of members.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the invocation target.</param>
	/// <param name="instance">The potential invocation target.</param>
	/// <returns>The object to be used during member invocations.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> or <paramref name="instance" /> is <see langword="null" />.</exception>
	protected virtual object GetInvocationTarget(Type type, object instance)
	{
		return null;
	}

	/// <summary>Gets a component site for the given component.</summary>
	/// <param name="component">The component for which you want to find a site.</param>
	/// <returns>The site of the component, or <see langword="null" /> if a site does not exist.</returns>
	protected static ISite GetSite(object component)
	{
		return null;
	}
}
