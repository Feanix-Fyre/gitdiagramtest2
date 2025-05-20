using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using JetBrains.Annotations;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator;

[Serializable]
public class CGBoundsGroup : CGWeightedItem
{
	public enum RotationModeEnum
	{
		Full = 0,
		Direction = 1,
		Horizontal = 2,
		Independent = 3
	}

	[UsedImplicitly]
	[Obsolete("Enum no more used by Curvy. This enum is kept for retro compatibility reasons")]
	private enum DistributionModeEnum
	{
		[UsedImplicitly]
		Parent = 0,
		Self = 1
	}

	[SerializeField]
	private string m_Name;

	[Tooltip("When checked, the group will only be placed when all the group's items can be placed in the space left")]
	[SerializeField]
	private bool m_KeepTogether;

	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	[SerializeField]
	private FloatRegion m_SpaceBefore;

	[SerializeField]
	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	private FloatRegion m_SpaceAfter;

	[FloatRegion(RegionIsOptional = true, RegionOptionsPropertyName = "PositionRangeOptions", UseSlider = true, Precision = 3)]
	[SerializeField]
	private FloatRegion m_CrossBase;

	[SerializeField]
	[Tooltip("If ticked, the Cross origin for this group will not take into consideration the Cross parameters in the General tab")]
	private bool m_IgnoreModuleCrossBase;

	[Tooltip("When enabled, items will be selected randomly")]
	[SerializeField]
	private bool m_RandomizeItems;

	[SerializeField]
	[IntRegion(UseSlider = false, RegionOptionsPropertyName = "RepeatingGroupsOptions", Options = AttributeOptionsFlags.Compact)]
	[Tooltip("The randomized items are the the ones that have their indices inside this range")]
	private IntRegion m_RepeatingItems;

	[SerializeField]
	[Tooltip("If unchecked, translation will be done in the global/world space")]
	private bool m_RelativeTranslation;

	[SerializeField]
	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	private FloatRegion m_TranslationX;

	[SerializeField]
	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	private FloatRegion m_TranslationY;

	[SerializeField]
	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	private FloatRegion m_TranslationZ;

	[SerializeField]
	[Tooltip("How the rotation axes are defined related to the Volume's data\r\n  - Full : Use Volume's direction and orientation\r\n  - Direction : Use Volume's direction only\r\n  - Horizontal : Use Volume's direction only after projecting it on XZ plane\r\n  - Independent : Do not use Volume's data")]
	private RotationModeEnum m_RotationMode;

	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	[SerializeField]
	private FloatRegion m_RotationX;

	[SerializeField]
	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	private FloatRegion m_RotationY;

	[SerializeField]
	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	private FloatRegion m_RotationZ;

	[Tooltip("Whether the scaling is applied equally on all dimensions")]
	[SerializeField]
	private bool m_UniformScaling;

	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	[SerializeField]
	private FloatRegion m_ScaleX;

	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	[SerializeField]
	private FloatRegion m_ScaleY;

	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	[SerializeField]
	private FloatRegion m_ScaleZ;

	[SerializeField]
	private List<CGBoundsGroupItem> m_Items;

	[SerializeField]
	[HideInInspector]
	[UsedImplicitly]
	[Obsolete("Use IgnoreModuleCrossBase instead. This field is kept for retro compatibility reasons")]
	private DistributionModeEnum m_DistributionMode;

	[HideInInspector]
	[Obsolete("Use CrossBase instead. This field is kept for retro compatibility reasons")]
	[FloatRegion(RegionIsOptional = true, RegionOptionsPropertyName = "PositionRangeOptions", UseSlider = true, Precision = 3)]
	[SerializeField]
	[UsedImplicitly]
	private FloatRegion m_PositionOffset;

	[FloatRegion(RegionIsOptional = true, Options = AttributeOptionsFlags.Compact)]
	[HideInInspector]
	[UsedImplicitly]
	[Obsolete("Use TranslationY instead, while setting RelativeTranslation to true. This field is kept for retro compatibility reasons")]
	[SerializeField]
	private FloatRegion m_Height;

	[SerializeField]
	[HideInInspector]
	[UsedImplicitly]
	[Obsolete("Use RandomizeItems instead. This field is kept for retro compatibility reasons")]
	private CurvyRepeatingOrderEnum m_RepeatingOrder;

	[Obsolete("Use RotationX, RotationY and RotationZ instead. This field is kept for retro compatibility reasons")]
	[SerializeField]
	[UsedImplicitly]
	[HideInInspector]
	[VectorEx(null, null)]
	private Vector3 m_RotationOffset;

	[UsedImplicitly]
	[Obsolete("Use RotationX, RotationY and RotationZ instead. This field is kept for retro compatibility reasons")]
	[VectorEx(null, null)]
	[SerializeField]
	[HideInInspector]
	private Vector3 m_RotationScatter;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool KeepTogether
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FloatRegion SpaceBefore
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public FloatRegion SpaceAfter
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public bool RandomizeItems
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public IntRegion RepeatingItems
	{
		get
		{
			return default(IntRegion);
		}
		set
		{
		}
	}

	public FloatRegion CrossBase
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public bool IgnoreModuleCrossBase
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public RotationModeEnum RotationMode
	{
		get
		{
			return default(RotationModeEnum);
		}
		set
		{
		}
	}

	public FloatRegion RotationX
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public FloatRegion RotationY
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public FloatRegion RotationZ
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public bool UniformScaling
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FloatRegion ScaleX
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public FloatRegion ScaleY
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public FloatRegion ScaleZ
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public bool RelativeTranslation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FloatRegion TranslationX
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public FloatRegion TranslationY
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public FloatRegion TranslationZ
	{
		get
		{
			return default(FloatRegion);
		}
		set
		{
		}
	}

	public List<CGBoundsGroupItem> Items => null;

	public int FirstRepeating
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LastRepeating
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ItemCount => 0;

	private RegionOptions<int> RepeatingGroupsOptions => default(RegionOptions<int>);

	private RegionOptions<float> PositionRangeOptions => default(RegionOptions<float>);

	public CGBoundsGroup(string name)
	{
	}

	public static void FillItemBag(WeightedRandom<int> bag, IEnumerable<CGWeightedItem> itemsWeights, int firstItem, int lastItem)
	{
	}

	[Obsolete("Method will get removed once the obsolete data will get removed")]
	[UsedImplicitly]
	public void ConvertObsoleteData()
	{
	}
}
