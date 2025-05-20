namespace System.Runtime.Remoting.Channels;

[Serializable]
internal class CrossAppDomainData
{
	private object _ContextID;

	private int _DomainID;

	private string _processGuid;

	internal int DomainID => 0;

	internal string ProcessID => null;

	internal CrossAppDomainData(int domainId)
	{
	}
}
