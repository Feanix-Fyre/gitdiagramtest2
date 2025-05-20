using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable
{
	internal IntPtr mhandle;

	private string name;

	private Type reftype;

	public override Module Module => null;

	internal BindingFlags BindingFlags => default(BindingFlags);

	private RuntimeType ReflectedTypeInternal => null;

	public override RuntimeMethodHandle MethodHandle => default(RuntimeMethodHandle);

	public override MethodAttributes Attributes => default(MethodAttributes);

	public override CallingConventions CallingConvention => default(CallingConventions);

	public override bool ContainsGenericParameters => false;

	public override Type ReflectedType => null;

	public override Type DeclaringType => null;

	public override string Name => null;

	public override bool IsSecurityCritical => false;

	public override int MetadataToken => 0;

	internal RuntimeModule GetRuntimeModule()
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

	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context)
	{
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return default(MethodImplAttributes);
	}

	public override ParameterInfo[] GetParameters()
	{
		return null;
	}

	internal override ParameterInfo[] GetParametersInternal()
	{
		return null;
	}

	internal override int GetParametersCount()
	{
		return 0;
	}

	internal object InternalInvoke(object obj, object[] parameters, out Exception exc)
	{
		exc = null;
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}

	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}

	public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
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

	public override string ToString()
	{
		return null;
	}

	private static int get_core_clr_security_level()
	{
		return 0;
	}

	internal static int get_metadata_token(RuntimeConstructorInfo method)
	{
		return 0;
	}
}
