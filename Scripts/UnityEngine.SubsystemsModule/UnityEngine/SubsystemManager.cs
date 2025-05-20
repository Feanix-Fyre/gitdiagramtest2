using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.SubsystemsImplementation;

namespace UnityEngine;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action beforeReloadSubsystems;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action afterReloadSubsystems;

	private static List<IntegratedSubsystem> s_IntegratedSubsystems;

	private static List<SubsystemWithProvider> s_StandaloneSubsystems;

	private static List<Subsystem> s_DeprecatedSubsystems;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action reloadSubsytemsStarted;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action reloadSubsytemsCompleted;

	[RequiredByNativeCode]
	private static void ReloadSubsystemsStarted()
	{
	}

	[RequiredByNativeCode]
	private static void ReloadSubsystemsCompleted()
	{
	}

	[RequiredByNativeCode]
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem)
	{
	}

	[RequiredByNativeCode]
	private static void ClearSubsystems()
	{
	}

	private static void StaticConstructScriptingClassMap()
	{
	}

	static SubsystemManager()
	{
	}

	public static void GetSubsystems<T>(List<T> subsystems) where T : ISubsystem
	{
	}

	private static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) where TBaseTypeInList : ISubsystem where TQueryType : ISubsystem
	{
	}

	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr)
	{
		return null;
	}

	public static void GetInstances<T>(List<T> subsystems) where T : ISubsystem
	{
	}
}
