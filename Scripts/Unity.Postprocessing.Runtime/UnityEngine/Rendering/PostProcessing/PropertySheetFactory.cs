using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheetFactory
{
	private readonly Dictionary<Shader, PropertySheet> m_Sheets;

	[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
	public PropertySheet Get(string shaderName)
	{
		return null;
	}

	public PropertySheet Get(Shader shader)
	{
		return null;
	}

	public void Release()
	{
	}
}
