using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements;

internal class StyleVariableResolver
{
	private enum Result
	{
		Valid = 0,
		Invalid = 1,
		NotFound = 2
	}

	private struct ResolveContext
	{
		public StyleSheet sheet;

		public StyleValueHandle[] handles;
	}

	internal const int kMaxResolves = 100;

	private static StyleSyntaxParser s_SyntaxParser;

	private StylePropertyValueMatcher m_Matcher;

	private List<StylePropertyValue> m_ResolvedValues;

	private Stack<string> m_ResolvedVarStack;

	private StyleProperty m_Property;

	private Stack<ResolveContext> m_ContextStack;

	private ResolveContext m_CurrentContext;

	private StyleSheet currentSheet => null;

	private StyleValueHandle[] currentHandles => null;

	public List<StylePropertyValue> resolvedValues => null;

	public StyleVariableContext variableContext { get; set; }

	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles)
	{
	}

	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles)
	{
	}

	private void PopContext()
	{
	}

	public void AddValue(StyleValueHandle handle)
	{
	}

	public bool ResolveVarFunction(ref int index)
	{
		return false;
	}

	private Result ResolveVarFunction(ref int index, int argc, string varName)
	{
		return default(Result);
	}

	public bool ValidateResolvedValues()
	{
		return false;
	}

	private Result ResolveVariable(string variableName)
	{
		return default(Result);
	}

	private Result ResolveFallback(ref int index)
	{
		return default(Result);
	}

	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName)
	{
		argCount = default(int);
		variableName = null;
	}
}
