using System;
using System.Runtime.InteropServices;

namespace Unity.Collections;

[StructLayout((LayoutKind)0, Size = 1)]
[Obsolete("Renamed to FixedList64Bytes<T> (UnityUpgradable) -> FixedList64Bytes<T>", true)]
public struct FixedList64<T> where T : struct
{
}
