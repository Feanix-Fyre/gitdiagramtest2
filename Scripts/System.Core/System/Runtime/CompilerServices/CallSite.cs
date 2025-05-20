using System.Linq.Expressions;
using System.Reflection;

namespace System.Runtime.CompilerServices;

/// <summary>A dynamic call site base class. This type is used as a parameter type to the dynamic site targets.</summary>
public class CallSite
{
	internal readonly CallSiteBinder _binder;

	internal bool _match;

	/// <summary>Class responsible for binding dynamic operations on the dynamic site.</summary>
	/// <returns>The <see cref="T:System.Runtime.CompilerServices.CallSiteBinder" /> object responsible for binding dynamic operations.</returns>
	public CallSiteBinder Binder => null;

	internal CallSite(CallSiteBinder binder)
	{
	}
}
/// <summary>Dynamic site type.</summary>
/// <typeparam name="T">The delegate type.</typeparam>
public class CallSite<T> : CallSite where T : class
{
	/// <summary>The Level 0 cache - a delegate specialized based on the site history.</summary>
	public T Target;

	internal T[] Rules;

	private static T s_cachedUpdate;

	private static T s_cachedNoMatch;

	/// <summary>The update delegate. Called when the dynamic site experiences cache miss.</summary>
	/// <returns>The update delegate.</returns>
	public T Update => null;

	private CallSite(CallSiteBinder binder)
		: base(null)
	{
	}

	private CallSite()
		: base(null)
	{
	}

	internal CallSite<T> CreateMatchMaker()
	{
		return null;
	}

	/// <summary>Creates an instance of the dynamic call site, initialized with the binder responsible for the runtime binding of the dynamic operations at this call site.</summary>
	/// <param name="binder">The binder responsible for the runtime binding of the dynamic operations at this call site.</param>
	/// <returns>The new instance of dynamic call site.</returns>
	public static CallSite<T> Create(CallSiteBinder binder)
	{
		return null;
	}

	private T GetUpdateDelegate()
	{
		return null;
	}

	private T GetUpdateDelegate(ref T addr)
	{
		return null;
	}

	internal void AddRule(T newRule)
	{
	}

	internal void MoveRule(int i)
	{
	}

	internal T MakeUpdateDelegate()
	{
		return null;
	}

	private T CreateCustomUpdateDelegate(MethodInfo invoke)
	{
		return null;
	}

	private T CreateCustomNoMatchDelegate(MethodInfo invoke)
	{
		return null;
	}

	private static Expression Convert(Expression arg, Type type)
	{
		return null;
	}
}
