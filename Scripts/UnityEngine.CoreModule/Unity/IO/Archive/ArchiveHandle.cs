using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.Archive;

[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[RequiredByNativeCode]
public struct ArchiveHandle
{
	internal ulong Handle;
}
