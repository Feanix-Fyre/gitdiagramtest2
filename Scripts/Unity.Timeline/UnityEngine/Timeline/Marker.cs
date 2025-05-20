namespace UnityEngine.Timeline;

public abstract class Marker : ScriptableObject, IMarker
{
	[TimeField(TimeFieldAttribute.UseEditMode.ApplyEditMode)]
	[SerializeField]
	[Tooltip("Time for the marker")]
	private double m_Time;

	public TrackAsset parent { get; private set; }

	public double time
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	void IMarker.Initialize(TrackAsset parentTrack)
	{
	}

	public virtual void OnInitialize(TrackAsset aPent)
	{
	}
}
