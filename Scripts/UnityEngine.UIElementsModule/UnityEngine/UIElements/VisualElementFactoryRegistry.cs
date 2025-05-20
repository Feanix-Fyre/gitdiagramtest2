using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

internal class VisualElementFactoryRegistry
{
	private static Dictionary<string, List<IUxmlFactory>> s_Factories;

	private static Dictionary<string, List<IUxmlFactory>> s_MovedTypesFactories;

	internal static Dictionary<string, List<IUxmlFactory>> factories => null;

	private static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr)
	{
		return null;
	}

	protected static void RegisterFactory(IUxmlFactory factory)
	{
	}

	internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
	{
		factoryList = null;
		return false;
	}

	private static void RegisterEngineFactories()
	{
	}

	internal static void RegisterUserFactories()
	{
	}
}
