using System.Collections.Generic;

namespace Unity.Properties;

public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, IPropertyBag<TSet>, IPropertyBag where TSet : ISet<TElement>
{
	private class SetElementProperty : Property<TSet, TElement>
	{
		internal TElement m_Value;

		public override string Name => null;
	}

	private readonly SetElementProperty m_Property;
}
