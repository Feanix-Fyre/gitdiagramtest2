using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public struct UQueryState<T> : IEnumerable<T>, IEnumerable, IEquatable<UQueryState<T>> where T : VisualElement
{
	private class ListQueryMatcher<TElement> : UQuery.UQueryMatcher where TElement : VisualElement
	{
		public List<TElement> matches { get; set; }

		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private class ActionQueryMatcher : UQuery.UQueryMatcher
	{
		internal Action<T> callBack { get; }

		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return false;
		}
	}

	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private List<VisualElement> iterationList;

		private int currentIndex;

		public T Current => null;

		object IEnumerator.Current => null;

		internal Enumerator(UQueryState<T> queryState)
		{
			iterationList = null;
			currentIndex = 0;
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

	private static ActionQueryMatcher s_Action;

	private readonly VisualElement m_Element;

	internal readonly List<RuleMatcher> m_Matchers;

	private static readonly ListQueryMatcher<T> s_List;

	private static readonly ListQueryMatcher<VisualElement> s_EnumerationList;

	internal UQueryState(VisualElement element, List<RuleMatcher> matchers)
	{
		m_Element = null;
		m_Matchers = null;
	}

	public UQueryState<T> RebuildOn(VisualElement element)
	{
		return default(UQueryState<T>);
	}

	private T Single(UQuery.SingleQueryMatcher matcher)
	{
		return null;
	}

	public T First()
	{
		return null;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool Equals(UQueryState<T> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
