using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public struct StylePropertyNameCollection : IEnumerable<StylePropertyName>, IEnumerable
{
	public struct Enumerator : IEnumerator<StylePropertyName>, IEnumerator, IDisposable
	{
		private List<StylePropertyName>.Enumerator m_Enumerator;

		public StylePropertyName Current => default(StylePropertyName);

		object IEnumerator.Current => null;

		internal Enumerator(List<StylePropertyName>.Enumerator enumerator)
		{
			m_Enumerator = default(List<StylePropertyName>.Enumerator);
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	internal List<StylePropertyName> propertiesList;

	internal StylePropertyNameCollection(List<StylePropertyName> list)
	{
		propertiesList = null;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<StylePropertyName> IEnumerable<StylePropertyName>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
