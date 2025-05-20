namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class TypeInformation
{
	private string fullTypeName;

	private string assemblyString;

	private bool hasTypeForwardedFrom;

	internal string FullTypeName => null;

	internal string AssemblyString => null;

	internal bool HasTypeForwardedFrom => false;

	internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
	{
	}
}
