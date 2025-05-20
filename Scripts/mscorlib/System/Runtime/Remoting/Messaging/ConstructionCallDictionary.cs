using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Messaging;

internal class ConstructionCallDictionary : MessageDictionary
{
	public static string[] InternalKeys;

	public ConstructionCallDictionary(IConstructionCallMessage message)
		: base(null)
	{
	}

	protected override object GetMethodProperty(string key)
	{
		return null;
	}

	protected override void SetMethodProperty(string key, object value)
	{
	}
}
