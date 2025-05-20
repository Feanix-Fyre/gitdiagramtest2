namespace System.Net;

internal class ReceiveState
{
	internal ResponseDescription Resp;

	internal int ValidThrough;

	internal byte[] Buffer;

	internal CommandStream Connection;

	internal ReceiveState(CommandStream connection)
	{
	}
}
