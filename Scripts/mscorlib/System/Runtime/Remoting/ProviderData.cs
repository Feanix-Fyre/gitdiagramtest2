using System.Collections;

namespace System.Runtime.Remoting;

internal class ProviderData
{
	internal string Ref;

	internal string Type;

	internal string Id;

	internal Hashtable CustomProperties;

	internal IList CustomData;

	public void CopyFrom(ProviderData other)
	{
	}
}
