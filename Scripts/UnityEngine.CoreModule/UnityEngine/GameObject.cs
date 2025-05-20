using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[UsedByNativeCode]
public sealed class GameObject : Object
{
	public Transform transform
	{
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public int layer
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool activeSelf
	{
		[NativeMethod(Name = "IsSelfActive")]
		get
		{
			return false;
		}
	}

	public bool activeInHierarchy
	{
		[NativeMethod(Name = "IsActive")]
		get
		{
			return false;
		}
	}

	public bool isStatic
	{
		[NativeMethod(Name = "GetIsStaticDeprecated")]
		get
		{
			return false;
		}
		[NativeMethod(Name = "SetIsStaticDeprecated")]
		set
		{
		}
	}

	public string tag
	{
		[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = true)]
		get
		{
			return null;
		}
		[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = true)]
		set
		{
		}
	}

	public Scene scene
	{
		[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = true)]
		get
		{
			return default(Scene);
		}
	}

	public ulong sceneCullingMask
	{
		[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = true)]
		get
		{
			return 0uL;
		}
	}

	public GameObject gameObject => null;

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	public static GameObject CreatePrimitive(PrimitiveType type)
	{
		return null;
	}

	public T GetComponent<T>()
	{
		return default(T);
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
	public Component GetComponent(Type type)
	{
		return null;
	}

	[NativeWritableSelf]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
	{
	}

	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObject", HasExplicitThis = true)]
	internal Component GetComponentByName(string type)
	{
		return null;
	}

	public Component GetComponent(string type)
	{
		return null;
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
	public Component GetComponentInChildren(Type type, bool includeInactive)
	{
		return null;
	}

	[ExcludeFromDocs]
	public T GetComponentInChildren<T>()
	{
		return default(T);
	}

	public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
	{
		return default(T);
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = true, ThrowsException = true)]
	public Component GetComponentInParent(Type type, bool includeInactive)
	{
		return null;
	}

	[ExcludeFromDocs]
	public T GetComponentInParent<T>()
	{
		return default(T);
	}

	public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive)
	{
		return default(T);
	}

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = true, ThrowsException = true)]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList)
	{
		return null;
	}

	public Component[] GetComponents(Type type)
	{
		return null;
	}

	public T[] GetComponents<T>()
	{
		return null;
	}

	public void GetComponents<T>(List<T> results)
	{
	}

	public T[] GetComponentsInChildren<T>(bool includeInactive)
	{
		return null;
	}

	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
	{
	}

	public T[] GetComponentsInChildren<T>()
	{
		return null;
	}

	public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
	{
	}

	public T[] GetComponentsInParent<T>(bool includeInactive)
	{
		return null;
	}

	public bool TryGetComponent<T>(out T component)
	{
		component = default(T);
		return false;
	}

	public bool TryGetComponent(Type type, out Component component)
	{
		component = null;
		return false;
	}

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	internal Component TryGetComponentInternal(Type type)
	{
		return null;
	}

	[NativeWritableSelf]
	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
	{
	}

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = true)]
	private Component Internal_AddComponentWithType(Type componentType)
	{
		return null;
	}

	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public Component AddComponent(Type componentType)
	{
		return null;
	}

	public T AddComponent<T>() where T : Component
	{
		return null;
	}

	[NativeMethod(Name = "SetSelfActive")]
	public void SetActive(bool value)
	{
	}

	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = true)]
	public bool CompareTag(string tag)
	{
		return false;
	}

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = true)]
	public static GameObject FindGameObjectWithTag(string tag)
	{
		return null;
	}

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = true)]
	public static GameObject[] FindGameObjectsWithTag(string tag)
	{
		return null;
	}

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
	public void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options)
	{
	}

	public GameObject(string name)
	{
	}

	public GameObject()
	{
	}

	public GameObject(string name, params Type[] components)
	{
	}

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	private static void Internal_CreateGameObject([Writable] GameObject self, string name)
	{
	}

	[FreeFunction(Name = "GameObjectBindings::Find")]
	public static GameObject Find(string name)
	{
		return null;
	}

	[SpecialName]
	private void get_scene_Injected(out Scene ret)
	{
		ret = default(Scene);
	}
}
