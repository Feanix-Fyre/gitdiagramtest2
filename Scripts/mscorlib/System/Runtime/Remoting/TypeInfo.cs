namespace System.Runtime.Remoting;

[Serializable]
internal class TypeInfo : IRemotingTypeInfo
{
	private string serverType;

	private string[] serverHierarchy;

	private string[] interfacesImplemented;

	public string TypeName => null;

	public TypeInfo(Type type)
	{
	}

	public bool CanCastTo(Type fromType, object o)
	{
		return false;
	}
}
