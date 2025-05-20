using System.Runtime.InteropServices;

namespace System.Reflection;

internal struct MonoMethodInfo
{
	private Type parent;

	private Type ret;

	internal MethodAttributes attrs;

	internal MethodImplAttributes iattrs;

	private CallingConventions callconv;

	private static void get_method_info(IntPtr handle, out MonoMethodInfo info)
	{
		info = default(MonoMethodInfo);
	}

	private static int get_method_attributes(IntPtr handle)
	{
		return 0;
	}

	internal static MonoMethodInfo GetMethodInfo(IntPtr handle)
	{
		return default(MonoMethodInfo);
	}

	internal static Type GetDeclaringType(IntPtr handle)
	{
		return null;
	}

	internal static Type GetReturnType(IntPtr handle)
	{
		return null;
	}

	internal static MethodAttributes GetAttributes(IntPtr handle)
	{
		return default(MethodAttributes);
	}

	internal static CallingConventions GetCallingConvention(IntPtr handle)
	{
		return default(CallingConventions);
	}

	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle)
	{
		return default(MethodImplAttributes);
	}

	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member)
	{
		return null;
	}

	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member)
	{
		return null;
	}

	private static MarshalAsAttribute get_retval_marshal(IntPtr handle)
	{
		return null;
	}

	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
	{
		return null;
	}
}
