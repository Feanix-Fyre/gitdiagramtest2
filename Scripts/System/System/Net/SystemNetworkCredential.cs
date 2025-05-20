namespace System.Net;

internal class SystemNetworkCredential : NetworkCredential
{
	internal static readonly SystemNetworkCredential defaultCredential;

	private SystemNetworkCredential()
	{
	}
}
