using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model;

[DataContract]
public class PatchSessionModel
{
	[JsonProperty(PropertyName = "ip_list")]
	[DataMember(Name = "ip_list", EmitDefaultValue = false)]
	public List<string> IpList { get; set; }

	public override string ToString()
	{
		return null;
	}

	public string ToJson()
	{
		return null;
	}
}
