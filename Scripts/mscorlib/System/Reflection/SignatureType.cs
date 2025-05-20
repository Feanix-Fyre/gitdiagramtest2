using System.Globalization;

namespace System.Reflection;

internal abstract class SignatureType : Type
{
	public sealed override bool IsSignatureType => false;

	public abstract override bool IsSZArray { get; }

	public abstract override bool IsVariableBoundArray { get; }

	public sealed override bool IsGenericType => false;

	public abstract override bool IsGenericTypeDefinition { get; }

	public abstract override bool IsConstructedGenericType { get; }

	public abstract override bool IsGenericParameter { get; }

	public abstract override bool IsGenericMethodParameter { get; }

	public abstract override bool ContainsGenericParameters { get; }

	public sealed override MemberTypes MemberType => default(MemberTypes);

	public abstract override Type[] GenericTypeArguments { get; }

	public abstract override int GenericParameterPosition { get; }

	internal abstract SignatureType ElementType { get; }

	public sealed override Type UnderlyingSystemType => null;

	public abstract override string Name { get; }

	public abstract override string Namespace { get; }

	public sealed override string FullName => null;

	public sealed override string AssemblyQualifiedName => null;

	public sealed override Assembly Assembly => null;

	public sealed override Module Module => null;

	public sealed override Type ReflectedType => null;

	public sealed override Type BaseType => null;

	public sealed override int MetadataToken => 0;

	public sealed override Type DeclaringType => null;

	public sealed override MethodBase DeclaringMethod => null;

	public sealed override GenericParameterAttributes GenericParameterAttributes => default(GenericParameterAttributes);

	public sealed override bool IsEnum => false;

	public sealed override bool IsSerializable => false;

	public sealed override RuntimeTypeHandle TypeHandle => default(RuntimeTypeHandle);

	protected abstract override bool HasElementTypeImpl();

	protected abstract override bool IsArrayImpl();

	protected abstract override bool IsByRefImpl();

	protected abstract override bool IsPointerImpl();

	public sealed override Type MakeArrayType()
	{
		return null;
	}

	public sealed override Type MakeArrayType(int rank)
	{
		return null;
	}

	public sealed override Type MakeByRefType()
	{
		return null;
	}

	public sealed override Type MakePointerType()
	{
		return null;
	}

	public sealed override Type MakeGenericType(params Type[] typeArguments)
	{
		return null;
	}

	public sealed override Type GetElementType()
	{
		return null;
	}

	public abstract override int GetArrayRank();

	public abstract override Type GetGenericTypeDefinition();

	public abstract override Type[] GetGenericArguments();

	public abstract override string ToString();

	public sealed override Type[] GetInterfaces()
	{
		return null;
	}

	public sealed override bool IsAssignableFrom(Type c)
	{
		return false;
	}

	public sealed override Type[] GetGenericParameterConstraints()
	{
		return null;
	}

	public sealed override bool IsEnumDefined(object value)
	{
		return false;
	}

	public sealed override string GetEnumName(object value)
	{
		return null;
	}

	public sealed override string[] GetEnumNames()
	{
		return null;
	}

	public sealed override Type GetEnumUnderlyingType()
	{
		return null;
	}

	public sealed override Array GetEnumValues()
	{
		return null;
	}

	protected sealed override TypeCode GetTypeCodeImpl()
	{
		return default(TypeCode);
	}

	protected sealed override TypeAttributes GetAttributeFlagsImpl()
	{
		return default(TypeAttributes);
	}

	public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		return null;
	}

	protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		return null;
	}

	public sealed override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public sealed override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected sealed override bool IsCOMObjectImpl()
	{
		return false;
	}

	protected sealed override bool IsPrimitiveImpl()
	{
		return false;
	}

	protected sealed override bool IsContextfulImpl()
	{
		return false;
	}

	public sealed override bool IsEquivalentTo(Type other)
	{
		return false;
	}

	public sealed override bool IsInstanceOfType(object o)
	{
		return false;
	}

	protected sealed override bool IsMarshalByRefImpl()
	{
		return false;
	}

	public sealed override bool IsSubclassOf(Type c)
	{
		return false;
	}

	protected sealed override bool IsValueTypeImpl()
	{
		return false;
	}
}
