using System;
using System.IO;

namespace Newtonsoft.Json.Serialization;

internal class TraceJsonReader : JsonReader, IJsonLineInfo
{
	private readonly JsonReader _innerReader;

	private readonly JsonTextWriter _textWriter;

	private readonly StringWriter _sw;

	public override int Depth => 0;

	public override string Path => null;

	public override char QuoteChar
	{
		get
		{
			return '\0';
		}
		protected internal set
		{
		}
	}

	public override JsonToken TokenType => default(JsonToken);

	public override object? Value => null;

	public override Type? ValueType => null;

	int IJsonLineInfo.LineNumber => 0;

	int IJsonLineInfo.LinePosition => 0;

	public TraceJsonReader(JsonReader innerReader)
	{
	}

	public string GetDeserializedJsonMessage()
	{
		return null;
	}

	public override bool Read()
	{
		return false;
	}

	public override int? ReadAsInt32()
	{
		return null;
	}

	public override string? ReadAsString()
	{
		return null;
	}

	public override byte[]? ReadAsBytes()
	{
		return null;
	}

	public override decimal? ReadAsDecimal()
	{
		return null;
	}

	public override double? ReadAsDouble()
	{
		return null;
	}

	public override bool? ReadAsBoolean()
	{
		return null;
	}

	public override DateTime? ReadAsDateTime()
	{
		return null;
	}

	public override DateTimeOffset? ReadAsDateTimeOffset()
	{
		return null;
	}

	public void WriteCurrentToken()
	{
	}

	public override void Close()
	{
	}

	bool IJsonLineInfo.HasLineInfo()
	{
		return false;
	}
}
