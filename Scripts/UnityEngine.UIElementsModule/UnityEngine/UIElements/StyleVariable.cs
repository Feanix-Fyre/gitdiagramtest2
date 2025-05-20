namespace UnityEngine.UIElements;

internal struct StyleVariable
{
	public readonly string name;

	public readonly StyleSheet sheet;

	public readonly StyleValueHandle[] handles;

	public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles)
	{
		this.name = null;
		this.sheet = null;
		this.handles = null;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
