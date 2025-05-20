using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
[RequireComponent(typeof(Transform))]
public sealed class SortingGroup : Behaviour
{
	[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
	internal static int invalidSortingGroupID => 0;

	public int sortingLayerID => 0;

	public int sortingOrder => 0;

	[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
	internal static SortingGroup GetSortingGroupByIndex(int index)
	{
		return null;
	}
}
