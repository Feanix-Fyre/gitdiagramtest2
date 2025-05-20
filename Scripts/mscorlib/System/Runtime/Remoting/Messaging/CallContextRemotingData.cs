namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class CallContextRemotingData : ICloneable
{
	private string _logicalCallID;

	internal string LogicalCallID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool HasInfo => false;

	public object Clone()
	{
		return null;
	}
}
