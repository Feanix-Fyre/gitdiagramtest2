using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System;

/// <summary>Describes objects that contain both a managed pointer to a location and a runtime representation of the type that may be stored at that location.</summary>
[ComVisible(true)]
[CLSCompliant(false)]
[NonVersionable]
public ref struct TypedReference
{
	private RuntimeTypeHandle type;

	private IntPtr Value;

	private IntPtr Type;

	internal bool IsNull => false;

	/// <summary>Makes a <see langword="TypedReference" /> for a field identified by a specified object and list of field descriptions.</summary>
	/// <param name="target">An object that contains the field described by the first element of <paramref name="flds" />.</param>
	/// <param name="flds">A list of field descriptions where each element describes a field that contains the field described by the succeeding element. Each described field must be a value type. The field descriptions must be <see langword="RuntimeFieldInfo" /> objects supplied by the type system.</param>
	/// <returns>A <see cref="T:System.TypedReference" /> for the field described by the last element of <paramref name="flds" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="target" /> or <paramref name="flds" /> is <see langword="null" />.  
	/// -or-  
	/// An element of <paramref name="flds" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="flds" /> array has no elements.  
	///  -or-  
	///  An element of <paramref name="flds" /> is not a <see langword="RuntimeFieldInfo" /> object.  
	///  -or-  
	///  The <see cref="P:System.Reflection.FieldInfo.IsInitOnly" /> or <see cref="P:System.Reflection.FieldInfo.IsStatic" /> property of an element of <paramref name="flds" /> is <see langword="true" />.</exception>
	/// <exception cref="T:System.MissingMemberException">Parameter <paramref name="target" /> does not contain the field described by the first element of <paramref name="flds" />, or an element of <paramref name="flds" /> describes a field that is not contained in the field described by the succeeding element of <paramref name="flds" />.  
	///  -or-  
	///  The field described by an element of <paramref name="flds" /> is not a value type.</exception>
	[CLSCompliant(false)]
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds)
	{
		return default(TypedReference);
	}

	private unsafe static void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType)
	{
	}

	/// <summary>Returns the hash code of this object.</summary>
	/// <returns>The hash code of this object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Checks if this object is equal to the specified object.</summary>
	/// <param name="o">The object with which to compare the current object.</param>
	/// <returns>
	///   <see langword="true" /> if this object is equal to the specified object; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented.</exception>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Converts the specified value to a <see langword="TypedReference" />. This method is not supported.</summary>
	/// <param name="target">The target of the conversion.</param>
	/// <param name="value">The value to be converted.</param>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	[CLSCompliant(false)]
	public static void SetTypedReference(TypedReference target, object value)
	{
	}
}
