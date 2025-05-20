using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Mono;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
internal class RuntimePropertyInfo : PropertyInfo, ISerializable
{
	private delegate object GetterAdapter(object _this);

	private delegate R Getter<T, R>(T _this);

	private delegate R StaticGetter<R>();

	internal IntPtr klass;

	internal IntPtr prop;

	private MonoPropertyInfo info;

	private PInfo cached;

	private GetterAdapter cached_getter;

	internal BindingFlags BindingFlags => default(BindingFlags);

	public override Module Module => null;

	private RuntimeType ReflectedTypeInternal => null;

	public override bool CanRead => false;

	public override bool CanWrite => false;

	public override Type PropertyType => null;

	public override Type ReflectedType => null;

	public override Type DeclaringType => null;

	public override string Name => null;

	public override int MetadataToken => 0;

	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info)
	{
	}

	internal RuntimeType GetDeclaringTypeInternal()
	{
		return null;
	}

	internal RuntimeModule GetRuntimeModule()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private string FormatNameAndSig(bool serialization)
	{
		return null;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal string SerializationToString()
	{
		return null;
	}

	private void CachePropertyInfo(PInfo flags)
	{
	}

	public override MethodInfo GetGetMethod(bool nonPublic)
	{
		return null;
	}

	public override ParameterInfo[] GetIndexParameters()
	{
		return null;
	}

	public override MethodInfo GetSetMethod(bool nonPublic)
	{
		return null;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	private static object GetterAdapterFrame<T, R>(Getter<T, R> getter, object obj)
	{
		return null;
	}

	private static object StaticGetterAdapterFrame<R>(StaticGetter<R> getter, object obj)
	{
		return null;
	}

	public override object GetValue(object obj, object[] index)
	{
		return null;
	}

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		return null;
	}

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
	}

	internal static int get_metadata_token(RuntimePropertyInfo monoProperty)
	{
		return 0;
	}

	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
	{
		return null;
	}

	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType)
	{
		return null;
	}
}
