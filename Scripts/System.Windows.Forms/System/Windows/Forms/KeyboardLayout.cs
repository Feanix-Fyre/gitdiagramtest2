namespace System.Windows.Forms;

[Serializable]
internal class KeyboardLayout
{
	public int Lcid;

	public string Name;

	public ScanTableIndex ScanIndex;

	public VKeyTableIndex VKeyIndex;

	public uint[][] Keys;
}
