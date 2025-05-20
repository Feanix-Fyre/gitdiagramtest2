using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Events;

[Serializable]
internal class PersistentCallGroup
{
	[FormerlySerializedAs("m_Listeners")]
	[SerializeField]
	private List<PersistentCall> m_Calls;

	public int Count => 0;

	public PersistentCall GetListener(int index)
	{
		return null;
	}

	public IEnumerable<PersistentCall> GetListeners()
	{
		return null;
	}

	public void AddListener()
	{
	}

	public void AddListener(PersistentCall call)
	{
	}

	public void RemoveListener(int index)
	{
	}

	public void Clear()
	{
	}

	public void RegisterEventPersistentListener(int index, Object targetObj, Type targetObjType, string methodName)
	{
	}

	public void RegisterVoidPersistentListener(int index, Object targetObj, Type targetObjType, string methodName)
	{
	}

	public void RegisterObjectPersistentListener(int index, Object targetObj, Type targetObjType, Object argument, string methodName)
	{
	}

	public void RegisterIntPersistentListener(int index, Object targetObj, Type targetObjType, int argument, string methodName)
	{
	}

	public void RegisterFloatPersistentListener(int index, Object targetObj, Type targetObjType, float argument, string methodName)
	{
	}

	public void RegisterStringPersistentListener(int index, Object targetObj, Type targetObjType, string argument, string methodName)
	{
	}

	public void RegisterBoolPersistentListener(int index, Object targetObj, Type targetObjType, bool argument, string methodName)
	{
	}

	public void UnregisterPersistentListener(int index)
	{
	}

	public void RemoveListeners(Object target, string methodName)
	{
	}

	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
	{
	}
}
