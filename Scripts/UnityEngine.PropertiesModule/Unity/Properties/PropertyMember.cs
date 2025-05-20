using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.Properties;

internal readonly struct PropertyMember : IMemberInfo
{
	internal readonly PropertyInfo m_PropertyInfo;

	public string Name { get; }

	public bool IsReadOnly => false;

	public Type ValueType => null;

	public PropertyMember(PropertyInfo propertyInfo)
	{
		m_PropertyInfo = null;
		Name = null;
	}

	public IEnumerable<Attribute> GetCustomAttributes()
	{
		return null;
	}
}
