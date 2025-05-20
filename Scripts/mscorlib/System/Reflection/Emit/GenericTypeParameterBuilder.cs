using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

/// <summary>Defines and creates generic type parameters for dynamically defined generic types and methods. This class cannot be inherited.</summary>
public sealed class GenericTypeParameterBuilder : TypeInfo
{
	/// <summary>Gets an <see cref="T:System.Reflection.Assembly" /> object representing the dynamic assembly that contains the generic type definition the current type parameter belongs to.</summary>
	/// <returns>An <see cref="T:System.Reflection.Assembly" /> object representing the dynamic assembly that contains the generic type definition the current type parameter belongs to.</returns>
	public override Assembly Assembly => null;

	/// <summary>Gets <see langword="null" /> in all cases.</summary>
	/// <returns>A null reference (<see langword="Nothing" /> in Visual Basic) in all cases.</returns>
	public override string AssemblyQualifiedName => null;

	/// <summary>Gets the base type constraint of the current generic type parameter.</summary>
	/// <returns>A <see cref="T:System.Type" /> object that represents the base type constraint of the generic type parameter, or <see langword="null" /> if the type parameter has no base type constraint.</returns>
	public override Type BaseType => null;

	/// <summary>Gets <see langword="null" /> in all cases.</summary>
	/// <returns>A null reference (<see langword="Nothing" /> in Visual Basic) in all cases.</returns>
	public override string FullName => null;

	/// <summary>Gets the dynamic module that contains the generic type parameter.</summary>
	/// <returns>A <see cref="T:System.Reflection.Module" /> object that represents the dynamic module that contains the generic type parameter.</returns>
	public override Module Module => null;

	/// <summary>Gets the name of the generic type parameter.</summary>
	/// <returns>The name of the generic type parameter.</returns>
	public override string Name => null;

	/// <summary>Gets <see langword="null" /> in all cases.</summary>
	/// <returns>A null reference (<see langword="Nothing" /> in Visual Basic) in all cases.</returns>
	public override string Namespace => null;

	/// <summary>Gets the current generic type parameter.</summary>
	/// <returns>The current <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> object.</returns>
	public override Type UnderlyingSystemType => null;

	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		return default(TypeAttributes);
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" /> in all cases.</summary>
	/// <returns>The type referred to by the current array type, pointer type, or <see langword="ByRef" /> type; or <see langword="null" /> if the current type is not an array type, is not a pointer type, and is not passed by reference.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override Type GetElementType()
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="name">Not supported.</param>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="name">Not supported.</param>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override Type[] GetInterfaces()
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="name">Not supported.</param>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="bindingAttr">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected override bool HasElementTypeImpl()
	{
		return false;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="name">Not supported.</param>
	/// <param name="invokeAttr">Not supported.</param>
	/// <param name="binder">Not supported.</param>
	/// <param name="target">Not supported.</param>
	/// <param name="args">Not supported.</param>
	/// <param name="modifiers">Not supported.</param>
	/// <param name="culture">Not supported.</param>
	/// <param name="namedParameters">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		return null;
	}

	protected override bool IsArrayImpl()
	{
		return false;
	}

	protected override bool IsByRefImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		return false;
	}

	/// <summary>Not supported for incomplete generic type parameters.</summary>
	/// <param name="attributeType">Not supported.</param>
	/// <param name="inherit">Not supported.</param>
	/// <returns>Not supported for incomplete generic type parameters.</returns>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	protected override bool IsPointerImpl()
	{
		return false;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}
}
