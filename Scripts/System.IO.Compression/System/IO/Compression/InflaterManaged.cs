namespace System.IO.Compression;

internal sealed class InflaterManaged
{
	private static readonly byte[] s_extraLengthBits;

	private static readonly int[] s_lengthBase;

	private static readonly int[] s_distanceBasePosition;

	private static readonly byte[] s_codeOrder;

	private static readonly byte[] s_staticDistanceTreeTable;

	private readonly OutputWindow _output;

	private readonly InputBuffer _input;

	private HuffmanTree _literalLengthTree;

	private HuffmanTree _distanceTree;

	private InflaterState _state;

	private bool _hasFormatReader;

	private int _bfinal;

	private BlockType _blockType;

	private readonly byte[] _blockLengthBuffer;

	private int _blockLength;

	private int _length;

	private int _distanceCode;

	private int _extraBits;

	private int _loopCounter;

	private int _literalLengthCodeCount;

	private int _distanceCodeCount;

	private int _codeLengthCodeCount;

	private int _codeArraySize;

	private int _lengthCode;

	private readonly byte[] _codeList;

	private readonly byte[] _codeLengthTreeCodeLength;

	private readonly bool _deflate64;

	private HuffmanTree _codeLengthTree;

	private IFileFormatReader _formatReader;

	internal InflaterManaged(IFileFormatReader reader, bool deflate64)
	{
	}

	private void Reset()
	{
	}

	public void SetInput(byte[] inputBytes, int offset, int length)
	{
	}

	public bool Finished()
	{
		return false;
	}

	public int Inflate(byte[] bytes, int offset, int length)
	{
		return 0;
	}

	private bool Decode()
	{
		return false;
	}

	private bool DecodeUncompressedBlock(out bool end_of_block)
	{
		end_of_block = default(bool);
		return false;
	}

	private bool DecodeBlock(out bool end_of_block_code_seen)
	{
		end_of_block_code_seen = default(bool);
		return false;
	}

	private bool DecodeDynamicBlockHeader()
	{
		return false;
	}

	public void Dispose()
	{
	}
}
