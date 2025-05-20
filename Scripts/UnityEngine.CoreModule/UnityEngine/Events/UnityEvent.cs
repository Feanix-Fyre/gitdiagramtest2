using System;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events;

[Serializable]
public class UnityEvent : UnityEventBase
{
	private object[] m_InvokeArray;

	[RequiredByNativeCode]
	public UnityEvent()
	{
	}

	public void AddListener(UnityAction call)
	{
	}

	public void RemoveListener(UnityAction call)
	{
	}

	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
	{
		return null;
	}

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
	{
		return null;
	}

	private static BaseInvokableCall GetDelegate(UnityAction action)
	{
		return null;
	}

	public void Invoke()
	{
	}
}
[Serializable]
public class UnityEvent<T0> : UnityEventBase
{
	private object[] m_InvokeArray;

	[RequiredByNativeCode]
	public UnityEvent()
	{
	}

	public void AddListener(UnityAction<T0> call)
	{
	}

	public void RemoveListener(UnityAction<T0> call)
	{
	}

	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
	{
		return null;
	}

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
	{
		return null;
	}

	private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
	{
		return null;
	}

	public void Invoke(T0 arg0)
	{
	}
}
[Serializable]
public class UnityEvent<T0, T1> : UnityEventBase
{
	private object[] m_InvokeArray;

	[RequiredByNativeCode]
	public UnityEvent()
	{
	}

	public void AddListener(UnityAction<T0, T1> call)
	{
	}

	public void RemoveListener(UnityAction<T0, T1> call)
	{
	}

	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
	{
		return null;
	}

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
	{
		return null;
	}

	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action)
	{
		return null;
	}

	public void Invoke(T0 arg0, T1 arg1)
	{
	}
}
[Serializable]
public class UnityEvent<T0, T1, T2> : UnityEventBase
{
	private object[] m_InvokeArray;

	[RequiredByNativeCode]
	public UnityEvent()
	{
	}

	public void AddListener(UnityAction<T0, T1, T2> call)
	{
	}

	public void RemoveListener(UnityAction<T0, T1, T2> call)
	{
	}

	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
	{
		return null;
	}

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
	{
		return null;
	}

	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action)
	{
		return null;
	}

	public void Invoke(T0 arg0, T1 arg1, T2 arg2)
	{
	}
}
[Serializable]
public class UnityEvent<T0, T1, T2, T3> : UnityEventBase
{
	private object[] m_InvokeArray;

	[RequiredByNativeCode]
	public UnityEvent()
	{
	}

	public void AddListener(UnityAction<T0, T1, T2, T3> call)
	{
	}

	public void RemoveListener(UnityAction<T0, T1, T2, T3> call)
	{
	}

	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
	{
		return null;
	}

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
	{
		return null;
	}

	private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2, T3> action)
	{
		return null;
	}

	public void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
	{
	}
}
