using System.Collections.Generic;
using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics;

public class TransactionEvent : Event
{
	private static readonly string[] k_TransactionTypeValues;

	private static readonly string[] k_TransactionServerValues;

	public string TransactionName
	{
		set
		{
		}
	}

	public string TransactionId
	{
		set
		{
		}
	}

	public TransactionType TransactionType
	{
		set
		{
		}
	}

	public string PaymentCountry
	{
		set
		{
		}
	}

	public string ProductId
	{
		set
		{
		}
	}

	public string StoreItemSkuId
	{
		set
		{
		}
	}

	public string StoreItemId
	{
		set
		{
		}
	}

	public string StoreId
	{
		set
		{
		}
	}

	public string StoreSourceId
	{
		set
		{
		}
	}

	public string TransactionReceipt
	{
		set
		{
		}
	}

	public string TransactionReceiptSignature
	{
		set
		{
		}
	}

	public TransactionServer TransactionServer
	{
		set
		{
		}
	}

	public string TransactorID
	{
		set
		{
		}
	}

	public TransactionRealCurrency SpentRealCurrency { get; set; }

	public List<TransactionVirtualCurrency> SpentVirtualCurrencies { get; private set; }

	public List<TransactionItem> SpentItems { get; private set; }

	public TransactionRealCurrency ReceivedRealCurrency { get; set; }

	public List<TransactionVirtualCurrency> ReceivedVirtualCurrencies { get; private set; }

	public List<TransactionItem> ReceivedItems { get; private set; }

	public TransactionEvent()
		: base(null)
	{
	}

	protected internal TransactionEvent(string name)
		: base(null)
	{
	}

	internal override void Serialize(IBuffer buffer)
	{
	}

	public override void Validate()
	{
	}

	public override void Reset()
	{
	}
}
