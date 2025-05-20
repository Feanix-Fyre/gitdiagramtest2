using System;
using System.Collections;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
[ExtensionOfNativeClass]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
public class MonoBehaviour : Behaviour
{
	private CancellationTokenSource m_CancellationTokenSource;

	public CancellationToken destroyCancellationToken => default(CancellationToken);

	public bool useGUILayout
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[RequiredByNativeCode]
	private void RaiseCancellation()
	{
	}

	public bool IsInvoking()
	{
		return false;
	}

	public void CancelInvoke()
	{
	}

	public void Invoke(string methodName, float time)
	{
	}

	public void InvokeRepeating(string methodName, float time, float repeatRate)
	{
	}

	public void CancelInvoke(string methodName)
	{
	}

	public bool IsInvoking(string methodName)
	{
		return false;
	}

	[ExcludeFromDocs]
	public Coroutine StartCoroutine(string methodName)
	{
		return null;
	}

	public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value)
	{
		return null;
	}

	public Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", false)]
	public Coroutine StartCoroutine_Auto(IEnumerator routine)
	{
		return null;
	}

	public void StopCoroutine(IEnumerator routine)
	{
	}

	public void StopCoroutine(Coroutine routine)
	{
	}

	public void StopCoroutine(string methodName)
	{
	}

	public void StopAllCoroutines()
	{
	}

	public static void print(object message)
	{
	}

	[FreeFunction("CancelInvoke")]
	private static void Internal_CancelInvokeAll([NotNull("NullExceptionObject")] MonoBehaviour self)
	{
	}

	[FreeFunction("IsInvoking")]
	private static bool Internal_IsInvokingAll([NotNull("NullExceptionObject")] MonoBehaviour self)
	{
		return false;
	}

	[FreeFunction]
	private static void InvokeDelayed([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName, float time, float repeatRate)
	{
	}

	[FreeFunction]
	private static void CancelInvoke([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName)
	{
	}

	[FreeFunction]
	private static bool IsInvoking([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName)
	{
		return false;
	}

	[FreeFunction]
	private static bool IsObjectMonoBehaviour([NotNull("NullExceptionObject")] Object obj)
	{
		return false;
	}

	private Coroutine StartCoroutineManaged(string methodName, object value)
	{
		return null;
	}

	private Coroutine StartCoroutineManaged2(IEnumerator enumerator)
	{
		return null;
	}

	private void StopCoroutineManaged(Coroutine routine)
	{
	}

	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine)
	{
	}

	internal string GetScriptClassName()
	{
		return null;
	}

	private void OnCancellationTokenCreated()
	{
	}
}
