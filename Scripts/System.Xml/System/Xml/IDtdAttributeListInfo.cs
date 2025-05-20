using System.Collections.Generic;

namespace System.Xml;

internal interface IDtdAttributeListInfo
{
	bool HasNonCDataAttributes { get; }

	IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
}
