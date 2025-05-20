using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe;

[StructLayout((LayoutKind)0)]
[RequiredByNativeCode]
[NativeConditional("ENABLE_PROFILER")]
[NativeAsStruct]
public class AsyncReadManagerMetricsFilters
{
	[NativeName("typeIDs")]
	internal ulong[] TypeIDs;

	[NativeName("states")]
	internal ProcessingState[] States;

	[NativeName("readTypes")]
	internal FileReadType[] ReadTypes;

	[NativeName("priorityLevels")]
	internal Priority[] PriorityLevels;

	[NativeName("subsystems")]
	internal AssetLoadingSubsystem[] Subsystems;
}
