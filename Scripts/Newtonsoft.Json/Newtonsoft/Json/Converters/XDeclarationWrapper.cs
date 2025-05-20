using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
{
	internal XDeclaration Declaration { get; }

	public override XmlNodeType NodeType => default(XmlNodeType);

	public string? Version => null;

	public string? Encoding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string? Standalone
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public XDeclarationWrapper(XDeclaration declaration)
		: base(null)
	{
	}
}
