using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class UxmlObjectFactoryRegistry
{
	private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories;

	internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories => null;

	protected static void RegisterFactory(IBaseUxmlObjectFactory factory)
	{
	}

	internal static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory> factoryList)
	{
		factoryList = null;
		return false;
	}

	private static void RegisterEngineFactories()
	{
	}

	private static void RegisterUserFactories()
	{
	}
}
