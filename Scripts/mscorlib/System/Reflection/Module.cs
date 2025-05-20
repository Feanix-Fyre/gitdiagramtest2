using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

/// <summary>Performs reflection on a module.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module
{
	/// <summary>A <see langword="TypeFilter" /> object that filters the list of types defined in this module based upon the name. This field is case-sensitive and read-only.</summary>
	public static readonly TypeFilter FilterTypeName;

	/// <summary>A <see langword="TypeFilter" /> object that filters the list of types defined in this module based upon the name. This field is case-insensitive and read-only.</summary>
	public static readonly TypeFilter FilterTypeNameIgnoreCase;

	private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	/// <summary>Gets the appropriate <see cref="T:System.Reflection.Assembly" /> for this instance of <see cref="T:System.Reflection.Module" />.</summary>
	/// <returns>An <see langword="Assembly" /> object.</returns>
	public virtual Assembly Assembly => null;

	/// <summary>Gets a universally unique identifier (UUID) that can be used to distinguish between two versions of a module.</summary>
	/// <returns>A <see cref="T:System.Guid" /> that can be used to distinguish between two versions of a module.</returns>
	public virtual Guid ModuleVersionId => default(Guid);

	/// <summary>Gets a string representing the name of the module.</summary>
	/// <returns>The module name.</returns>
	public virtual string ScopeName => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.Module" /> class.</summary>
	protected Module()
	{
	}

	/// <summary>Gets a value indicating whether the object is a resource.</summary>
	/// <returns>
	///   <see langword="true" /> if the object is a resource; otherwise, <see langword="false" />.</returns>
	public virtual bool IsResource()
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the specified attribute type has been applied to this module.</summary>
	/// <param name="attributeType">The type of custom attribute to test for.</param>
	/// <param name="inherit">This argument is ignored for objects of this type.</param>
	/// <returns>
	///   <see langword="true" /> if one or more instances of <paramref name="attributeType" /> have been applied to this module; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Returns all custom attributes.</summary>
	/// <param name="inherit">This argument is ignored for objects of this type.</param>
	/// <returns>An array of type <see langword="Object" /> containing all custom attributes.</returns>
	public virtual object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Gets custom attributes of the specified type.</summary>
	/// <param name="attributeType">The type of attribute to get.</param>
	/// <param name="inherit">This argument is ignored for objects of this type.</param>
	/// <returns>An array of type <see langword="Object" /> containing all custom attributes of the specified type.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Provides an <see cref="T:System.Runtime.Serialization.ISerializable" /> implementation for serialized objects.</summary>
	/// <param name="info">The information and data needed to serialize or deserialize an object.</param>
	/// <param name="context">The context for the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Determines whether this module and the specified object are equal.</summary>
	/// <param name="o">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="o" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.Module" /> objects are equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Module left, Module right)
	{
		return false;
	}

	/// <summary>Returns the name of the module.</summary>
	/// <returns>A <see langword="String" /> representing the name of this module.</returns>
	public override string ToString()
	{
		return null;
	}

	private static bool FilterTypeNameImpl(Type cls, object filterCriteria)
	{
		return false;
	}

	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria)
	{
		return false;
	}

	internal virtual Guid GetModuleVersionId()
	{
		return default(Guid);
	}
}
