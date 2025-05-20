using System.Collections.Generic;

namespace Unity.Services.Analytics;

internal class TransactionCurrencyConverter
{
	private readonly Dictionary<string, int> m_Iso4217CurrencyMinorUnits;

	public long Convert(string currencyCode, double value)
	{
		return 0L;
	}
}
