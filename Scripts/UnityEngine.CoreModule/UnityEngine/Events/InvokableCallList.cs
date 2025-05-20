using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Events;

internal class InvokableCallList
{
	private readonly List<BaseInvokableCall> m_PersistentCalls;

	private readonly List<BaseInvokableCall> m_RuntimeCalls;

	private List<BaseInvokableCall> m_ExecutingCalls;

	private bool m_NeedsUpdate;

	public int Count => 0;

	public void AddPersistentInvokableCall(BaseInvokableCall call)
	{
	}

	public void AddListener(BaseInvokableCall call)
	{
	}

	public void RemoveListener(object targetObj, MethodInfo method)
	{
	}

	public void Clear()
	{
	}

	public void ClearPersistent()
	{
	}

	public List<BaseInvokableCall> PrepareInvoke()
	{
		return null;
	}
}
