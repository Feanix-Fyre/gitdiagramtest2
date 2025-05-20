using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Events;

internal class InvokableCall : BaseInvokableCall
{
	private event UnityAction Delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public InvokableCall(UnityAction action)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public void Invoke()
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1> : BaseInvokableCall
{
	protected event UnityAction<T1> Delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public InvokableCall(UnityAction<T1> action)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public virtual void Invoke(T1 args0)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1, T2> : BaseInvokableCall
{
	protected event UnityAction<T1, T2> Delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public InvokableCall(UnityAction<T1, T2> action)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public void Invoke(T1 args0, T2 args1)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1, T2, T3> : BaseInvokableCall
{
	protected event UnityAction<T1, T2, T3> Delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public InvokableCall(UnityAction<T1, T2, T3> action)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public void Invoke(T1 args0, T2 args1, T3 args2)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
{
	protected event UnityAction<T1, T2, T3, T4> Delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public InvokableCall(UnityAction<T1, T2, T3, T4> action)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public void Invoke(T1 args0, T2 args1, T3 args2, T4 args3)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
