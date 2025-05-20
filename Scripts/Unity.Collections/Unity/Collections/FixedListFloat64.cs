using System;
using System.Runtime.InteropServices;

namespace Unity.Collections;

[Serializable]
[StructLayout((LayoutKind)2, Size = 64)]
[Obsolete("FixedListFloat64 is deprecated, please use FixedList64Bytes<float> instead. (UnityUpgradable) -> FixedList64Bytes<float>", true)]
public struct FixedListFloat64
{
}
