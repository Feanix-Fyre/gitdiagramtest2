using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics;

public class TransactionRealCurrency
{
	public string RealCurrencyType;

	public long RealCurrencyAmount;

	internal void Serialize(IBuffer buffer)
	{
	}
}
