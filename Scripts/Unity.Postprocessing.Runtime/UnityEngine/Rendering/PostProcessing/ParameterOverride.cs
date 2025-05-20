using System;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class ParameterOverride
{
	public bool overrideState;

	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	public T GetValue<T>()
	{
		return default(T);
	}

	protected internal virtual void OnEnable()
	{
	}

	protected internal virtual void OnDisable()
	{
	}

	internal abstract void SetValue(ParameterOverride parameter);
}
[Serializable]
public class ParameterOverride<T> : ParameterOverride
{
	public T value;

	public ParameterOverride()
	{
	}

	public ParameterOverride(T value)
	{
	}

	public ParameterOverride(T value, bool overrideState)
	{
	}

	internal override void Interp(ParameterOverride from, ParameterOverride to, float t)
	{
	}

	public virtual void Interp(T from, T to, float t)
	{
	}

	public void Override(T x)
	{
	}

	internal override void SetValue(ParameterOverride parameter)
	{
	}

	public override int GetHash()
	{
		return 0;
	}

	public static implicit operator T(ParameterOverride<T> prop)
	{
		return default(T);
	}
}
