using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics;

public class TransactionVirtualCurrency
{
	private static readonly string[] k_VirtualCurrencyTypeValues;

	public string VirtualCurrencyName;

	public VirtualCurrencyType VirtualCurrencyType;

	public long VirtualCurrencyAmount;

	internal void Serialize(IBuffer buffer)
	{
	}
}
