namespace System.Runtime.Remoting.Messaging;

internal class MethodReturnDictionary : MessageDictionary
{
	public static string[] InternalReturnKeys;

	public static string[] InternalExceptionKeys;

	public MethodReturnDictionary(IMethodReturnMessage message)
		: base(null)
	{
	}
}
