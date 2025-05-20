using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics;

public class TransactionItem
{
	public string ItemName;

	public string ItemType;

	public long ItemAmount;

	internal void Serialize(IBuffer buffer)
	{
	}
}
