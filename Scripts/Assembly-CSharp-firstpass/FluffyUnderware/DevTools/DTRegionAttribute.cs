namespace FluffyUnderware.DevTools;

public class DTRegionAttribute : DTPropertyAttribute
{
	public bool RegionIsOptional;

	public string RegionOptionsPropertyName;

	public bool UseSlider;

	public DTRegionAttribute()
		: base(null, null)
	{
	}
}
