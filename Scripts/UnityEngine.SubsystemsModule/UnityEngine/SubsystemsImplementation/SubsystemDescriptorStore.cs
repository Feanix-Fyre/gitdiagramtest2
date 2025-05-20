using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.SubsystemsImplementation;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemDescriptorStore
{
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors;

	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors;

	private static List<SubsystemDescriptor> s_DeprecatedDescriptors;

	[RequiredByNativeCode]
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc)
	{
	}

	[RequiredByNativeCode]
	internal static void ClearManagedDescriptors()
	{
	}

	private static void ReportSingleSubsystemAnalytics(string id)
	{
	}

	internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) where TDescriptor : TBaseTypeInList where TBaseTypeInList : ISubsystemDescriptor
	{
	}

	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor)
	{
	}
}
