namespace Unity.Services.Analytics;

public class TransactionFailedEvent : TransactionEvent
{
	public string FailureReason
	{
		set
		{
		}
	}

	public override void Validate()
	{
	}
}
