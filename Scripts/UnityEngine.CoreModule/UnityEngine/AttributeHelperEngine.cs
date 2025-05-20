using System;
using UnityEngine.Scripting;

namespace UnityEngine;

internal class AttributeHelperEngine
{
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray;

	public static ExecuteInEditMode[] _executeInEditModeArray;

	public static RequireComponent[] _requireComponentArray;

	[RequiredByNativeCode]
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type)
	{
		return null;
	}

	[RequiredByNativeCode]
	private static Type[] GetRequiredComponents(Type klass)
	{
		return null;
	}

	private static int GetExecuteMode(Type klass)
	{
		return 0;
	}

	[RequiredByNativeCode]
	private static int CheckIsEditorScript(Type klass)
	{
		return 0;
	}

	[RequiredByNativeCode]
	private static int GetDefaultExecutionOrderFor(Type klass)
	{
		return 0;
	}

	private static T GetCustomAttributeOfType<T>(Type klass) where T : Attribute
	{
		return null;
	}
}
