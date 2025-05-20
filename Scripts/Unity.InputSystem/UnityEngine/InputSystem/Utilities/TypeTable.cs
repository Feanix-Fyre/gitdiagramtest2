using System;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

internal struct TypeTable
{
	public Dictionary<InternedString, Type> table;

	public IEnumerable<string> names => null;

	public IEnumerable<InternedString> internedNames => null;

	public void Initialize()
	{
	}

	public InternedString FindNameForType(Type type)
	{
		return default(InternedString);
	}

	public void AddTypeRegistration(string name, Type type)
	{
	}

	public Type LookupTypeRegistration(string name)
	{
		return null;
	}
}
