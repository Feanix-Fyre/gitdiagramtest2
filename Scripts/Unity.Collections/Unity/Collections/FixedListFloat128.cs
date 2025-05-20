using System;
using System.Runtime.InteropServices;

namespace Unity.Collections;

[Serializable]
[StructLayout((LayoutKind)2, Size = 128)]
[Obsolete("FixedListFloat128 is deprecated, please use FixedList128Bytes<float> instead. (UnityUpgradable) -> FixedList128Bytes<float>", true)]
public struct FixedListFloat128
{
}
