using System.Globalization;
using System.Reflection;

namespace System.Runtime.Serialization;

internal sealed class SerializationFieldInfo : FieldInfo
{
	private RuntimeFieldInfo m_field;

	private string m_serializationName;

	public override Module Module => null;

	public override int MetadataToken => 0;

	public override string Name => null;

	public override Type DeclaringType => null;

	public override Type ReflectedType => null;

	public override Type FieldType => null;

	internal RuntimeFieldInfo FieldInfo => null;

	public override RuntimeFieldHandle FieldHandle => default(RuntimeFieldHandle);

	public override FieldAttributes Attributes => default(FieldAttributes);

	internal SerializationFieldInfo(RuntimeFieldInfo field, string namePrefix)
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

	public override object GetValue(object obj)
	{
		return null;
	}

	internal object InternalGetValue(object obj)
	{
		return null;
	}

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
	}

	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
	}
}
