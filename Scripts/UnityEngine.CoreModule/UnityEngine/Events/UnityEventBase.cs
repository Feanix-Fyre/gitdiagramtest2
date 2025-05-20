using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Events;

[Serializable]
[UsedByNativeCode]
public abstract class UnityEventBase : ISerializationCallbackReceiver
{
	private InvokableCallList m_Calls;

	[SerializeField]
	[FormerlySerializedAs("m_PersistentListeners")]
	private PersistentCallGroup m_PersistentCalls;

	private bool m_CallsDirty;

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	protected MethodInfo FindMethod_Impl(string name, object targetObj)
	{
		return null;
	}

	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	internal MethodInfo FindMethod(PersistentCall call)
	{
		return null;
	}

	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
	{
		return null;
	}

	public int GetPersistentEventCount()
	{
		return 0;
	}

	public Object GetPersistentTarget(int index)
	{
		return null;
	}

	public string GetPersistentMethodName(int index)
	{
		return null;
	}

	private void DirtyPersistentCalls()
	{
	}

	private void RebuildPersistentCallsIfNeeded()
	{
	}

	public void SetPersistentListenerState(int index, UnityEventCallState state)
	{
	}

	public UnityEventCallState GetPersistentListenerState(int index)
	{
		return default(UnityEventCallState);
	}

	protected void AddListener(object targetObj, MethodInfo method)
	{
	}

	internal void AddCall(BaseInvokableCall call)
	{
	}

	protected void RemoveListener(object targetObj, MethodInfo method)
	{
	}

	public void RemoveAllListeners()
	{
	}

	internal List<BaseInvokableCall> PrepareInvoke()
	{
		return null;
	}

	protected void Invoke(object[] parameters)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes)
	{
		return null;
	}

	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes)
	{
		return null;
	}
}
