using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaWriter
{
	private readonly JsonWriter _writer;

	private readonly JsonSchemaResolver _resolver;

	public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver)
	{
	}

	private void ReferenceOrWriteSchema(JsonSchema schema)
	{
	}

	public void WriteSchema(JsonSchema schema)
	{
	}

	private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<string, JsonSchema> properties)
	{
	}

	private void WriteItems(JsonSchema schema)
	{
	}

	private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type)
	{
	}

	private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value)
	{
	}
}
