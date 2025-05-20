namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal struct ExpressionMultiplier
{
	public const int Infinity = 100;

	private ExpressionMultiplierType m_Type;

	public int min;

	public int max;

	public ExpressionMultiplierType type
	{
		get
		{
			return default(ExpressionMultiplierType);
		}
		set
		{
		}
	}

	public ExpressionMultiplier(ExpressionMultiplierType type = ExpressionMultiplierType.None)
	{
		m_Type = default(ExpressionMultiplierType);
		min = 0;
		max = 0;
	}

	private void SetType(ExpressionMultiplierType value)
	{
	}
}
