using System;
using System.Collections.Generic;

namespace Unity.Properties;

internal interface IMemberInfo
{
	string Name { get; }

	bool IsReadOnly { get; }

	Type ValueType { get; }

	IEnumerable<Attribute> GetCustomAttributes();
}
