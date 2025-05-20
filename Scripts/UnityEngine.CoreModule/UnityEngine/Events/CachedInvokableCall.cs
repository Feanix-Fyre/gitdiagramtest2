using System.Reflection;

namespace UnityEngine.Events;

internal class CachedInvokableCall<T> : InvokableCall<T>
{
	private readonly T m_Arg1;

	public CachedInvokableCall(Object target, MethodInfo theFunction, T argument)
		: base((object)null, (MethodInfo)null)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public override void Invoke(T arg0)
	{
	}
}
