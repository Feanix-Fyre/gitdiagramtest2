using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[UsedByNativeCode]
[NativeHeader("Modules/Subsystems/Subsystem.h")]
public class IntegratedSubsystem : ISubsystem
{
	internal IntPtr m_Ptr;

	internal ISubsystemDescriptor m_SubsystemDescriptor;

	public bool running => false;

	internal bool valid => false;

	internal void SetHandle(IntegratedSubsystem subsystem)
	{
	}

	internal bool IsRunning()
	{
		return false;
	}
}
[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem where TSubsystemDescriptor : ISubsystemDescriptor
{
}
