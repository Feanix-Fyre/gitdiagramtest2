using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
internal sealed class RuntimeEventInfo : EventInfo, ISerializable
{
	private IntPtr klass;

	private IntPtr handle;

	public override Module Module => null;

	internal BindingFlags BindingFlags => default(BindingFlags);

	private RuntimeType ReflectedTypeInternal => null;

	public override Type DeclaringType => null;

	public override Type ReflectedType => null;

	public override string Name => null;

	public override int MetadataToken => 0;

	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info)
	{
		info = default(MonoEventInfo);
	}

	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev)
	{
		return default(MonoEventInfo);
	}

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

	internal BindingFlags GetBindingFlags()
	{
		return default(BindingFlags);
	}

	public override MethodInfo GetAddMethod(bool nonPublic)
	{
		return null;
	}

	public override MethodInfo GetRaiseMethod(bool nonPublic)
	{
		return null;
	}

	public override MethodInfo GetRemoveMethod(bool nonPublic)
	{
		return null;
	}

	public override string ToString()
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

	internal static int get_metadata_token(RuntimeEventInfo monoEvent)
	{
		return 0;
	}
}
