namespace System;

internal class TermInfoReader
{
	private int boolSize;

	private int numSize;

	private int strOffsets;

	private byte[] buffer;

	private int booleansOffset;

	private int intOffset;

	public TermInfoReader(string term, string filename)
	{
	}

	public TermInfoReader(string term, byte[] buffer)
	{
	}

	private void DetermineVersion(short magic)
	{
	}

	private void ReadHeader(byte[] buffer, ref int position)
	{
	}

	private void ReadNames(byte[] buffer, ref int position)
	{
	}

	public int Get(TermInfoNumbers number)
	{
		return 0;
	}

	public string Get(TermInfoStrings tstr)
	{
		return null;
	}

	public byte[] GetStringBytes(TermInfoStrings tstr)
	{
		return null;
	}

	private short GetInt16(byte[] buffer, int offset)
	{
		return 0;
	}

	private string GetString(byte[] buffer, int offset)
	{
		return null;
	}

	private byte[] GetStringBytes(byte[] buffer, int offset)
	{
		return null;
	}
}
