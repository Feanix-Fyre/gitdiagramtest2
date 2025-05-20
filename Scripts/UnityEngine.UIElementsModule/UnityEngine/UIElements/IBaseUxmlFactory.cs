using System;

namespace UnityEngine.UIElements;

public interface IBaseUxmlFactory
{
	string uxmlQualifiedName { get; }

	Type uxmlType { get; }

	bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
}
