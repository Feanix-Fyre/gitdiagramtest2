using System;

namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class ValidationEventArgs : EventArgs
{
	private readonly JsonSchemaException _ex;

	public JsonSchemaException Exception => null;

	public string Path => null;

	public string Message => null;

	internal ValidationEventArgs(JsonSchemaException ex)
	{
	}
}
