using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System;

/// <summary>Represents type declarations: class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types.</summary>
[Serializable]
public abstract class Type : MemberInfo
{
	private static Binder s_defaultBinder;

	/// <summary>Separates names in the namespace of the <see cref="T:System.Type" />. This field is read-only.</summary>
	public static readonly char Delimiter;

	/// <summary>Represents an empty array of type <see cref="T:System.Type" />. This field is read-only.</summary>
	public static readonly Type[] EmptyTypes;

	/// <summary>Represents a missing value in the <see cref="T:System.Type" /> information. This field is read-only.</summary>
	public static readonly object Missing;

	/// <summary>Represents the member filter used on attributes. This field is read-only.</summary>
	public static readonly MemberFilter FilterAttribute;

	/// <summary>Represents the case-sensitive member filter used on names. This field is read-only.</summary>
	public static readonly MemberFilter FilterName;

	/// <summary>Represents the case-insensitive member filter used on names. This field is read-only.</summary>
	public static readonly MemberFilter FilterNameIgnoreCase;

	private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	internal RuntimeTypeHandle _impl;

	internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType";

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is serializable.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is serializable; otherwise, <see langword="false" />.</returns>
	public virtual bool IsSerializable => false;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> object has type parameters that have not been replaced by specific types.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> object is itself a generic type parameter or has type parameters for which specific types have not been supplied; otherwise, <see langword="false" />.</returns>
	public virtual bool ContainsGenericParameters => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> can be accessed by code outside the assembly.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Type" /> is a public type or a public nested type such that all the enclosing types are public; otherwise, <see langword="false" />.</returns>
	public bool IsVisible => false;

	/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a type or a nested type.</summary>
	/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a type or a nested type.</returns>
	public override MemberTypes MemberType => default(MemberTypes);

	/// <summary>Gets the namespace of the <see cref="T:System.Type" />.</summary>
	/// <returns>The namespace of the <see cref="T:System.Type" />; <see langword="null" /> if the current instance has no namespace or represents a generic parameter.</returns>
	public abstract string Namespace { get; }

	/// <summary>Gets the assembly-qualified name of the type, which includes the name of the assembly from which this <see cref="T:System.Type" /> object was loaded.</summary>
	/// <returns>The assembly-qualified name of the <see cref="T:System.Type" />, which includes the name of the assembly from which the <see cref="T:System.Type" /> was loaded, or <see langword="null" /> if the current instance represents a generic type parameter.</returns>
	public abstract string AssemblyQualifiedName { get; }

	/// <summary>Gets the fully qualified name of the type, including its namespace but not its assembly.</summary>
	/// <returns>The fully qualified name of the type, including its namespace but not its assembly; or <see langword="null" /> if the current instance represents a generic type parameter, an array type, pointer type, or <see langword="byref" /> type based on a type parameter, or a generic type that is not a generic type definition but contains unresolved type parameters.</returns>
	public abstract string FullName { get; }

	/// <summary>Gets the <see cref="T:System.Reflection.Assembly" /> in which the type is declared. For generic types, gets the <see cref="T:System.Reflection.Assembly" /> in which the generic type is defined.</summary>
	/// <returns>An <see cref="T:System.Reflection.Assembly" /> instance that describes the assembly containing the current type. For generic types, the instance describes the assembly that contains the generic type definition, not the assembly that creates and uses a particular constructed type.</returns>
	public abstract Assembly Assembly { get; }

	/// <summary>Gets the module (the DLL) in which the current <see cref="T:System.Type" /> is defined.</summary>
	/// <returns>The module in which the current <see cref="T:System.Type" /> is defined.</returns>
	public new abstract Module Module { get; }

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> object represents a type whose definition is nested inside the definition of another type.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is nested inside another type; otherwise, <see langword="false" />.</returns>
	public bool IsNested => false;

	/// <summary>Gets the type that declares the current nested type or generic type parameter.</summary>
	/// <returns>A <see cref="T:System.Type" /> object representing the enclosing type, if the current type is a nested type; or the generic type definition, if the current type is a type parameter of a generic type; or the type that declares the generic method, if the current type is a type parameter of a generic method; otherwise, <see langword="null" />.</returns>
	public override Type DeclaringType => null;

	/// <summary>Gets a <see cref="T:System.Reflection.MethodBase" /> that represents the declaring method, if the current <see cref="T:System.Type" /> represents a type parameter of a generic method.</summary>
	/// <returns>If the current <see cref="T:System.Type" /> represents a type parameter of a generic method, a <see cref="T:System.Reflection.MethodBase" /> that represents declaring method; otherwise, <see langword="null" />.</returns>
	public virtual MethodBase DeclaringMethod => null;

	/// <summary>Gets the class object that was used to obtain this member.</summary>
	/// <returns>The <see langword="Type" /> object through which this <see cref="T:System.Type" /> object was obtained.</returns>
	public override Type ReflectedType => null;

	/// <summary>Indicates the type provided by the common language runtime that represents this type.</summary>
	/// <returns>The underlying system type for the <see cref="T:System.Type" />.</returns>
	public abstract Type UnderlyingSystemType { get; }

	/// <summary>Gets a value that indicates whether the type is an array.</summary>
	/// <returns>
	///   <see langword="true" /> if the current type is an array; otherwise, <see langword="false" />.</returns>
	public bool IsArray => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is passed by reference.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is passed by reference; otherwise, <see langword="false" />.</returns>
	public bool IsByRef => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a pointer.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is a pointer; otherwise, <see langword="false" />.</returns>
	public bool IsPointer => false;

	/// <summary>Gets a value that indicates whether this object represents a constructed generic type. You can create instances of a constructed generic type.</summary>
	/// <returns>
	///   <see langword="true" /> if this object represents a constructed generic type; otherwise, <see langword="false" />.</returns>
	public virtual bool IsConstructedGenericType => false;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> represents a type parameter in the definition of a generic type or method.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> object represents a type parameter of a generic type definition or generic method definition; otherwise, <see langword="false" />.</returns>
	public virtual bool IsGenericParameter => false;

	public virtual bool IsGenericMethodParameter => false;

	/// <summary>Gets a value indicating whether the current type is a generic type.</summary>
	/// <returns>
	///   <see langword="true" /> if the current type is a generic type; otherwise, <see langword="false" />.</returns>
	public virtual bool IsGenericType => false;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> represents a generic type definition, from which other generic types can be constructed.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> object represents a generic type definition; otherwise, <see langword="false" />.</returns>
	public virtual bool IsGenericTypeDefinition => false;

	public virtual bool IsSZArray => false;

	public virtual bool IsVariableBoundArray => false;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> encompasses or refers to another type; that is, whether the current <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference; otherwise, <see langword="false" />.</returns>
	public bool HasElementType => false;

	/// <summary>Gets an array of the generic type arguments for this type.</summary>
	/// <returns>An array of the generic type arguments for this type.</returns>
	public virtual Type[] GenericTypeArguments => null;

	/// <summary>Gets the position of the type parameter in the type parameter list of the generic type or method that declared the parameter, when the <see cref="T:System.Type" /> object represents a type parameter of a generic type or a generic method.</summary>
	/// <returns>The position of a type parameter in the type parameter list of the generic type or method that defines the parameter. Position numbers begin at 0.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current type does not represent a type parameter. That is, <see cref="P:System.Type.IsGenericParameter" /> returns <see langword="false" />.</exception>
	public virtual int GenericParameterPosition => 0;

	/// <summary>Gets a combination of <see cref="T:System.Reflection.GenericParameterAttributes" /> flags that describe the covariance and special constraints of the current generic type parameter.</summary>
	/// <returns>A bitwise combination of <see cref="T:System.Reflection.GenericParameterAttributes" /> values that describes the covariance and special constraints of the current generic type parameter.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Type" /> object is not a generic type parameter. That is, the <see cref="P:System.Type.IsGenericParameter" /> property returns <see langword="false" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
	public virtual GenericParameterAttributes GenericParameterAttributes => default(GenericParameterAttributes);

	/// <summary>Gets the attributes associated with the <see cref="T:System.Type" />.</summary>
	/// <returns>A <see cref="T:System.Reflection.TypeAttributes" /> object representing the attribute set of the <see cref="T:System.Type" />, unless the <see cref="T:System.Type" /> represents a generic type parameter, in which case the value is unspecified.</returns>
	public TypeAttributes Attributes => default(TypeAttributes);

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is abstract and must be overridden.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is abstract; otherwise, <see langword="false" />.</returns>
	public bool IsAbstract => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is declared sealed.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is declared sealed; otherwise, <see langword="false" />.</returns>
	public bool IsSealed => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a class or a delegate; that is, not a value type or interface.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is a class; otherwise, <see langword="false" />.</returns>
	public bool IsClass => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is nested and visible only within its own assembly.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is nested and visible only within its own assembly; otherwise, <see langword="false" />.</returns>
	public bool IsNestedAssembly => false;

	/// <summary>Gets a value indicating whether a class is nested and declared public.</summary>
	/// <returns>
	///   <see langword="true" /> if the class is nested and declared public; otherwise, <see langword="false" />.</returns>
	public bool IsNestedPublic => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is not declared public.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is not declared public and is not a nested type; otherwise, <see langword="false" />.</returns>
	public bool IsNotPublic => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is declared public.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is declared public and is not a nested type; otherwise, <see langword="false" />.</returns>
	public bool IsPublic => false;

	/// <summary>Gets a value indicating whether the fields of the current type are laid out at explicitly specified offsets.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="P:System.Type.Attributes" /> property of the current type includes <see cref="F:System.Reflection.TypeAttributes.ExplicitLayout" />; otherwise, <see langword="false" />.</returns>
	public bool IsExplicitLayout => false;

	/// <summary>Gets a value indicating whether the fields of the current type are laid out sequentially, in the order that they were defined or emitted to the metadata.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="P:System.Type.Attributes" /> property of the current type includes <see cref="F:System.Reflection.TypeAttributes.SequentialLayout" />; otherwise, <see langword="false" />.</returns>
	public bool IsLayoutSequential => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a COM object.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is a COM object; otherwise, <see langword="false" />.</returns>
	public bool IsCOMObject => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> can be hosted in a context.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> can be hosted in a context; otherwise, <see langword="false" />.</returns>
	public bool IsContextful => false;

	public virtual bool IsCollectible => false;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> represents an enumeration.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Type" /> represents an enumeration; otherwise, <see langword="false" />.</returns>
	public virtual bool IsEnum => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is marshaled by reference.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is marshaled by reference; otherwise, <see langword="false" />.</returns>
	public bool IsMarshalByRef => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is one of the primitive types.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is one of the primitive types; otherwise, <see langword="false" />.</returns>
	public bool IsPrimitive => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a value type.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is a value type; otherwise, <see langword="false" />.</returns>
	public bool IsValueType => false;

	public virtual bool IsSignatureType => false;

	/// <summary>Gets the handle for the current <see cref="T:System.Type" />.</summary>
	/// <returns>The handle for the current <see cref="T:System.Type" />.</returns>
	/// <exception cref="T:System.NotSupportedException">The .NET Compact Framework does not currently support this property.</exception>
	public virtual RuntimeTypeHandle TypeHandle => default(RuntimeTypeHandle);

	/// <summary>Gets the type from which the current <see cref="T:System.Type" /> directly inherits.</summary>
	/// <returns>The <see cref="T:System.Type" /> from which the current <see cref="T:System.Type" /> directly inherits, or <see langword="null" /> if the current <see langword="Type" /> represents the <see cref="T:System.Object" /> class or an interface.</returns>
	public abstract Type BaseType { get; }

	/// <summary>Gets a reference to the default binder, which implements internal rules for selecting the appropriate members to be called by <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
	/// <returns>A reference to the default binder used by the system.</returns>
	public static Binder DefaultBinder => null;

	internal virtual bool IsSzArray => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is an interface; that is, not a class or a value type.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is an interface; otherwise, <see langword="false" />.</returns>
	public bool IsInterface => false;

	internal string FullNameOrDefault => null;

	internal string InternalNameIfAvailable => null;

	internal string NameOrDefault => null;

	/// <summary>Returns a value that indicates whether the specified value exists in the current enumeration type.</summary>
	/// <param name="value">The value to be tested.</param>
	/// <returns>
	///   <see langword="true" /> if the specified value is a member of the current enumeration type; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="value" /> is of a type that cannot be the underlying type of an enumeration.</exception>
	public virtual bool IsEnumDefined(object value)
	{
		return false;
	}

	/// <summary>Returns the name of the constant that has the specified value, for the current enumeration type.</summary>
	/// <param name="value">The value whose name is to be retrieved.</param>
	/// <returns>The name of the member of the current enumeration type that has the specified value, or <see langword="null" /> if no such constant is found.</returns>
	/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.  
	///  -or-  
	///  <paramref name="value" /> is neither of the current type nor does it have the same underlying type as the current type.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	public virtual string GetEnumName(object value)
	{
		return null;
	}

	/// <summary>Returns the names of the members of the current enumeration type.</summary>
	/// <returns>An array that contains the names of the members of the enumeration.</returns>
	/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.</exception>
	public virtual string[] GetEnumNames()
	{
		return null;
	}

	private Array GetEnumRawConstantValues()
	{
		return null;
	}

	private void GetEnumData(out string[] enumNames, out Array enumValues)
	{
		enumNames = null;
		enumValues = null;
	}

	private static int BinarySearch(Array array, object value)
	{
		return 0;
	}

	internal static bool IsIntegerType(Type t)
	{
		return false;
	}

	internal Type GetRootElementType()
	{
		return null;
	}

	/// <summary>Determines whether the current <see cref="T:System.Type" /> derives from the specified <see cref="T:System.Type" />.</summary>
	/// <param name="c">The type to compare with the current type.</param>
	/// <returns>
	///   <see langword="true" /> if the current <see langword="Type" /> derives from <paramref name="c" />; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="c" /> and the current <see langword="Type" /> are equal.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="c" /> is <see langword="null" />.</exception>
	[ComVisible(true)]
	public virtual bool IsSubclassOf(Type c)
	{
		return false;
	}

	/// <summary>Determines whether an instance of a specified type can be assigned to an instance of the current type.</summary>
	/// <param name="c">The type to compare with the current type.</param>
	/// <returns>
	///   <see langword="true" /> if any of the following conditions is true:  
	///
	/// <paramref name="c" /> and the current instance represent the same type.  
	///
	/// <paramref name="c" /> is derived either directly or indirectly from the current instance. <paramref name="c" /> is derived directly from the current instance if it inherits from the current instance; <paramref name="c" /> is derived indirectly from the current instance if it inherits from a succession of one or more classes that inherit from the current instance.  
	///
	/// The current instance is an interface that <paramref name="c" /> implements.  
	///
	/// <paramref name="c" /> is a generic type parameter, and the current instance represents one of the constraints of <paramref name="c" />.  
	///  In the following example, the current instance is a <see cref="T:System.Type" /> object that represents the <see cref="T:System.IO.Stream" /> class. GenericWithConstraint is a generic type whose generic type parameter must be of type    <see cref="T:System.IO.Stream" />. Passing its generic type parameter to the <see cref="M:System.Type.IsAssignableFrom(System.Type)" /> indicates that  an instance of the generic type parameter can be assigned to an <see cref="T:System.IO.Stream" /> object.  
	/// using System;
	/// using System.IO;
	///
	/// public class Example
	/// {
	///    public static void Main()
	///    {
	/// Type t = typeof(Stream);
	/// Type genericT = typeof(GenericWithConstraint&lt;&gt;);
	/// Type genericParam = genericT.GetGenericArguments()[0];
	/// Console.WriteLine(t.IsAssignableFrom(genericParam));  
	/// // Displays True.
	///    }
	/// }
	///
	/// public class GenericWithConstraint&lt;T&gt; where T : Stream
	/// {}
	/// Imports System.IO
	///
	/// Module Example
	///    Public Sub Main()
	/// Dim t As Type = GetType(Stream)
	/// Dim genericT As Type = GetType(GenericWithConstraint(Of ))
	/// Dim genericParam As Type = genericT.GetGenericArguments()(0)
	/// Console.WriteLine(t.IsAssignableFrom(genericParam))  
	/// ' Displays True.
	///    End Sub
	/// End Module
	///
	/// Public Class GenericWithConstraint(Of T As Stream)
	/// End Class
	///
	/// <paramref name="c" /> represents a value type, and the current instance represents Nullable&lt;c&gt; (Nullable(Of c) in Visual Basic).  
	///
	///
	///  <see langword="false" /> if none of these conditions are true, or if <paramref name="c" /> is <see langword="null" />.</returns>
	public virtual bool IsAssignableFrom(Type c)
	{
		return false;
	}

	internal bool ImplementInterface(Type ifaceType)
	{
		return false;
	}

	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria)
	{
		return false;
	}

	private static bool FilterNameImpl(MemberInfo m, object filterCriteria)
	{
		return false;
	}

	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria)
	{
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Type" /> class.</summary>
	protected Type()
	{
	}

	/// <summary>Gets the current <see cref="T:System.Type" />.</summary>
	/// <returns>The current <see cref="T:System.Type" />.</returns>
	/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception.</exception>
	public new Type GetType()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsArray" /> property and determines whether the <see cref="T:System.Type" /> is an array.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is an array; otherwise, <see langword="false" />.</returns>
	protected abstract bool IsArrayImpl();

	/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsByRef" /> property and determines whether the <see cref="T:System.Type" /> is passed by reference.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is passed by reference; otherwise, <see langword="false" />.</returns>
	protected abstract bool IsByRefImpl();

	/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsPointer" /> property and determines whether the <see cref="T:System.Type" /> is a pointer.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is a pointer; otherwise, <see langword="false" />.</returns>
	protected abstract bool IsPointerImpl();

	/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.HasElementType" /> property and determines whether the current <see cref="T:System.Type" /> encompasses or refers to another type; that is, whether the current <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference; otherwise, <see langword="false" />.</returns>
	protected abstract bool HasElementTypeImpl();

	/// <summary>When overridden in a derived class, returns the <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer or reference type.</summary>
	/// <returns>The <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer, or reference type, or <see langword="null" /> if the current <see cref="T:System.Type" /> is not an array or a pointer, or is not passed by reference, or represents a generic type or a type parameter in the definition of a generic type or generic method.</returns>
	public abstract Type GetElementType();

	/// <summary>Gets the number of dimensions in an array.</summary>
	/// <returns>An integer that contains the number of dimensions in the current type.</returns>
	/// <exception cref="T:System.NotSupportedException">The functionality of this method is unsupported in the base class and must be implemented in a derived class instead.</exception>
	/// <exception cref="T:System.ArgumentException">The current type is not an array.</exception>
	public virtual int GetArrayRank()
	{
		return 0;
	}

	/// <summary>Returns a <see cref="T:System.Type" /> object that represents a generic type definition from which the current generic type can be constructed.</summary>
	/// <returns>A <see cref="T:System.Type" /> object representing a generic type from which the current type can be constructed.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current type is not a generic type.  That is, <see cref="P:System.Type.IsGenericType" /> returns <see langword="false" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
	public virtual Type GetGenericTypeDefinition()
	{
		return null;
	}

	/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a closed generic type or the type parameters of a generic type definition.</summary>
	/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic type. Returns an empty array if the current type is not a generic type.</returns>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
	public virtual Type[] GetGenericArguments()
	{
		return null;
	}

	/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the constraints on the current generic type parameter.</summary>
	/// <returns>An array of <see cref="T:System.Type" /> objects that represent the constraints on the current generic type parameter.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Type" /> object is not a generic type parameter. That is, the <see cref="P:System.Type.IsGenericParameter" /> property returns <see langword="false" />.</exception>
	public virtual Type[] GetGenericParameterConstraints()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.Attributes" /> property and gets a bitmask indicating the attributes associated with the <see cref="T:System.Type" />.</summary>
	/// <returns>A <see cref="T:System.Reflection.TypeAttributes" /> object representing the attribute set of the <see cref="T:System.Type" />.</returns>
	protected abstract TypeAttributes GetAttributeFlagsImpl();

	/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsCOMObject" /> property and determines whether the <see cref="T:System.Type" /> is a COM object.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is a COM object; otherwise, <see langword="false" />.</returns>
	protected abstract bool IsCOMObjectImpl();

	/// <summary>Implements the <see cref="P:System.Type.IsContextful" /> property and determines whether the <see cref="T:System.Type" /> can be hosted in a context.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> can be hosted in a context; otherwise, <see langword="false" />.</returns>
	protected virtual bool IsContextfulImpl()
	{
		return false;
	}

	/// <summary>Implements the <see cref="P:System.Type.IsMarshalByRef" /> property and determines whether the <see cref="T:System.Type" /> is marshaled by reference.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is marshaled by reference; otherwise, <see langword="false" />.</returns>
	protected virtual bool IsMarshalByRefImpl()
	{
		return false;
	}

	/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsPrimitive" /> property and determines whether the <see cref="T:System.Type" /> is one of the primitive types.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is one of the primitive types; otherwise, <see langword="false" />.</returns>
	protected abstract bool IsPrimitiveImpl();

	/// <summary>Implements the <see cref="P:System.Type.IsValueType" /> property and determines whether the <see cref="T:System.Type" /> is a value type; that is, not a class or an interface.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Type" /> is a value type; otherwise, <see langword="false" />.</returns>
	protected virtual bool IsValueTypeImpl()
	{
		return false;
	}

	/// <summary>Searches for a public instance constructor whose parameters match the types in the specified array.</summary>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the desired constructor.  
	///  -or-  
	///  An empty array of <see cref="T:System.Type" /> objects, to get a constructor that takes no parameters. Such an empty array is provided by the <see langword="static" /> field <see cref="F:System.Type.EmptyTypes" />.</param>
	/// <returns>An object representing the public instance constructor whose parameters match the types in the parameter type array, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.</exception>
	[ComVisible(true)]
	public ConstructorInfo GetConstructor(Type[] types)
	{
		return null;
	}

	/// <summary>Searches for a constructor whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters.  
	///  -or-  
	///  <see cref="F:System.Type.EmptyTypes" />.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the parameter type array. The default binder does not process this parameter.</param>
	/// <returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the constructor that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.  
	/// -or-  
	/// <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length.</exception>
	[ComVisible(true)]
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Searches for a constructor whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and the stack is cleaned up.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter.</param>
	/// <returns>An object representing the constructor that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.  
	/// -or-  
	/// <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length.</exception>
	[ComVisible(true)]
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for a constructor whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and the stack is cleaned up.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter.</param>
	/// <returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the constructor that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.  
	/// -or-  
	/// <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length.</exception>
	/// <exception cref="T:System.NotSupportedException">The current type is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> or <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	/// <summary>Returns all the public constructors defined for the current <see cref="T:System.Type" />.</summary>
	/// <returns>An array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing all the public instance constructors defined for the current <see cref="T:System.Type" />, but not including the type initializer (static constructor). If no public instance constructors are defined for the current <see cref="T:System.Type" />, or if the current <see cref="T:System.Type" /> represents a type parameter in the definition of a generic type or generic method, an empty array of type <see cref="T:System.Reflection.ConstructorInfo" /> is returned.</returns>
	[ComVisible(true)]
	public ConstructorInfo[] GetConstructors()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for the constructors defined for the current <see cref="T:System.Type" />, using the specified <see langword="BindingFlags" />.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing all constructors defined for the current <see cref="T:System.Type" /> that match the specified binding constraints, including the type initializer if it is defined. Returns an empty array of type <see cref="T:System.Reflection.ConstructorInfo" /> if no constructors are defined for the current <see cref="T:System.Type" />, if none of the defined constructors match the binding constraints, or if the current <see cref="T:System.Type" /> represents a type parameter in the definition of a generic type or generic method.</returns>
	[ComVisible(true)]
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	/// <summary>Returns the <see cref="T:System.Reflection.EventInfo" /> object representing the specified public event.</summary>
	/// <param name="name">The string containing the name of an event that is declared or inherited by the current <see cref="T:System.Type" />.</param>
	/// <returns>The object representing the specified public event that is declared or inherited by the current <see cref="T:System.Type" />, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public EventInfo GetEvent(string name)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, returns the <see cref="T:System.Reflection.EventInfo" /> object representing the specified event, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of an event which is declared or inherited by the current <see cref="T:System.Type" />.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>The object representing the specified event that is declared or inherited by the current <see cref="T:System.Type" />, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	/// <summary>When overridden in a derived class, searches for events that are declared or inherited by the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An array of <see cref="T:System.Reflection.EventInfo" /> objects representing all events that are declared or inherited by the current <see cref="T:System.Type" /> that match the specified binding constraints.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.EventInfo" />, if the current <see cref="T:System.Type" /> does not have events, or if none of the events match the binding constraints.</returns>
	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);

	/// <summary>Searches for the public field with the specified name.</summary>
	/// <param name="name">The string containing the name of the data field to get.</param>
	/// <returns>An object representing the public field with the specified name, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">This <see cref="T:System.Type" /> object is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> whose <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method has not yet been called.</exception>
	public FieldInfo GetField(string name)
	{
		return null;
	}

	/// <summary>Searches for the specified field, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the data field to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An object representing the field that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	/// <summary>Returns all the public fields of the current <see cref="T:System.Type" />.</summary>
	/// <returns>An array of <see cref="T:System.Reflection.FieldInfo" /> objects representing all the public fields defined for the current <see cref="T:System.Type" />.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.FieldInfo" />, if no public fields are defined for the current <see cref="T:System.Type" />.</returns>
	public FieldInfo[] GetFields()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for the fields defined for the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An array of <see cref="T:System.Reflection.FieldInfo" /> objects representing all fields defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.FieldInfo" />, if no fields are defined for the current <see cref="T:System.Type" />, or if none of the defined fields match the binding constraints.</returns>
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	/// <summary>Searches for the public members with the specified name.</summary>
	/// <param name="name">The string containing the name of the public members to get.</param>
	/// <returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public MemberInfo[] GetMember(string name)
	{
		return null;
	}

	/// <summary>Searches for the specified members, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the members to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return an empty array.</param>
	/// <returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Searches for the specified members of the specified member type, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the members to get.</param>
	/// <param name="type">The value to search for.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return an empty array.</param>
	/// <returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">A derived class must provide an implementation.</exception>
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for the members defined for the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero (<see cref="F:System.Reflection.BindingFlags.Default" />), to return an empty array.</param>
	/// <returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing all members defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.MemberInfo" />, if no members are defined for the current <see cref="T:System.Type" />, or if none of the defined members match the binding constraints.</returns>
	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);

	/// <summary>Searches for the public method with the specified name.</summary>
	/// <param name="name">The string containing the name of the public method to get.</param>
	/// <returns>An object that represents the public method with the specified name, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public MethodInfo GetMethod(string name)
	{
		return null;
	}

	/// <summary>Searches for the specified method, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the method to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Searches for the specified public method whose parameters match the specified argument types.</summary>
	/// <param name="name">The string containing the name of the public method to get.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.  
	///  -or-  
	///  An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters.</param>
	/// <returns>An object representing the public method whose parameters match the specified argument types, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and specified parameters.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.</exception>
	public MethodInfo GetMethod(string name, Type[] types)
	{
		return null;
	}

	/// <summary>Searches for the specified public method whose parameters match the specified argument types and modifiers.</summary>
	/// <param name="name">The string containing the name of the public method to get.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.  
	///  -or-  
	///  An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. To be only used when calling through COM interop, and only parameters that are passed by reference are handled. The default binder does not process this parameter.</param>
	/// <returns>An object representing the public method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and specified parameters.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.</exception>
	public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the method to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.  
	///  -or-  
	///  An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. To be only used when calling through COM interop, and only parameters that are passed by reference are handled. The default binder does not process this parameter.</param>
	/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.</exception>
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
	/// <param name="name">The string containing the name of the method to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and how the stack is cleaned up.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.  
	///  -or-  
	///  An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. To be only used when calling through COM interop, and only parameters that are passed by reference are handled. The default binder does not process this parameter.</param>
	/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.</exception>
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
	/// <param name="name">The string containing the name of the method to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and what process cleans up the stack.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a method that takes no parameters.  
	///  -or-  
	///  <see langword="null" />. If <paramref name="types" /> is <see langword="null" />, arguments are not matched.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter.</param>
	/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.  
	/// -or-  
	/// <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length.</exception>
	/// <exception cref="T:System.NotSupportedException">The current type is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> or <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	/// <summary>Returns all the public methods of the current <see cref="T:System.Type" />.</summary>
	/// <returns>An array of <see cref="T:System.Reflection.MethodInfo" /> objects representing all the public methods defined for the current <see cref="T:System.Type" />.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.MethodInfo" />, if no public methods are defined for the current <see cref="T:System.Type" />.</returns>
	public MethodInfo[] GetMethods()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for the methods defined for the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An array of <see cref="T:System.Reflection.MethodInfo" /> objects representing all methods defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.MethodInfo" />, if no methods are defined for the current <see cref="T:System.Type" />, or if none of the defined methods match the binding constraints.</returns>
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	/// <summary>When overridden in a derived class, searches for the specified nested type, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the nested type to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An object representing the nested type that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	/// <summary>Searches for the public property with the specified name.</summary>
	/// <param name="name">The string containing the name of the public property to get.</param>
	/// <returns>An object representing the public property with the specified name, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public PropertyInfo GetProperty(string name)
	{
		return null;
	}

	/// <summary>Searches for the specified property, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the property to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An object representing the property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified binding constraints.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Searches for the public property with the specified name and return type.</summary>
	/// <param name="name">The string containing the name of the public property to get.</param>
	/// <param name="returnType">The return type of the property.</param>
	/// <returns>An object representing the public property with the specified name, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />, or <paramref name="returnType" /> is <see langword="null" />.</exception>
	public PropertyInfo GetProperty(string name, Type returnType)
	{
		return null;
	}

	/// <summary>Searches for the specified public property whose parameters match the specified argument types.</summary>
	/// <param name="name">The string containing the name of the public property to get.</param>
	/// <param name="returnType">The return type of the property.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed.</param>
	/// <returns>An object representing the public property whose parameters match the specified argument types, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified argument types.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.</exception>
	/// <exception cref="T:System.NullReferenceException">An element of <paramref name="types" /> is <see langword="null" />.</exception>
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types)
	{
		return null;
	}

	/// <summary>Searches for the specified public property whose parameters match the specified argument types and modifiers.</summary>
	/// <param name="name">The string containing the name of the public property to get.</param>
	/// <param name="returnType">The return type of the property.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter.</param>
	/// <returns>An object representing the public property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified argument types and modifiers.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.  
	/// -or-  
	/// <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length.</exception>
	/// <exception cref="T:System.NullReferenceException">An element of <paramref name="types" /> is <see langword="null" />.</exception>
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Searches for the specified property whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the property to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="returnType">The return type of the property.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter.</param>
	/// <returns>An object representing the property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified binding constraints.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.  
	/// -or-  
	/// <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length.</exception>
	/// <exception cref="T:System.NullReferenceException">An element of <paramref name="types" /> is <see langword="null" />.</exception>
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for the specified property whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
	/// <param name="name">The string containing the name of the property to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded member, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />.</param>
	/// <param name="returnType">The return type of the property.</param>
	/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.  
	///  -or-  
	///  An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter.</param>
	/// <returns>An object representing the property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified binding constraints.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="types" /> is <see langword="null" />.  
	/// -or-  
	/// One of the elements in <paramref name="types" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="types" /> is multidimensional.  
	/// -or-  
	/// <paramref name="modifiers" /> is multidimensional.  
	/// -or-  
	/// <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length.</exception>
	/// <exception cref="T:System.NotSupportedException">The current type is a <see cref="T:System.Reflection.Emit.TypeBuilder" />, <see cref="T:System.Reflection.Emit.EnumBuilder" />, or <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	/// <summary>Returns all the public properties of the current <see cref="T:System.Type" />.</summary>
	/// <returns>An array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing all public properties of the current <see cref="T:System.Type" />.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.PropertyInfo" />, if the current <see cref="T:System.Type" /> does not have public properties.</returns>
	public PropertyInfo[] GetProperties()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, searches for the properties of the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to return <see langword="null" />.</param>
	/// <returns>An array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing all properties of the current <see cref="T:System.Type" /> that match the specified binding constraints.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Reflection.PropertyInfo" />, if the current <see cref="T:System.Type" /> does not have properties, or if none of the properties match the binding constraints.</returns>
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	/// <summary>Gets the handle for the <see cref="T:System.Type" /> of a specified object.</summary>
	/// <param name="o">The object for which to get the type handle.</param>
	/// <returns>The handle for the <see cref="T:System.Type" /> of the specified <see cref="T:System.Object" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="o" /> is <see langword="null" />.</exception>
	public static RuntimeTypeHandle GetTypeHandle(object o)
	{
		return default(RuntimeTypeHandle);
	}

	/// <summary>Gets the underlying type code of the specified <see cref="T:System.Type" />.</summary>
	/// <param name="type">The type whose underlying type code to get.</param>
	/// <returns>The code of the underlying type, or <see cref="F:System.TypeCode.Empty" /> if <paramref name="type" /> is <see langword="null" />.</returns>
	public static TypeCode GetTypeCode(Type type)
	{
		return default(TypeCode);
	}

	/// <summary>Returns the underlying type code of this <see cref="T:System.Type" /> instance.</summary>
	/// <returns>The type code of the underlying type.</returns>
	protected virtual TypeCode GetTypeCodeImpl()
	{
		return default(TypeCode);
	}

	/// <summary>When overridden in a derived class, invokes the specified member, using the specified binding constraints and matching the specified argument list, modifiers and culture.</summary>
	/// <param name="name">The string containing the name of the constructor, method, property, or field member to invoke.  
	///  -or-  
	///  An empty string ("") to invoke the default member.  
	///  -or-  
	///  For <see langword="IDispatch" /> members, a string representing the DispID, for example "[DispID=3]".</param>
	/// <param name="invokeAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted. The access can be one of the <see langword="BindingFlags" /> such as <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" />, and so on. The type of lookup need not be specified. If the type of lookup is omitted, <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" /> | <see langword="BindingFlags.Static" /> are used.</param>
	/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.  
	///  -or-  
	///  A null reference (Nothing in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. Note that explicitly defining a <see cref="T:System.Reflection.Binder" /> object may be required for successfully invoking method overloads with variable arguments.</param>
	/// <param name="target">The object on which to invoke the specified member.</param>
	/// <param name="args">An array containing the arguments to pass to the member to invoke.</param>
	/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="args" /> array. A parameter's associated attributes are stored in the member's signature.  
	///  The default binder processes this parameter only when calling a COM component.</param>
	/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object representing the globalization locale to use, which may be necessary for locale-specific conversions, such as converting a numeric String to a Double.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic) to use the current thread's <see cref="T:System.Globalization.CultureInfo" />.</param>
	/// <param name="namedParameters">An array containing the names of the parameters to which the values in the <paramref name="args" /> array are passed.</param>
	/// <returns>An object representing the return value of the invoked member.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="invokeAttr" /> does not contain <see langword="CreateInstance" /> and <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="args" /> and <paramref name="modifiers" /> do not have the same length.  
	/// -or-  
	/// <paramref name="invokeAttr" /> is not a valid <see cref="T:System.Reflection.BindingFlags" /> attribute.  
	/// -or-  
	/// <paramref name="invokeAttr" /> does not contain one of the following binding flags: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />.  
	/// -or-  
	/// <paramref name="invokeAttr" /> contains <see langword="CreateInstance" /> combined with <see langword="InvokeMethod" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />.  
	/// -or-  
	/// <paramref name="invokeAttr" /> contains both <see langword="GetField" /> and <see langword="SetField" />.  
	/// -or-  
	/// <paramref name="invokeAttr" /> contains both <see langword="GetProperty" /> and <see langword="SetProperty" />.  
	/// -or-  
	/// <paramref name="invokeAttr" /> contains <see langword="InvokeMethod" /> combined with <see langword="SetField" /> or <see langword="SetProperty" />.  
	/// -or-  
	/// <paramref name="invokeAttr" /> contains <see langword="SetField" /> and <paramref name="args" /> has more than one element.  
	/// -or-  
	/// The named parameter array is larger than the argument array.  
	/// -or-  
	/// This method is called on a COM object and one of the following binding flags was not passed in: <see langword="BindingFlags.InvokeMethod" />, <see langword="BindingFlags.GetProperty" />, <see langword="BindingFlags.SetProperty" />, <see langword="BindingFlags.PutDispProperty" />, or <see langword="BindingFlags.PutRefDispProperty" />.  
	/// -or-  
	/// One of the named parameter arrays contains a string that is <see langword="null" />.</exception>
	/// <exception cref="T:System.MethodAccessException">The specified member is a class initializer.</exception>
	/// <exception cref="T:System.MissingFieldException">The field or property cannot be found.</exception>
	/// <exception cref="T:System.MissingMethodException">No method can be found that matches the arguments in <paramref name="args" />.  
	///  -or-  
	///  No member can be found that has the argument names supplied in <paramref name="namedParameters" />.  
	///  -or-  
	///  The current <see cref="T:System.Type" /> object represents a type that contains open type parameters, that is, <see cref="P:System.Type.ContainsGenericParameters" /> returns <see langword="true" />.</exception>
	/// <exception cref="T:System.Reflection.TargetException">The specified member cannot be invoked on <paramref name="target" />.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method matches the binding criteria.</exception>
	/// <exception cref="T:System.InvalidOperationException">The method represented by <paramref name="name" /> has one or more unspecified generic type parameters. That is, the method's <see cref="P:System.Reflection.MethodInfo.ContainsGenericParameters" /> property returns <see langword="true" />.</exception>
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	/// <summary>When overridden in a derived class, gets all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.</summary>
	/// <returns>An array of <see cref="T:System.Type" /> objects representing all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.  
	///  -or-  
	///  An empty array of type <see cref="T:System.Type" />, if no interfaces are implemented or inherited by the current <see cref="T:System.Type" />.</returns>
	/// <exception cref="T:System.Reflection.TargetInvocationException">A static initializer is invoked and throws an exception.</exception>
	public abstract Type[] GetInterfaces();

	/// <summary>Determines whether the specified object is an instance of the current <see cref="T:System.Type" />.</summary>
	/// <param name="o">The object to compare with the current type.</param>
	/// <returns>
	///   <see langword="true" /> if the current <see langword="Type" /> is in the inheritance hierarchy of the object represented by <paramref name="o" />, or if the current <see langword="Type" /> is an interface that <paramref name="o" /> implements. <see langword="false" /> if neither of these conditions is the case, if <paramref name="o" /> is <see langword="null" />, or if the current <see langword="Type" /> is an open generic type (that is, <see cref="P:System.Type.ContainsGenericParameters" /> returns <see langword="true" />).</returns>
	public virtual bool IsInstanceOfType(object o)
	{
		return false;
	}

	/// <summary>Determines whether two COM types have the same identity and are eligible for type equivalence.</summary>
	/// <param name="other">The COM type that is tested for equivalence with the current type.</param>
	/// <returns>
	///   <see langword="true" /> if the COM types are equivalent; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if one type is in an assembly that is loaded for execution, and the other is in an assembly that is loaded into the reflection-only context.</returns>
	public virtual bool IsEquivalentTo(Type other)
	{
		return false;
	}

	/// <summary>Returns the underlying type of the current enumeration type.</summary>
	/// <returns>The underlying type of the current enumeration.</returns>
	/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.  
	///  -or-  
	///  The enumeration type is not valid, because it contains more than one instance field.</exception>
	public virtual Type GetEnumUnderlyingType()
	{
		return null;
	}

	/// <summary>Returns an array of the values of the constants in the current enumeration type.</summary>
	/// <returns>An array that contains the values. The elements of the array are sorted by the binary values (that is, the unsigned values) of the enumeration constants.</returns>
	/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.</exception>
	public virtual Array GetEnumValues()
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Type" /> object representing a one-dimensional array of the current type, with a lower bound of zero.</summary>
	/// <returns>A <see cref="T:System.Type" /> object representing a one-dimensional array of the current type, with a lower bound of zero.</returns>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
	/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.  
	///  -or-  
	///  The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />.</exception>
	public virtual Type MakeArrayType()
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Type" /> object representing an array of the current type, with the specified number of dimensions.</summary>
	/// <param name="rank">The number of dimensions for the array. This number must be less than or equal to 32.</param>
	/// <returns>An object representing an array of the current type, with the specified number of dimensions.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="rank" /> is invalid. For example, 0 or negative.</exception>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
	/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.  
	///  -or-  
	///  The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />.  
	///  -or-  
	///  <paramref name="rank" /> is greater than 32.</exception>
	public virtual Type MakeArrayType(int rank)
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Type" /> object that represents the current type when passed as a <see langword="ref" /> parameter (<see langword="ByRef" /> parameter in Visual Basic).</summary>
	/// <returns>A <see cref="T:System.Type" /> object that represents the current type when passed as a <see langword="ref" /> parameter (<see langword="ByRef" /> parameter in Visual Basic).</returns>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
	/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.  
	///  -or-  
	///  The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />.</exception>
	public virtual Type MakeByRefType()
	{
		return null;
	}

	/// <summary>Substitutes the elements of an array of types for the type parameters of the current generic type definition and returns a <see cref="T:System.Type" /> object representing the resulting constructed type.</summary>
	/// <param name="typeArguments">An array of types to be substituted for the type parameters of the current generic type.</param>
	/// <returns>A <see cref="T:System.Type" /> representing the constructed type formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic type.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current type does not represent a generic type definition. That is, <see cref="P:System.Type.IsGenericTypeDefinition" /> returns <see langword="false" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeArguments" /> is <see langword="null" />.  
	/// -or-  
	/// Any element of <paramref name="typeArguments" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The number of elements in <paramref name="typeArguments" /> is not the same as the number of type parameters in the current generic type definition.  
	///  -or-  
	///  Any element of <paramref name="typeArguments" /> does not satisfy the constraints specified for the corresponding type parameter of the current generic type.  
	///  -or-  
	///  <paramref name="typeArguments" /> contains an element that is a pointer type (<see cref="P:System.Type.IsPointer" /> returns <see langword="true" />), a by-ref type (<see cref="P:System.Type.IsByRef" /> returns <see langword="true" />), or <see cref="T:System.Void" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
	public virtual Type MakeGenericType(params Type[] typeArguments)
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Type" /> object that represents a pointer to the current type.</summary>
	/// <returns>A <see cref="T:System.Type" /> object that represents a pointer to the current type.</returns>
	/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
	/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.  
	///  -or-  
	///  The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />.</exception>
	public virtual Type MakePointerType()
	{
		return null;
	}

	public static Type MakeGenericSignatureType(Type genericTypeDefinition, params Type[] typeArguments)
	{
		return null;
	}

	/// <summary>Returns a <see langword="String" /> representing the name of the current <see langword="Type" />.</summary>
	/// <returns>A <see cref="T:System.String" /> representing the name of the current <see cref="T:System.Type" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Determines if the underlying system type of the current <see cref="T:System.Type" /> object is the same as the underlying system type of the specified <see cref="T:System.Object" />.</summary>
	/// <param name="o">The object whose underlying system type is to be compared with the underlying system type of the current <see cref="T:System.Type" />. For the comparison to succeed, <paramref name="o" /> must be able to be cast or converted to an object of type   <see cref="T:System.Type" />.</param>
	/// <returns>
	///   <see langword="true" /> if the underlying system type of <paramref name="o" /> is the same as the underlying system type of the current <see cref="T:System.Type" />; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if: .  
	///
	/// <paramref name="o" /> is <see langword="null" />.  
	///
	/// <paramref name="o" /> cannot be cast or converted to a <see cref="T:System.Type" /> object.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>The hash code for this instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines if the underlying system type of the current <see cref="T:System.Type" /> is the same as the underlying system type of the specified <see cref="T:System.Type" />.</summary>
	/// <param name="o">The object whose underlying system type is to be compared with the underlying system type of the current <see cref="T:System.Type" />.</param>
	/// <returns>
	///   <see langword="true" /> if the underlying system type of <paramref name="o" /> is the same as the underlying system type of the current <see cref="T:System.Type" />; otherwise, <see langword="false" />.</returns>
	public virtual bool Equals(Type o)
	{
		return false;
	}

	/// <summary>Gets the type referenced by the specified type handle.</summary>
	/// <param name="handle">The object that refers to the type.</param>
	/// <returns>The type referenced by the specified <see cref="T:System.RuntimeTypeHandle" />, or <see langword="null" /> if the <see cref="P:System.RuntimeTypeHandle.Value" /> property of <paramref name="handle" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception.</exception>
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
	{
		return null;
	}

	private static Type internal_from_handle(IntPtr handle)
	{
		return null;
	}

	internal string FormatTypeName()
	{
		return null;
	}

	internal virtual string FormatTypeName(bool serialization)
	{
		return null;
	}

	/// <summary>Gets the <see cref="T:System.Type" /> with the specified name, specifying whether to throw an exception if the type is not found and whether to perform a case-sensitive search.</summary>
	/// <param name="typeName">The assembly-qualified name of the type to get. See <see cref="P:System.Type.AssemblyQualifiedName" />. If the type is in the currently executing assembly or in Mscorlib.dll, it is sufficient to supply the type name qualified by its namespace.</param>
	/// <param name="throwOnError">
	///   <see langword="true" /> to throw an exception if the type cannot be found; <see langword="false" /> to return <see langword="null" />. Specifying <see langword="false" /> also suppresses some other exception conditions, but not all of them. See the Exceptions section.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to perform a case-insensitive search for <paramref name="typeName" />, <see langword="false" /> to perform a case-sensitive search for <paramref name="typeName" />.</param>
	/// <returns>The type with the specified name. If the type is not found, the <paramref name="throwOnError" /> parameter specifies whether <see langword="null" /> is returned or an exception is thrown. In some cases, an exception is thrown regardless of the value of <paramref name="throwOnError" />. See the Exceptions section.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception.</exception>
	/// <exception cref="T:System.TypeLoadException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and the type is not found.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid characters, such as an embedded tab.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> is an empty string.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> represents an array type with an invalid size.  
	/// -or-  
	/// <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid syntax. For example, "MyType[,*,]".  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and the assembly or one of its dependencies was not found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">The assembly or one of its dependencies was found, but could not be loaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid.  
	///  -or-  
	///  Version 2.0 or later of the common language runtime is currently loaded, and the assembly was compiled with a later version.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Gets the <see cref="T:System.Type" /> with the specified name, performing a case-sensitive search and specifying whether to throw an exception if the type is not found.</summary>
	/// <param name="typeName">The assembly-qualified name of the type to get. See <see cref="P:System.Type.AssemblyQualifiedName" />. If the type is in the currently executing assembly or in Mscorlib.dll, it is sufficient to supply the type name qualified by its namespace.</param>
	/// <param name="throwOnError">
	///   <see langword="true" /> to throw an exception if the type cannot be found; <see langword="false" /> to return <see langword="null" />. Specifying <see langword="false" /> also suppresses some other exception conditions, but not all of them. See the Exceptions section.</param>
	/// <returns>The type with the specified name. If the type is not found, the <paramref name="throwOnError" /> parameter specifies whether <see langword="null" /> is returned or an exception is thrown. In some cases, an exception is thrown regardless of the value of <paramref name="throwOnError" />. See the Exceptions section.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception.</exception>
	/// <exception cref="T:System.TypeLoadException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and the type is not found.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid characters, such as an embedded tab.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> is an empty string.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> represents an array type with an invalid size.  
	/// -or-  
	/// <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid syntax. For example, "MyType[,*,]".  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and the assembly or one of its dependencies was not found.</exception>
	/// <exception cref="T:System.IO.FileLoadException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.  
	///
	///
	///
	///
	///  The assembly or one of its dependencies was found, but could not be loaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid.  
	///  -or-  
	///  Version 2.0 or later of the common language runtime is currently loaded, and the assembly was compiled with a later version.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, bool throwOnError)
	{
		return null;
	}

	/// <summary>Gets the <see cref="T:System.Type" /> with the specified name, performing a case-sensitive search.</summary>
	/// <param name="typeName">The assembly-qualified name of the type to get. See <see cref="P:System.Type.AssemblyQualifiedName" />. If the type is in the currently executing assembly or in Mscorlib.dll, it is sufficient to supply the type name qualified by its namespace.</param>
	/// <returns>The type with the specified name, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.  
	/// -or-  
	/// <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
	/// <exception cref="T:System.TypeLoadException">
	///   <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />.</exception>
	/// <exception cref="T:System.IO.FileLoadException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.  
	///
	///
	///
	///
	///  The assembly or one of its dependencies was found, but could not be loaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid.  
	///  -or-  
	///  Version 2.0 or later of the common language runtime is currently loaded, and the assembly was compiled with a later version.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName)
	{
		return null;
	}

	/// <summary>Gets the type with the specified name, specifying whether to throw an exception if the type is not found, and optionally providing custom methods to resolve the assembly and the type.</summary>
	/// <param name="typeName">The name of the type to get. If the <paramref name="typeResolver" /> parameter is provided, the type name can be any string that <paramref name="typeResolver" /> is capable of resolving. If the <paramref name="assemblyResolver" /> parameter is provided or if standard type resolution is used, <paramref name="typeName" /> must be an assembly-qualified name (see <see cref="P:System.Type.AssemblyQualifiedName" />), unless the type is in the currently executing assembly or in Mscorlib.dll, in which case it is sufficient to supply the type name qualified by its namespace.</param>
	/// <param name="assemblyResolver">A method that locates and returns the assembly that is specified in <paramref name="typeName" />. The assembly name is passed to <paramref name="assemblyResolver" /> as an <see cref="T:System.Reflection.AssemblyName" /> object. If <paramref name="typeName" /> does not contain the name of an assembly, <paramref name="assemblyResolver" /> is not called. If <paramref name="assemblyResolver" /> is not supplied, standard assembly resolution is performed.  
	///  Caution   Do not pass methods from unknown or untrusted callers. Doing so could result in elevation of privilege for malicious code. Use only methods that you provide or that you are familiar with.</param>
	/// <param name="typeResolver">A method that locates and returns the type that is specified by <paramref name="typeName" /> from the assembly that is returned by <paramref name="assemblyResolver" /> or by standard assembly resolution. If no assembly is provided, the method can provide one. The method also takes a parameter that specifies whether to perform a case-insensitive search; <see langword="false" /> is passed to that parameter.  
	///  Caution   Do not pass methods from unknown or untrusted callers.</param>
	/// <param name="throwOnError">
	///   <see langword="true" /> to throw an exception if the type cannot be found; <see langword="false" /> to return <see langword="null" />. Specifying <see langword="false" /> also suppresses some other exception conditions, but not all of them. See the Exceptions section.</param>
	/// <returns>The type with the specified name. If the type is not found, the <paramref name="throwOnError" /> parameter specifies whether <see langword="null" /> is returned or an exception is thrown. In some cases, an exception is thrown regardless of the value of <paramref name="throwOnError" />. See the Exceptions section.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception.</exception>
	/// <exception cref="T:System.TypeLoadException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and the type is not found.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid characters, such as an embedded tab.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> is an empty string.  
	/// -or-  
	/// <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> represents an array type with an invalid size.  
	/// -or-  
	/// <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />.</exception>
	/// <exception cref="T:System.ArgumentException">An error occurs when <paramref name="typeName" /> is parsed into a type name and an assembly name (for example, when the simple type name includes an unescaped special character).  
	///  -or-  
	///  <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid syntax (for example, "MyType[,*,]").  
	///  -or-  
	///  <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.  
	///  -or-  
	///  <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.  
	///  -or-  
	///  <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">
	///   <paramref name="throwOnError" /> is <see langword="true" /> and the assembly or one of its dependencies was not found.  
	/// -or-  
	/// <paramref name="typeName" /> contains an invalid assembly name.  
	/// -or-  
	/// <paramref name="typeName" /> is a valid assembly name without a type name.</exception>
	/// <exception cref="T:System.IO.FileLoadException">The assembly or one of its dependencies was found, but could not be loaded.</exception>
	/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid.  
	///  -or-  
	///  The assembly was compiled with a later version of the common language runtime than the version that is currently loaded.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
	{
		return null;
	}

	/// <summary>Indicates whether two <see cref="T:System.Type" /> objects are equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Type left, Type right)
	{
		return false;
	}

	/// <summary>Indicates whether two <see cref="T:System.Type" /> objects are not equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Type left, Type right)
	{
		return false;
	}

	internal bool IsRuntimeImplemented()
	{
		return false;
	}

	internal virtual string InternalGetNameIfAvailable(ref Type rootCauseForFailure)
	{
		return null;
	}
}
