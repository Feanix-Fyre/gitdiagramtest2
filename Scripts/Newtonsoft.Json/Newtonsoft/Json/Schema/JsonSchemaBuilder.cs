using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaBuilder
{
	private readonly IList<JsonSchema> _stack;

	private readonly JsonSchemaResolver _resolver;

	private readonly IDictionary<string, JsonSchema> _documentSchemas;

	private JsonSchema _currentSchema;

	private JObject _rootSchema;

	private JsonSchema CurrentSchema => null;

	public JsonSchemaBuilder(JsonSchemaResolver resolver)
	{
	}

	private void Push(JsonSchema value)
	{
	}

	private JsonSchema Pop()
	{
		return null;
	}

	internal JsonSchema Read(JsonReader reader)
	{
		return null;
	}

	private string UnescapeReference(string reference)
	{
		return null;
	}

	private JsonSchema ResolveReferences(JsonSchema schema)
	{
		return null;
	}

	private JsonSchema BuildSchema(JToken token)
	{
		return null;
	}

	private void ProcessSchemaProperties(JObject schemaObject)
	{
	}

	private void ProcessExtends(JToken token)
	{
	}

	private void ProcessEnum(JToken token)
	{
	}

	private void ProcessAdditionalProperties(JToken token)
	{
	}

	private void ProcessAdditionalItems(JToken token)
	{
	}

	private IDictionary<string, JsonSchema> ProcessProperties(JToken token)
	{
		return null;
	}

	private void ProcessItems(JToken token)
	{
	}

	private JsonSchemaType? ProcessType(JToken token)
	{
		return null;
	}

	internal static JsonSchemaType MapType(string type)
	{
		return default(JsonSchemaType);
	}

	internal static string MapType(JsonSchemaType type)
	{
		return null;
	}
}
