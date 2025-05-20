using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting;

[Serializable]
internal class EnvoyInfo : IEnvoyInfo
{
	private IMessageSink envoySinks;

	public IMessageSink EnvoySinks => null;

	public EnvoyInfo(IMessageSink sinks)
	{
	}
}
