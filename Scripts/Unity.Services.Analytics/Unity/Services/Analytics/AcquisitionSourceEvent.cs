namespace Unity.Services.Analytics;

public class AcquisitionSourceEvent : Event
{
	public string AcquisitionChannel
	{
		set
		{
		}
	}

	public string AcquisitionCampaignId
	{
		set
		{
		}
	}

	public string AcquisitionCreativeId
	{
		set
		{
		}
	}

	public string AcquisitionCampaignName
	{
		set
		{
		}
	}

	public string AcquisitionProvider
	{
		set
		{
		}
	}

	public float AcquisitionCost
	{
		set
		{
		}
	}

	public string AcquisitionCostCurrency
	{
		set
		{
		}
	}

	public string AcquisitionNetwork
	{
		set
		{
		}
	}

	public string AcquisitionCampaignType
	{
		set
		{
		}
	}

	public AcquisitionSourceEvent()
		: base(null)
	{
	}

	public override void Validate()
	{
	}
}
