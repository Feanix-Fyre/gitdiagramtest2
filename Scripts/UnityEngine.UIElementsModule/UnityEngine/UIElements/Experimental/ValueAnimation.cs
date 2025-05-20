using System;

namespace UnityEngine.UIElements.Experimental;

public sealed class ValueAnimation<T> : IValueAnimationUpdate
{
	private long m_StartTimeMs;

	private int m_DurationMs;

	private static ObjectPool<ValueAnimation<T>> sObjectPool;

	private T _from;

	private bool fromValueSet;

	public int durationMs
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Func<float, float> easingCurve { get; set; }

	public bool isRunning { get; private set; }

	public Action onAnimationCompleted { get; set; }

	public bool autoRecycle { get; set; }

	private bool recycled { get; set; }

	private VisualElement owner { get; set; }

	public Action<VisualElement, T> valueUpdated { get; set; }

	public Func<VisualElement, T> initialValue { get; set; }

	public Func<T, T, float, T> interpolator { get; set; }

	public T from
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public T to { get; set; }

	public void Start()
	{
	}

	public void Stop()
	{
	}

	public void Recycle()
	{
	}

	void IValueAnimationUpdate.Tick(long currentTimeMs)
	{
	}

	private void SetDefaultValues()
	{
	}

	private void Unregister()
	{
	}

	private void Register()
	{
	}

	internal void SetOwner(VisualElement e)
	{
	}

	private void CheckNotRecycled()
	{
	}

	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator)
	{
		return null;
	}

	public ValueAnimation<T> KeepAlive()
	{
		return null;
	}
}
