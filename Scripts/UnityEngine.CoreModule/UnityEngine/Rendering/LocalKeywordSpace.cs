using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
public readonly struct LocalKeywordSpace : IEquatable<LocalKeywordSpace>
{
	private readonly IntPtr m_KeywordSpace;

	public override bool Equals(object o)
	{
		return false;
	}

	public bool Equals(LocalKeywordSpace rhs)
	{
		return false;
	}

	public static bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
