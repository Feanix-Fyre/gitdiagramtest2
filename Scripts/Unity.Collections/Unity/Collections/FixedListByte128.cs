using System;
using System.Runtime.InteropServices;

namespace Unity.Collections;

[Serializable]
[StructLayout((LayoutKind)2, Size = 128)]
[Obsolete("FixedListByte128 is deprecated, please use FixedList128Bytes<byte> instead. (UnityUpgradable) -> FixedList128Bytes<byte>", true)]
public struct FixedListByte128
{
}
