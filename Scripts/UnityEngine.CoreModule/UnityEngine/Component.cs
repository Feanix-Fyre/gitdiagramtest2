using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[NativeClass("Unity::Component")]
[RequiredByNativeCode]
public class Component : Object
{
	public Transform transform
	{
		[FreeFunction("GetTransform", HasExplicitThis = true, ThrowsException = true)]
		get
		{
			return null;
		}
	}

	public GameObject gameObject
	{
		[FreeFunction("GetGameObject", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public string tag => null;

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public Component GetComponent(Type type)
	{
		return null;
	}

	[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
	{
	}

	public T GetComponent<T>()
	{
		return default(T);
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public bool TryGetComponent(Type type, out Component component)
	{
		component = null;
		return false;
	}

	public bool TryGetComponent<T>(out T component)
	{
		component = default(T);
		return false;
	}

	[FreeFunction(HasExplicitThis = true)]
	public Component GetComponent(string type)
	{
		return null;
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public Component GetComponentInChildren(Type t, bool includeInactive)
	{
		return null;
	}

	public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
	{
		return default(T);
	}

	[ExcludeFromDocs]
	public T GetComponentInChildren<T>()
	{
		return default(T);
	}

	public T[] GetComponentsInChildren<T>(bool includeInactive)
	{
		return null;
	}

	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
	{
	}

	public T[] GetComponentsInChildren<T>()
	{
		return null;
	}

	public void GetComponentsInChildren<T>(List<T> results)
	{
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public Component GetComponentInParent(Type t, bool includeInactive)
	{
		return null;
	}

	public T GetComponentInParent<T>()
	{
		return default(T);
	}

	public T[] GetComponentsInParent<T>(bool includeInactive)
	{
		return null;
	}

	public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
	{
	}

	public T[] GetComponentsInParent<T>()
	{
		return null;
	}

	public Component[] GetComponents(Type type)
	{
		return null;
	}

	[FreeFunction(HasExplicitThis = true, ThrowsException = true)]
	private void GetComponentsForListInternal(Type searchType, object resultList)
	{
	}

	public void GetComponents(Type type, List<Component> results)
	{
	}

	public void GetComponents<T>(List<T> results)
	{
	}

	public T[] GetComponents<T>()
	{
		return null;
	}

	public bool CompareTag(string tag)
	{
		return false;
	}

	[FreeFunction("SendMessage", HasExplicitThis = true)]
	public void SendMessage(string methodName, object value, SendMessageOptions options)
	{
	}

	[FreeFunction("BroadcastMessage", HasExplicitThis = true)]
	public void BroadcastMessage(string methodName, [DefaultValue("null")] object parameter, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
	{
	}
}
