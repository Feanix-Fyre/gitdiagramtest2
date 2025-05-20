using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryAssemblyInfo
{
	internal string assemblyString;

	private Assembly assembly;

	internal BinaryAssemblyInfo(string assemblyString)
	{
	}

	internal BinaryAssemblyInfo(string assemblyString, Assembly assembly)
	{
	}

	internal Assembly GetAssembly()
	{
		return null;
	}
}
