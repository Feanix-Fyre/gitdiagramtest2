namespace System.Globalization;

internal struct HebrewNumberParsingContext
{
	internal HebrewNumber.HS state;

	internal int result;

	public HebrewNumberParsingContext(int result)
	{
		state = default(HebrewNumber.HS);
		this.result = 0;
	}
}
