namespace Mono;

internal struct RuntimeRemoteClassHandle
{
	private unsafe RuntimeStructs.RemoteClass* value;

	internal RuntimeClassHandle ProxyClass => default(RuntimeClassHandle);
}
