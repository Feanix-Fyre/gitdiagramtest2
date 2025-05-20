using System;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq;

public class JTokenWriter : JsonWriter
{
	private JContainer? _token;

	private JContainer? _parent;

	private JValue? _value;

	private JToken? _current;

	public JToken? CurrentToken => null;

	public JToken? Token => null;

	internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
	{
		return null;
	}

	public JTokenWriter(JContainer container)
	{
	}

	public JTokenWriter()
	{
	}

	public override void Flush()
	{
	}

	public override void Close()
	{
	}

	public override void WriteStartObject()
	{
	}

	private void AddParent(JContainer container)
	{
	}

	private void RemoveParent()
	{
	}

	public override void WriteStartArray()
	{
	}

	public override void WriteStartConstructor(string name)
	{
	}

	protected override void WriteEnd(JsonToken token)
	{
	}

	public override void WritePropertyName(string name)
	{
	}

	private void AddRawValue(object? value, JTokenType type, JsonToken token)
	{
	}

	internal void AddJValue(JValue? value, JsonToken token)
	{
	}

	public override void WriteValue(object? value)
	{
	}

	public override void WriteNull()
	{
	}

	public override void WriteUndefined()
	{
	}

	public override void WriteRaw(string? json)
	{
	}

	public override void WriteComment(string? text)
	{
	}

	public override void WriteValue(string? value)
	{
	}

	public override void WriteValue(int value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(uint value)
	{
	}

	public override void WriteValue(long value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(ulong value)
	{
	}

	public override void WriteValue(float value)
	{
	}

	public override void WriteValue(double value)
	{
	}

	public override void WriteValue(bool value)
	{
	}

	public override void WriteValue(short value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(ushort value)
	{
	}

	public override void WriteValue(char value)
	{
	}

	public override void WriteValue(byte value)
	{
	}

	[CLSCompliant(false)]
	public override void WriteValue(sbyte value)
	{
	}

	public override void WriteValue(decimal value)
	{
	}

	public override void WriteValue(DateTime value)
	{
	}

	public override void WriteValue(DateTimeOffset value)
	{
	}

	public override void WriteValue(byte[]? value)
	{
	}

	public override void WriteValue(TimeSpan value)
	{
	}

	public override void WriteValue(Guid value)
	{
	}

	public override void WriteValue(Uri? value)
	{
	}

	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
	{
	}
}
