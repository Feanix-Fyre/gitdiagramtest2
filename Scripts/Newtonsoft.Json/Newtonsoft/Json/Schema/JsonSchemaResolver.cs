using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaResolver
{
	public IList<JsonSchema> LoadedSchemas { get; protected set; }

	public virtual JsonSchema GetSchema(string reference)
	{
		return null;
	}
}
