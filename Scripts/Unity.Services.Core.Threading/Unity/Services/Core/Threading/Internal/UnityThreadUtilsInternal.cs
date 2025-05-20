using System;
using System.Threading.Tasks;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Threading.Internal;

internal class UnityThreadUtilsInternal : IUnityThreadUtils, IServiceComponent
{
	bool IUnityThreadUtils.IsRunningOnUnityThread => false;

	public static Task PostAsync(Action action)
	{
		return null;
	}

	public static Task PostAsync(Action<object> action, object state)
	{
		return null;
	}

	public static Task<T> PostAsync<T>(Func<T> action)
	{
		return null;
	}

	public static Task<T> PostAsync<T>(Func<object, T> action, object state)
	{
		return null;
	}

	public static void Send(Action action)
	{
	}

	public static void Send(Action<object> action, object state)
	{
	}

	public static T Send<T>(Func<T> action)
	{
		return default(T);
	}

	public static T Send<T>(Func<object, T> action, object state)
	{
		return default(T);
	}

	Task IUnityThreadUtils.PostAsync(Action action)
	{
		return null;
	}

	Task IUnityThreadUtils.PostAsync(Action<object> action, object state)
	{
		return null;
	}

	Task<T> IUnityThreadUtils.PostAsync<T>(Func<T> action)
	{
		return null;
	}

	Task<T> IUnityThreadUtils.PostAsync<T>(Func<object, T> action, object state)
	{
		return null;
	}

	void IUnityThreadUtils.Send(Action action)
	{
	}

	void IUnityThreadUtils.Send(Action<object> action, object state)
	{
	}

	T IUnityThreadUtils.Send<T>(Func<T> action)
	{
		return default(T);
	}

	T IUnityThreadUtils.Send<T>(Func<object, T> action, object state)
	{
		return default(T);
	}
}
