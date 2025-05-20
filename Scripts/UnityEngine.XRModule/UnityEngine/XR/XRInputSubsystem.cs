using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[UsedByNativeCode]
[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<XRInputSubsystem> trackingOriginUpdated;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<XRInputSubsystem> boundaryChanged;

	[RequiredByNativeCode(GenerateProxy = true)]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr)
	{
	}

	[RequiredByNativeCode(GenerateProxy = true)]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr)
	{
	}
}
