using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public static class Extensions
{
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool IsValid(this JToken source, JsonSchema schema)
	{
		return false;
	}

	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool IsValid(this JToken source, JsonSchema schema, out IList<string> errorMessages)
	{
		errorMessages = null;
		return false;
	}

	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void Validate(this JToken source, JsonSchema schema)
	{
	}

	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
	{
	}
}
