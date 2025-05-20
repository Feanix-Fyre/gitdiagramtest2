using System.Collections.Generic;

namespace System.Net;

internal class AutoWebProxyScriptEngine
{
	public bool GetProxies(Uri destination, out IList<string> proxyList)
	{
		proxyList = null;
		return false;
	}

	public bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
	{
		proxyList = null;
		return false;
	}
}
