namespace Unity.Services.Analytics;

public class AdImpressionEvent : Event
{
	private static readonly string[] k_AdPlacementTypeValues;

	private static readonly string[] k_AdProviderValues;

	private static readonly string[] k_AdCompletionStatusValues;

	public AdCompletionStatus AdCompletionStatus
	{
		set
		{
		}
	}

	public AdProvider AdProvider
	{
		set
		{
		}
	}

	public string PlacementId
	{
		set
		{
		}
	}

	public string PlacementName
	{
		set
		{
		}
	}

	public AdPlacementType PlacementType
	{
		set
		{
		}
	}

	public double AdEcpmUsd
	{
		set
		{
		}
	}

	public string AdStoreDestinationId
	{
		set
		{
		}
	}

	public string AdSdkVersion
	{
		set
		{
		}
	}

	public string AdImpressionId
	{
		set
		{
		}
	}

	public string AdMediaType
	{
		set
		{
		}
	}

	public long AdTimeWatchedMs
	{
		set
		{
		}
	}

	public long AdTimeCloseButtonShownMs
	{
		set
		{
		}
	}

	public long AdLengthMs
	{
		set
		{
		}
	}

	public bool AdHasClicked
	{
		set
		{
		}
	}

	public string AdSource
	{
		set
		{
		}
	}

	public string AdStatusCallback
	{
		set
		{
		}
	}

	public AdImpressionEvent()
		: base(null)
	{
	}

	public override void Validate()
	{
	}
}
