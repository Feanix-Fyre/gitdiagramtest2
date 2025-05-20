using System;
using System.Collections.Generic;

namespace Unity.Properties.Internal;

internal interface IAttributes
{
	void AddAttribute(Attribute attribute);

	void AddAttributes(IEnumerable<Attribute> attributes);
}
