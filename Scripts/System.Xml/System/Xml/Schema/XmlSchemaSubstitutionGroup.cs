using System.Collections;
using System.Xml.Serialization;

namespace System.Xml.Schema;

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject
{
	private ArrayList membersList;

	private XmlQualifiedName examplar;

	[XmlIgnore]
	internal ArrayList Members => null;

	[XmlIgnore]
	internal XmlQualifiedName Examplar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
