using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComDefaultInterface(typeof(_Module))]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
internal class RuntimeModule : Module
{
	internal IntPtr _impl;

	internal Assembly assembly;

	internal string fqname;

	internal string name;

	internal string scopename;

	internal bool is_resource;

	internal int token;

	public override Assembly Assembly => null;

	public override string ScopeName => null;

	public override Guid ModuleVersionId => default(Guid);

	public override bool IsResource()
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

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal RuntimeAssembly GetRuntimeAssembly()
	{
		return null;
	}

	internal override Guid GetModuleVersionId()
	{
		return default(Guid);
	}

	private static void GetGuidInternal(IntPtr module, byte[] guid)
	{
	}
}
