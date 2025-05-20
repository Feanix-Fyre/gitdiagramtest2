using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Linq.Expressions.Interpreter;

internal class LightLambda
{
	private class DebugViewPrinter
	{
		private readonly Interpreter _interpreter;

		private readonly Dictionary<int, int> _tryStart;

		private readonly Dictionary<int, string> _handlerEnter;

		private readonly Dictionary<int, int> _handlerExit;

		private string _indent;

		public DebugViewPrinter(Interpreter interpreter)
		{
		}

		private void Analyze()
		{
		}

		private void AddTryStart(int index)
		{
		}

		private void AddHandlerExit(int index)
		{
		}

		private void Indent()
		{
		}

		private void Dedent()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void EmitExits(StringBuilder sb, int index)
		{
		}
	}

	private readonly IStrongBox[] _closure;

	private readonly Interpreter _interpreter;

	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache;

	private readonly LightDelegateCreator _delegateCreator;

	internal string DebugView => null;

	internal TRet Run0<TRet>()
	{
		return default(TRet);
	}

	internal void RunVoid0()
	{
	}

	internal static Delegate MakeRun0<TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid0(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run1<T0, TRet>(T0 arg0)
	{
		return default(TRet);
	}

	internal void RunVoid1<T0>(T0 arg0)
	{
	}

	internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid1<T0>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1)
	{
		return default(TRet);
	}

	internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1)
	{
	}

	internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2)
	{
		return default(TRet);
	}

	internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2)
	{
	}

	internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
	{
		return default(TRet);
	}

	internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
	{
	}

	internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
		return default(TRet);
	}

	internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
	}

	internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
		return default(TRet);
	}

	internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
	{
	}

	internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
	{
		return default(TRet);
	}

	internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
	{
	}

	internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
	{
		return default(TRet);
	}

	internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
	{
	}

	internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
	{
		return default(TRet);
	}

	internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
	{
	}

	internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
	{
		return default(TRet);
	}

	internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
	{
	}

	internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
	{
		return default(TRet);
	}

	internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
	{
	}

	internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
	{
		return default(TRet);
	}

	internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
	{
	}

	internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
	{
		return default(TRet);
	}

	internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
	{
	}

	internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
	{
		return default(TRet);
	}

	internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
	{
	}

	internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda)
	{
		return null;
	}

	internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
	{
		return default(TRet);
	}

	internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
	{
	}

	internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda)
	{
		return null;
	}

	internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda)
	{
		return null;
	}

	internal LightLambda(LightDelegateCreator delegateCreator, IStrongBox[] closure)
	{
	}

	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType)
	{
		return null;
	}

	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType)
	{
		return null;
	}

	private Delegate CreateCustomDelegate(Type delegateType)
	{
		return null;
	}

	internal Delegate MakeDelegate(Type delegateType)
	{
		return null;
	}

	private InterpretedFrame MakeFrame()
	{
		return null;
	}

	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1)
	{
	}

	public object Run(params object[] arguments)
	{
		return null;
	}

	public object RunVoid(params object[] arguments)
	{
		return null;
	}
}
