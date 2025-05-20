using System;

namespace UnityEngine.UIElements;

[Serializable]
public class DynamicAtlasSettings
{
	[SerializeField]
	[HideInInspector]
	private int m_MinAtlasSize;

	[HideInInspector]
	[SerializeField]
	private int m_MaxAtlasSize;

	[SerializeField]
	[HideInInspector]
	private int m_MaxSubTextureSize;

	[SerializeField]
	[HideInInspector]
	private DynamicAtlasFilters m_ActiveFilters;

	private DynamicAtlasCustomFilter m_CustomFilter;

	public int minAtlasSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int maxAtlasSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int maxSubTextureSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public DynamicAtlasFilters activeFilters
	{
		get
		{
			return default(DynamicAtlasFilters);
		}
		set
		{
		}
	}

	public static DynamicAtlasFilters defaultFilters => default(DynamicAtlasFilters);

	public DynamicAtlasCustomFilter customFilter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static DynamicAtlasSettings defaults => null;
}
