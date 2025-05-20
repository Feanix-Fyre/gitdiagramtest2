using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection;

[Serializable]
[ComDefaultInterface(typeof(_ParameterInfo))]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
internal class RuntimeParameterInfo : ParameterInfo
{
	internal MarshalAsAttribute marshalAs;

	public override object DefaultValue => null;

	internal RuntimeParameterInfo(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs)
	{
	}

	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization)
	{
	}

	internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member)
	{
	}

	internal RuntimeParameterInfo(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
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

	internal object GetDefaultValueImpl(ParameterInfo pinfo)
	{
		return null;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	internal object[] GetPseudoCustomAttributes()
	{
		return null;
	}

	internal CustomAttributeData[] GetPseudoCustomAttributesData()
	{
		return null;
	}

	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
	{
		return null;
	}

	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
	{
		return null;
	}
}
