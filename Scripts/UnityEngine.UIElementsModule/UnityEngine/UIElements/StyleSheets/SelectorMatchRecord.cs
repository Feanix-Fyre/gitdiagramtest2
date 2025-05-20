namespace UnityEngine.UIElements.StyleSheets;

internal struct SelectorMatchRecord
{
	public StyleSheet sheet;

	public int styleSheetIndexInStack;

	public StyleComplexSelector complexSelector;

	public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack)
	{
		this.sheet = null;
		this.styleSheetIndexInStack = 0;
		complexSelector = null;
	}

	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b)
	{
		return 0;
	}
}
