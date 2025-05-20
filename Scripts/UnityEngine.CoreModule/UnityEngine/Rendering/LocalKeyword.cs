using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[UsedByNativeCode]
public readonly struct LocalKeyword : IEquatable<LocalKeyword>
{
	internal readonly LocalKeywordSpace m_SpaceInfo;

	internal readonly string m_Name;

	internal readonly uint m_Index;

	[FreeFunction("ShaderScripting::GetKeywordCount")]
	private static uint GetShaderKeywordCount(Shader shader)
	{
		return 0u;
	}

	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	private static uint GetShaderKeywordIndex(Shader shader, string keyword)
	{
		return 0u;
	}

	public LocalKeyword(Shader shader, string name)
	{
		m_SpaceInfo = default(LocalKeywordSpace);
		m_Name = null;
		m_Index = 0u;
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public bool Equals(LocalKeyword rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
