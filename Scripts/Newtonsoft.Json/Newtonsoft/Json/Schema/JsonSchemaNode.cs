using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNode
{
	public string Id { get; }

	public ReadOnlyCollection<JsonSchema> Schemas { get; }

	public Dictionary<string, JsonSchemaNode> Properties { get; }

	public Dictionary<string, JsonSchemaNode> PatternProperties { get; }

	public List<JsonSchemaNode> Items { get; }

	public JsonSchemaNode AdditionalProperties { get; set; }

	public JsonSchemaNode AdditionalItems { get; set; }

	public JsonSchemaNode(JsonSchema schema)
	{
	}

	private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
	{
	}

	public JsonSchemaNode Combine(JsonSchema schema)
	{
		return null;
	}

	public static string GetId(IEnumerable<JsonSchema> schemata)
	{
		return null;
	}
}
