using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
using UnityEngine.Scripting;

namespace Unity.Burst;

public static class BurstCompiler
{
	private class CommandBuilder
	{
		private StringBuilder _builder;

		private bool _hasArgs;

		public CommandBuilder Begin(string cmd)
		{
			return null;
		}

		public CommandBuilder With(string arg)
		{
			return null;
		}

		public CommandBuilder With(IntPtr arg)
		{
			return null;
		}

		public CommandBuilder And(char sep = '|')
		{
			return null;
		}

		public string SendToCompiler()
		{
			return null;
		}
	}

	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	internal class StaticTypeReinitAttribute : Attribute
	{
		public readonly Type reinitType;

		public StaticTypeReinitAttribute(Type toReinit)
		{
		}
	}

	[BurstCompile]
	internal static class BurstCompilerHelper
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate bool IsBurstEnabledDelegate();

		private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl;

		public static readonly bool IsBurstGenerated;

		[BurstCompile]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		private static bool IsBurstEnabled()
		{
			return false;
		}

		[BurstDiscard]
		private static void DiscardedMethod(ref bool value)
		{
		}

		private static bool IsCompiledByBurst(Delegate del)
		{
			return false;
		}
	}

	private class FakeDelegate
	{
		[Preserve]
		public MethodInfo Method { get; }

		public FakeDelegate(MethodInfo method)
		{
		}
	}

	[ThreadStatic]
	private static CommandBuilder _cmdBuilder;

	internal static bool _IsEnabled;

	public static readonly BurstCompilerOptions Options;

	internal static Action OnCompileILPPMethod2;

	private static readonly MethodInfo DummyMethodInfo;

	public static bool IsEnabled => false;

	public static bool IsLoadAdditionalLibrarySupported()
	{
		return false;
	}

	private static CommandBuilder BeginCompilerCommand(string cmd)
	{
		return null;
	}

	public static void SetExecutionMode(BurstExecutionEnvironment mode)
	{
	}

	public static BurstExecutionEnvironment GetExecutionMode()
	{
		return default(BurstExecutionEnvironment);
	}

	internal static T CompileDelegate<T>(T delegateMethod) where T : class
	{
		return null;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void VerifyDelegateIsNotMulticast<T>(T delegateMethod) where T : class
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute<T>(T delegateMethod) where T : class
	{
	}

	[Obsolete("This method will be removed in a future version of Burst")]
	public static IntPtr CompileILPPMethod(RuntimeMethodHandle burstMethodHandle, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle)
	{
		return (IntPtr)0;
	}

	public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle)
	{
		return (IntPtr)0;
	}

	[Obsolete("This method will be removed in a future version of Burst")]
	public unsafe static void* GetILPPMethodFunctionPointer(IntPtr ilppMethod)
	{
		return null;
	}

	public unsafe static void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle)
	{
		return null;
	}

	[Obsolete("This method will be removed in a future version of Burst")]
	public unsafe static void* CompileUnsafeStaticMethod(RuntimeMethodHandle handle)
	{
		return null;
	}

	public static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod) where T : class
	{
		return default(FunctionPointer<T>);
	}

	private unsafe static void* Compile(object delegateObj, bool isFunctionPointer)
	{
		return null;
	}

	private unsafe static void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing)
	{
		return null;
	}

	internal static void Shutdown()
	{
	}

	internal static void Cancel()
	{
	}

	internal static bool IsCurrentCompilationDone()
	{
		return false;
	}

	internal static void Enable()
	{
	}

	internal static void Disable()
	{
	}

	internal static bool IsHostEditorArm()
	{
		return false;
	}

	internal static void TriggerUnsafeStaticMethodRecompilation()
	{
	}

	internal static void TriggerRecompilation()
	{
	}

	internal static void UnloadAdditionalLibraries()
	{
	}

	internal static void InitialiseDebuggerHooks()
	{
	}

	internal static bool IsApiAvailable(string apiName)
	{
		return false;
	}

	internal static int RequestSetProtocolVersion(int version)
	{
		return 0;
	}

	internal static void Initialize(string[] assemblyFolders, string[] ignoreAssemblies)
	{
	}

	internal static void NotifyCompilationStarted(string[] assemblyFolders, string[] ignoreAssemblies)
	{
	}

	internal static void NotifyAssemblyCompilationNotRequired(string assemblyName)
	{
	}

	internal static void NotifyAssemblyCompilationFinished(string assemblyName, string[] defines)
	{
	}

	internal static void NotifyCompilationFinished()
	{
	}

	internal static string AotCompilation(string[] assemblyFolders, string[] assemblyRoots, string options)
	{
		return null;
	}

	internal static void SetProfilerCallbacks()
	{
	}

	private static string SendRawCommandToCompiler(string command)
	{
		return null;
	}

	private static string SendCommandToCompiler(string commandName, string commandArgs = null)
	{
		return null;
	}

	private static void DummyMethod()
	{
	}
}
