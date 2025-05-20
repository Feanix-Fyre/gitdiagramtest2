using System;
using System.Runtime.InteropServices;

namespace Unity.Collections;

[Serializable]
[StructLayout((LayoutKind)2, Size = 4096)]
[Obsolete("FixedListByte4096 is deprecated, please use FixedList4096Bytes<byte> instead. (UnityUpgradable) -> FixedList4096Bytes<byte>", true)]
public struct FixedListByte4096
{
}
