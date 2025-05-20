namespace System.Windows.Forms.CarbonInternal;

internal struct HIViewID
{
	public uint type;

	public uint id;

	public HIViewID(uint type, uint id)
	{
		this.type = 0u;
		this.id = 0u;
	}
}
