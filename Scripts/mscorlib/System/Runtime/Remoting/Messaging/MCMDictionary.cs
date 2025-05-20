namespace System.Runtime.Remoting.Messaging;

internal class MCMDictionary : MessageDictionary
{
	public static string[] InternalKeys;

	public MCMDictionary(IMethodMessage message)
		: base(null)
	{
	}
}
