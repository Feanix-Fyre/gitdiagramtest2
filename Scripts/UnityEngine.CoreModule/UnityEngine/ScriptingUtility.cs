using UnityEngine.Scripting;

namespace UnityEngine;

internal class ScriptingUtility
{
	private struct TestClass
	{
		public int value;
	}

	[RequiredByNativeCode]
	private static bool IsManagedCodeWorking()
	{
		return false;
	}
}
