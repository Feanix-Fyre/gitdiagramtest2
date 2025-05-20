using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mono.Xml;

internal class SmallXmlParser
{
	public interface IContentHandler
	{
		void OnStartParsing(SmallXmlParser parser);

		void OnEndParsing(SmallXmlParser parser);

		void OnStartElement(string name, IAttrList attrs);

		void OnEndElement(string name);

		void OnProcessingInstruction(string name, string text);

		void OnChars(string text);

		void OnIgnorableWhitespace(string text);
	}

	public interface IAttrList
	{
		int Length { get; }

		string[] Names { get; }

		string[] Values { get; }

		string GetName(int i);

		string GetValue(int i);

		string GetValue(string name);
	}

	private class AttrListImpl : IAttrList
	{
		private List<string> attrNames;

		private List<string> attrValues;

		public int Length => 0;

		public string[] Names => null;

		public string[] Values => null;

		public string GetName(int i)
		{
			return null;
		}

		public string GetValue(int i)
		{
			return null;
		}

		public string GetValue(string name)
		{
			return null;
		}

		internal void Clear()
		{
		}

		internal void Add(string name, string value)
		{
		}
	}

	private IContentHandler handler;

	private TextReader reader;

	private Stack elementNames;

	private Stack xmlSpaces;

	private string xmlSpace;

	private StringBuilder buffer;

	private char[] nameBuffer;

	private bool isWhitespace;

	private AttrListImpl attributes;

	private int line;

	private int column;

	private bool resetColumn;

	private Exception Error(string msg)
	{
		return null;
	}

	private Exception UnexpectedEndError()
	{
		return null;
	}

	private bool IsNameChar(char c, bool start)
	{
		return false;
	}

	private bool IsWhitespace(int c)
	{
		return false;
	}

	public void SkipWhitespaces()
	{
	}

	private void HandleWhitespaces()
	{
	}

	public void SkipWhitespaces(bool expected)
	{
	}

	private int Peek()
	{
		return 0;
	}

	private int Read()
	{
		return 0;
	}

	public void Expect(int c)
	{
	}

	private string ReadUntil(char until, bool handleReferences)
	{
		return null;
	}

	public string ReadName()
	{
		return null;
	}

	public void Parse(TextReader input, IContentHandler handler)
	{
	}

	private void Cleanup()
	{
	}

	public void ReadContent()
	{
	}

	private void HandleBufferedContent()
	{
	}

	private void ReadCharacters()
	{
	}

	private void ReadReference()
	{
	}

	private int ReadCharacterReference()
	{
		return 0;
	}

	private void ReadAttribute(AttrListImpl a)
	{
	}

	private void ReadCDATASection()
	{
	}

	private void ReadComment()
	{
	}
}
