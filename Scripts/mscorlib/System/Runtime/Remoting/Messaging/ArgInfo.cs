using System.Reflection;

namespace System.Runtime.Remoting.Messaging;

internal class ArgInfo
{
	private int[] _paramMap;

	private int _inoutArgCount;

	private MethodBase _method;

	public ArgInfo(MethodBase method, ArgInfoType type)
	{
	}

	public object[] GetInOutArgs(object[] args)
	{
		return null;
	}
}
