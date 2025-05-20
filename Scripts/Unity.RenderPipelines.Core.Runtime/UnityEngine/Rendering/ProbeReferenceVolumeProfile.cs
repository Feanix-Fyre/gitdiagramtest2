namespace UnityEngine.Rendering;

public sealed class ProbeReferenceVolumeProfile : ScriptableObject
{
	internal enum Version
	{
		Initial = 0
	}

	[SerializeField]
	private Version version;

	[SerializeField]
	internal bool freezePlacement;

	[Range(2f, 5f)]
	public int simplificationLevels;

	[Min(0.1f)]
	public float minDistanceBetweenProbes;

	public LayerMask renderersLayerMask;

	[Min(0f)]
	public float minRendererVolumeSize;

	public int cellSizeInBricks => 0;

	public int maxSubdivision => 0;

	public float minBrickSize => 0f;

	public float cellSizeInMeters => 0f;

	private void OnEnable()
	{
	}

	public bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile)
	{
		return false;
	}
}
