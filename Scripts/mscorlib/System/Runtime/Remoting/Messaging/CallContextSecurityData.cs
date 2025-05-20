using System.Security.Principal;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class CallContextSecurityData : ICloneable
{
	private IPrincipal _principal;

	internal bool HasInfo => false;

	public object Clone()
	{
		return null;
	}
}
