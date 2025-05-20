using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.Archive;

[RequiredByNativeCode]
[StaticAccessor("GetManagedArchiveSystem()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
public static class ArchiveFileInterface
{
}
