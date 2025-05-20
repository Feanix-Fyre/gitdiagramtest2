using System;

namespace UnityEngine.UIElements;

public abstract class BaseUxmlFactory<TCreatedType, TTraits> where TCreatedType : new() where TTraits : BaseUxmlTraits, new()
{
	internal TTraits m_Traits;

	public virtual string uxmlName => null;

	public virtual string uxmlNamespace => null;

	public virtual string uxmlQualifiedName => null;

	public virtual Type uxmlType => null;

	public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc)
	{
		return false;
	}
}
