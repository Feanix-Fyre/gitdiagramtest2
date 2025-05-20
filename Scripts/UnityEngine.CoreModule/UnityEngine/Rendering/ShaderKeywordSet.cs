using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
[NativeHeader("Editor/Src/Graphics/ShaderCompilerData.h")]
public struct ShaderKeywordSet
{
	private IntPtr m_KeywordState;

	private IntPtr m_Shader;

	private IntPtr m_ComputeShader;

	private ulong m_StateIndex;

	[FreeFunction("keywords::IsKeywordEnabled")]
	private static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name)
	{
		return false;
	}

	private void CheckKeywordCompatible(ShaderKeyword keyword)
	{
	}

	public bool IsEnabled(ShaderKeyword keyword)
	{
		return false;
	}

	private static bool IsKeywordNameEnabled_Injected(ref ShaderKeywordSet state, string name)
	{
		return false;
	}
}
