using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

public static class UQuery
{
	internal interface IVisualPredicateWrapper
	{
		bool Predicate(object e);
	}

	internal class IsOfType<T> : IVisualPredicateWrapper where T : VisualElement
	{
		public static IsOfType<T> s_Instance;

		public bool Predicate(object e)
		{
			return false;
		}
	}

	internal abstract class UQueryMatcher : HierarchyTraversal
	{
		internal List<RuleMatcher> m_Matchers;

		public override void Traverse(VisualElement element)
		{
		}

		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return false;
		}

		private static void NoProcessResult(VisualElement e, MatchResultInfo i)
		{
		}

		public override void TraverseRecursive(VisualElement element, int depth)
		{
		}

		public virtual void Run(VisualElement root, List<RuleMatcher> matchers)
		{
		}
	}

	internal abstract class SingleQueryMatcher : UQueryMatcher
	{
		public VisualElement match { get; set; }

		public override void Run(VisualElement root, List<RuleMatcher> matchers)
		{
		}

		public bool IsInUse()
		{
			return false;
		}

		public abstract SingleQueryMatcher CreateNew();
	}

	internal class FirstQueryMatcher : SingleQueryMatcher
	{
		public static readonly FirstQueryMatcher Instance;

		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return false;
		}

		public override SingleQueryMatcher CreateNew()
		{
			return null;
		}
	}
}
