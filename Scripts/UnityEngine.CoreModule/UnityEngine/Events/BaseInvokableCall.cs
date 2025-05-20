using System;
using System.Reflection;

namespace UnityEngine.Events;

internal abstract class BaseInvokableCall
{
	protected BaseInvokableCall()
	{
	}

	protected BaseInvokableCall(object target, MethodInfo function)
	{
	}

	public abstract void Invoke(object[] args);

	protected static void ThrowOnInvalidArg<T>(object arg)
	{
	}

	protected static bool AllowInvoke(Delegate @delegate)
	{
		return false;
	}

	public abstract bool Find(object targetObj, MethodInfo method);
}
