using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = true)]
internal struct AssemblyFullName
{
	[NativeName("name")]
	public string Name;

	[NativeName("version")]
	public AssemblyVersion Version;

	[NativeName("publicKeyToken")]
	public string PublicKeyToken;

	[NativeName("culture")]
	public string Culture;

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
