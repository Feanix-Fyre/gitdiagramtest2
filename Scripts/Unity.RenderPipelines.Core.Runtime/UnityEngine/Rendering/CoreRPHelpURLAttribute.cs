using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
[Conditional("UNITY_EDITOR")]
public class CoreRPHelpURLAttribute : HelpURLAttribute
{
	public CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core")
		: base(null)
	{
	}

	public CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName = "com.unity.render-pipelines.core")
		: base(null)
	{
	}
}
