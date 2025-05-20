using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
internal class RuntimeFieldInfo : RtFieldInfo, ISerializable
{
	internal IntPtr klass;

	internal RuntimeFieldHandle fhandle;

	private string name;

	private Type type;

	private FieldAttributes attrs;

	internal BindingFlags BindingFlags => default(BindingFlags);

	public override Module Module => null;

	private RuntimeType ReflectedTypeInternal => null;

	public override FieldAttributes Attributes => default(FieldAttributes);

	public override RuntimeFieldHandle FieldHandle => default(RuntimeFieldHandle);

	public override Type FieldType => null;

	public override Type ReflectedType => null;

	public override Type DeclaringType => null;

	public override string Name => null;

	public override int MetadataToken => 0;

	internal RuntimeType GetDeclaringTypeInternal()
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

	internal override object UnsafeGetValue(object obj)
	{
		return null;
	}

	internal override void CheckConsistency(object target)
	{
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public override void SetValueDirect(TypedReference obj, object value)
	{
	}

	private Type ResolveType()
	{
		return null;
	}

	private Type GetParentType(bool declaring)
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

	internal override int GetFieldOffset()
	{
		return 0;
	}

	private object GetValueInternal(object obj)
	{
		return null;
	}

	public override object GetValue(object obj)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private static void SetValueInternal(FieldInfo fi, object obj, object value)
	{
	}

	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
	}

	public override object GetRawConstantValue()
	{
		return null;
	}

	private void CheckGeneric()
	{
	}

	internal static int get_metadata_token(RuntimeFieldInfo monoField)
	{
		return 0;
	}
}
