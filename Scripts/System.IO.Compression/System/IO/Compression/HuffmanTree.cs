namespace System.IO.Compression;

internal sealed class HuffmanTree
{
	private readonly int _tableBits;

	private readonly short[] _table;

	private readonly short[] _left;

	private readonly short[] _right;

	private readonly byte[] _codeLengthArray;

	private readonly int _tableMask;

	public static HuffmanTree StaticLiteralLengthTree { get; }

	public static HuffmanTree StaticDistanceTree { get; }

	public HuffmanTree(byte[] codeLengths)
	{
	}

	private static byte[] GetStaticLiteralTreeLength()
	{
		return null;
	}

	private static byte[] GetStaticDistanceTreeLength()
	{
		return null;
	}

	private uint[] CalculateHuffmanCode()
	{
		return null;
	}

	private void CreateTable()
	{
	}

	public int GetNextSymbol(InputBuffer input)
	{
		return 0;
	}
}
