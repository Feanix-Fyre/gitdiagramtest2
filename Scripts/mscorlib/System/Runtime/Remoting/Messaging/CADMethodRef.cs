using System.Reflection;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class CADMethodRef
{
	private bool ctor;

	private string typeName;

	private string methodName;

	private string[] param_names;

	private string[] generic_arg_names;

	private Type[] GetTypes(string[] typeArray)
	{
		return null;
	}

	public MethodBase Resolve()
	{
		return null;
	}

	public CADMethodRef(IMethodMessage msg)
	{
	}
}
