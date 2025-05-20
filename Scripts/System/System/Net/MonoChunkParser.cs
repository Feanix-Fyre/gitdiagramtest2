using System.Collections;
using System.Text;

namespace System.Net;

internal class MonoChunkParser
{
	private enum State
	{
		None = 0,
		PartialSize = 1,
		Body = 2,
		BodyFinished = 3,
		Trailer = 4
	}

	private class Chunk
	{
		public byte[] Bytes;

		public int Offset;

		public Chunk(byte[] chunk)
		{
		}

		public int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}
	}

	private WebHeaderCollection headers;

	private int chunkSize;

	private int chunkRead;

	private int totalWritten;

	private State state;

	private StringBuilder saved;

	private bool sawCR;

	private bool gotit;

	private int trailerState;

	private ArrayList chunks;

	public bool WantMore => false;

	public bool DataAvailable => false;

	public int ChunkLeft => 0;

	public MonoChunkParser(WebHeaderCollection headers)
	{
	}

	public int Read(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	private int ReadFromChunks(byte[] buffer, int offset, int size)
	{
		return 0;
	}

	public void Write(byte[] buffer, int offset, int size)
	{
	}

	private void InternalWrite(byte[] buffer, ref int offset, int size)
	{
	}

	private State ReadBody(byte[] buffer, ref int offset, int size)
	{
		return default(State);
	}

	private State GetChunkSize(byte[] buffer, ref int offset, int size)
	{
		return default(State);
	}

	private static string RemoveChunkExtension(string input)
	{
		return null;
	}

	private State ReadCRLF(byte[] buffer, ref int offset, int size)
	{
		return default(State);
	}

	private State ReadTrailer(byte[] buffer, ref int offset, int size)
	{
		return default(State);
	}

	private static void ThrowProtocolViolation(string message)
	{
	}
}
