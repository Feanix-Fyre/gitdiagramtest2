using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public struct ShaderKeyword
{
	internal string m_Name;

	internal uint m_Index;

	internal bool m_IsLocal;

	internal bool m_IsCompute;

	internal bool m_IsValid;

	public string name => null;

	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	internal static uint GetGlobalKeywordCount()
	{
		return 0u;
	}

	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	internal static uint GetGlobalKeywordIndex(string keyword)
	{
		return 0u;
	}

	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	internal static void CreateGlobalKeyword(string keyword)
	{
	}

	public ShaderKeyword(string keywordName)
	{
		m_Name = null;
		m_Index = 0u;
		m_IsLocal = false;
		m_IsCompute = false;
		m_IsValid = false;
	}

	public override string ToString()
	{
		return null;
	}
}
