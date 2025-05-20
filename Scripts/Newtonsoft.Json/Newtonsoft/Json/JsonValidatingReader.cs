using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Newtonsoft.Json;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonValidatingReader : JsonReader, IJsonLineInfo
{
	private class SchemaScope
	{
		private readonly JTokenType _tokenType;

		private readonly IList<JsonSchemaModel> _schemas;

		private readonly Dictionary<string, bool> _requiredProperties;

		public string CurrentPropertyName { get; set; }

		public int ArrayItemCount { get; set; }

		public bool IsUniqueArray { get; }

		public IList<JToken> UniqueArrayItems { get; }

		public JTokenWriter CurrentItemWriter { get; set; }

		public IList<JsonSchemaModel> Schemas => null;

		public Dictionary<string, bool> RequiredProperties => null;

		public JTokenType TokenType => default(JTokenType);

		public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas)
		{
		}

		private IEnumerable<string> GetRequiredProperties(JsonSchemaModel schema)
		{
			return null;
		}
	}

	private readonly JsonReader _reader;

	private readonly Stack<SchemaScope> _stack;

	private JsonSchema _schema;

	private JsonSchemaModel _model;

	private SchemaScope _currentScope;

	private static readonly IList<JsonSchemaModel> EmptySchemaList;

	public override object Value => null;

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

	public override Type ValueType => null;

	private IList<JsonSchemaModel> CurrentSchemas => null;

	private IList<JsonSchemaModel> CurrentMemberSchemas => null;

	public JsonSchema Schema
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JsonReader Reader => null;

	int IJsonLineInfo.LineNumber => 0;

	int IJsonLineInfo.LinePosition => 0;

	public event ValidationEventHandler ValidationEventHandler
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Push(SchemaScope scope)
	{
	}

	private SchemaScope Pop()
	{
		return null;
	}

	private void RaiseError(string message, JsonSchemaModel schema)
	{
	}

	private void OnValidationEvent(JsonSchemaException exception)
	{
	}

	public JsonValidatingReader(JsonReader reader)
	{
	}

	public override void Close()
	{
	}

	private void ValidateNotDisallowed(JsonSchemaModel schema)
	{
	}

	private JsonSchemaType? GetCurrentNodeSchemaType()
	{
		return null;
	}

	public override int? ReadAsInt32()
	{
		return null;
	}

	public override byte[] ReadAsBytes()
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

	public override string ReadAsString()
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

	public override bool Read()
	{
		return false;
	}

	private void ValidateCurrentToken()
	{
	}

	private void WriteToken(IList<JsonSchemaModel> schemas)
	{
	}

	private void ValidateEndObject(JsonSchemaModel schema)
	{
	}

	private void ValidateEndArray(JsonSchemaModel schema)
	{
	}

	private void ValidateNull(JsonSchemaModel schema)
	{
	}

	private void ValidateBoolean(JsonSchemaModel schema)
	{
	}

	private void ValidateString(JsonSchemaModel schema)
	{
	}

	private void ValidateInteger(JsonSchemaModel schema)
	{
	}

	private void ProcessValue()
	{
	}

	private void ValidateFloat(JsonSchemaModel schema)
	{
	}

	private static double FloatingPointRemainder(double dividend, double divisor)
	{
		return 0.0;
	}

	private static bool IsZero(double value)
	{
		return false;
	}

	private void ValidatePropertyName(JsonSchemaModel schema)
	{
	}

	private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName)
	{
		return false;
	}

	private bool ValidateArray(JsonSchemaModel schema)
	{
		return false;
	}

	private bool ValidateObject(JsonSchemaModel schema)
	{
		return false;
	}

	private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType)
	{
		return false;
	}

	bool IJsonLineInfo.HasLineInfo()
	{
		return false;
	}
}
