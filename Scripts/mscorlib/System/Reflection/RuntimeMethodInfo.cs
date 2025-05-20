using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
internal class RuntimeMethodInfo : MethodInfo, ISerializable
{
	internal IntPtr mhandle;

	private string name;

	private Type reftype;

	internal BindingFlags BindingFlags => default(BindingFlags);

	public override Module Module => null;

	private RuntimeType ReflectedTypeInternal => null;

	public override ParameterInfo ReturnParameter => null;

	public override Type ReturnType => null;

	public override int MetadataToken => 0;

	public override RuntimeMethodHandle MethodHandle => default(RuntimeMethodHandle);

	public override MethodAttributes Attributes => default(MethodAttributes);

	public override CallingConventions CallingConvention => default(CallingConventions);

	public override Type ReflectedType => null;

	public override Type DeclaringType => null;

	public override string Name => null;

	public override bool IsGenericMethodDefinition => false;

	public override bool IsGenericMethod => false;

	public override bool ContainsGenericParameters => false;

	public override bool IsSecurityCritical => false;

	internal override string FormatNameAndSig(bool serialization)
	{
		return null;
	}

	public override Delegate CreateDelegate(Type delegateType)
	{
		return null;
	}

	public override Delegate CreateDelegate(Type delegateType, object target)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

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

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle)
	{
		return null;
	}

	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType)
	{
		return null;
	}

	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle)
	{
		return null;
	}

	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck)
	{
		return null;
	}

	internal RuntimeMethodInfo()
	{
	}

	internal static string get_name(MethodBase method)
	{
		return null;
	}

	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition)
	{
		return null;
	}

	internal static int get_metadata_token(RuntimeMethodInfo method)
	{
		return 0;
	}

	public override MethodInfo GetBaseDefinition()
	{
		return null;
	}

	internal MethodInfo GetBaseMethod()
	{
		return null;
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

	[DebuggerStepThrough]
	[DebuggerHidden]
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}

	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr)
	{
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

	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName)
	{
		flags = default(PInvokeAttributes);
		entryPoint = null;
		dllName = null;
	}

	internal object[] GetPseudoCustomAttributes()
	{
		return null;
	}

	internal CustomAttributeData[] GetPseudoCustomAttributesData()
	{
		return null;
	}

	private CustomAttributeData GetDllImportAttributeData()
	{
		return null;
	}

	public override MethodInfo MakeGenericMethod(params Type[] methodInstantiation)
	{
		return null;
	}

	private MethodInfo MakeGenericMethod_impl(Type[] types)
	{
		return null;
	}

	public override Type[] GetGenericArguments()
	{
		return null;
	}

	private MethodInfo GetGenericMethodDefinition_impl()
	{
		return null;
	}

	public override MethodInfo GetGenericMethodDefinition()
	{
		return null;
	}

	private static int get_core_clr_security_level()
	{
		return 0;
	}
}
