using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System;

[Serializable]
[StructLayout((LayoutKind)0)]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable
{
	internal enum MemberListType
	{
		All = 0,
		CaseSensitive = 1,
		CaseInsensitive = 2,
		HandleToInfo = 3
	}

	private struct ListBuilder<T> where T : class
	{
		private T[] _items;

		private T _item;

		private int _count;

		private int _capacity;

		public T this[int index] => null;

		public int Count => 0;

		public ListBuilder(int capacity)
		{
			_items = null;
			_item = null;
			_count = 0;
			_capacity = 0;
		}

		public T[] ToArray()
		{
			return null;
		}

		public void CopyTo(object[] array, int index)
		{
		}

		public void Add(T item)
		{
		}
	}

	internal static readonly RuntimeType ValueType;

	internal static readonly RuntimeType EnumType;

	private static readonly RuntimeType ObjectType;

	private static readonly RuntimeType StringType;

	private static readonly RuntimeType DelegateType;

	private static Type[] s_SICtorParamTypes;

	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation;

	private const BindingFlags MemberBindingMask = (BindingFlags)255;

	private const BindingFlags InvocationMask = BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

	private const BindingFlags BinderNonCreateInstance = BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty;

	private const BindingFlags BinderGetSetProperty = BindingFlags.GetProperty | BindingFlags.SetProperty;

	private const BindingFlags BinderSetInvokeProperty = BindingFlags.InvokeMethod | BindingFlags.SetProperty;

	private const BindingFlags BinderGetSetField = BindingFlags.GetField | BindingFlags.SetField;

	private const BindingFlags BinderSetInvokeField = BindingFlags.InvokeMethod | BindingFlags.SetField;

	private const BindingFlags BinderNonFieldGetSet = (BindingFlags)16773888;

	private const BindingFlags ClassicBindingMask = BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty;

	private static RuntimeType s_typedRef;

	[NonSerialized]
	private MonoTypeInfo type_info;

	internal object GenericCache;

	private RuntimeConstructorInfo m_serializationCtor;

	private const int GenericParameterCountAny = -1;

	public override Module Module => null;

	public override Assembly Assembly => null;

	public override RuntimeTypeHandle TypeHandle => default(RuntimeTypeHandle);

	public override Type BaseType => null;

	public override Type UnderlyingSystemType => null;

	public override bool IsEnum => false;

	public override GenericParameterAttributes GenericParameterAttributes => default(GenericParameterAttributes);

	internal override bool IsSzArray => false;

	public override bool IsGenericTypeDefinition => false;

	public override bool IsGenericParameter => false;

	public override int GenericParameterPosition => 0;

	public override bool IsGenericType => false;

	public override bool IsConstructedGenericType => false;

	public override MemberTypes MemberType => default(MemberTypes);

	public override Type ReflectedType => null;

	public override int MetadataToken => 0;

	public override bool ContainsGenericParameters => false;

	public override MethodBase DeclaringMethod => null;

	public override string AssemblyQualifiedName => null;

	public override Type DeclaringType => null;

	public override string Name => null;

	public override string Namespace => null;

	public override string FullName => null;

	public override bool IsSZArray => false;

	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
	{
	}

	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters)
	{
	}

	private static void SplitName(string fullname, out string name, out string ns)
	{
		name = null;
		ns = null;
	}

	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
	{
		return default(BindingFlags);
	}

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType)
	{
		prefixLookup = default(bool);
		ignoreCase = default(bool);
		listType = default(MemberListType);
	}

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType)
	{
		ignoreCase = default(bool);
		listType = default(MemberListType);
	}

	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase)
	{
		return false;
	}

	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
	{
		return false;
	}

	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
	{
		return false;
	}

	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
	{
		return false;
	}

	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
	{
		return false;
	}

	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes)
	{
		return false;
	}

	internal RuntimeType()
	{
	}

	private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup)
	{
		return default(ListBuilder<MethodInfo>);
	}

	private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
	{
		return default(ListBuilder<ConstructorInfo>);
	}

	private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup)
	{
		return default(ListBuilder<PropertyInfo>);
	}

	private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
	{
		return default(ListBuilder<EventInfo>);
	}

	private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
	{
		return default(ListBuilder<FieldInfo>);
	}

	private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup)
	{
		return default(ListBuilder<Type>);
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return null;
	}

	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		return null;
	}

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		return null;
	}

	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		return null;
	}

	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return null;
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public override Type GetNestedType(string fullname, BindingFlags bindingAttr)
	{
		return null;
	}

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		return null;
	}

	internal RuntimeModule GetRuntimeModule()
	{
		return null;
	}

	internal RuntimeAssembly GetRuntimeAssembly()
	{
		return null;
	}

	public override bool IsInstanceOfType(object o)
	{
		return false;
	}

	public override bool IsAssignableFrom(Type c)
	{
		return false;
	}

	public override bool IsEquivalentTo(Type other)
	{
		return false;
	}

	private RuntimeType GetBaseType()
	{
		return null;
	}

	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		return default(TypeAttributes);
	}

	protected override bool IsContextfulImpl()
	{
		return false;
	}

	protected override bool IsByRefImpl()
	{
		return false;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}

	protected override bool IsPointerImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		return false;
	}

	protected override bool IsValueTypeImpl()
	{
		return false;
	}

	protected override bool HasElementTypeImpl()
	{
		return false;
	}

	protected override bool IsArrayImpl()
	{
		return false;
	}

	public override int GetArrayRank()
	{
		return 0;
	}

	public override Type GetElementType()
	{
		return null;
	}

	public override string[] GetEnumNames()
	{
		return null;
	}

	public override Array GetEnumValues()
	{
		return null;
	}

	public override Type GetEnumUnderlyingType()
	{
		return null;
	}

	public override bool IsEnumDefined(object value)
	{
		return false;
	}

	public override string GetEnumName(object value)
	{
		return null;
	}

	internal RuntimeType[] GetGenericArgumentsInternal()
	{
		return null;
	}

	public override Type[] GetGenericArguments()
	{
		return null;
	}

	public override Type MakeGenericType(params Type[] instantiation)
	{
		return null;
	}

	public override Type GetGenericTypeDefinition()
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static bool operator ==(RuntimeType left, RuntimeType right)
	{
		return false;
	}

	public static bool operator !=(RuntimeType left, RuntimeType right)
	{
		return false;
	}

	public object Clone()
	{
		return null;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	internal override string FormatTypeName(bool serialization)
	{
		return null;
	}

	private void CreateInstanceCheckThis()
	{
	}

	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark)
	{
		return null;
	}

	internal RuntimeConstructorInfo GetDefaultConstructor()
	{
		return null;
	}

	private string GetDefaultMemberName()
	{
		return null;
	}

	internal RuntimeConstructorInfo GetSerializationCtor()
	{
		return null;
	}

	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache)
	{
		return null;
	}

	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions)
	{
		return null;
	}

	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
	{
		return null;
	}

	private object TryConvertToType(object value, ref bool failed)
	{
		return null;
	}

	private static object IsConvertibleToPrimitiveType(object value, Type targetType)
	{
		return null;
	}

	private string GetCachedName(TypeNameKind kind)
	{
		return null;
	}

	private Type make_array_type(int rank)
	{
		return null;
	}

	public override Type MakeArrayType()
	{
		return null;
	}

	public override Type MakeArrayType(int rank)
	{
		return null;
	}

	private Type make_byref_type()
	{
		return null;
	}

	public override Type MakeByRefType()
	{
		return null;
	}

	private static Type MakePointerType(Type type)
	{
		return null;
	}

	public override Type MakePointerType()
	{
		return null;
	}

	public override Type[] GetGenericParameterConstraints()
	{
		return null;
	}

	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument)
	{
		return null;
	}

	private static Type MakeGenericType(Type gt, Type[] types)
	{
		return null;
	}

	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, MemberListType listType)
	{
		return (IntPtr)0;
	}

	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType)
	{
		return null;
	}

	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType)
	{
		return (IntPtr)0;
	}

	private IntPtr GetConstructors_native(BindingFlags bindingAttr)
	{
		return (IntPtr)0;
	}

	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType)
	{
		return null;
	}

	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType)
	{
		return null;
	}

	protected override TypeCode GetTypeCodeImpl()
	{
		return default(TypeCode);
	}

	private static TypeCode GetTypeCodeImplInternal(Type type)
	{
		return default(TypeCode);
	}

	public override string ToString()
	{
		return null;
	}

	private bool IsGenericCOMObjectImpl()
	{
		return false;
	}

	private static object CreateInstanceInternal(Type type)
	{
		return null;
	}

	internal string getFullName(bool full_name, bool assembly_qualified)
	{
		return null;
	}

	private Type[] GetGenericArgumentsInternal(bool runtimeArray)
	{
		return null;
	}

	private GenericParameterAttributes GetGenericParameterAttributes()
	{
		return default(GenericParameterAttributes);
	}

	private int GetGenericParameterPosition()
	{
		return 0;
	}

	private IntPtr GetEvents_native(IntPtr name, MemberListType listType)
	{
		return (IntPtr)0;
	}

	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType)
	{
		return (IntPtr)0;
	}

	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType)
	{
		return null;
	}

	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType)
	{
		return null;
	}

	public override Type[] GetInterfaces()
	{
		return null;
	}

	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType)
	{
		return (IntPtr)0;
	}

	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, MemberListType listType)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	[ComVisible(true)]
	public override bool IsSubclassOf(Type type)
	{
		return false;
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	private ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup)
	{
		return default(ListBuilder<MethodInfo>);
	}
}
