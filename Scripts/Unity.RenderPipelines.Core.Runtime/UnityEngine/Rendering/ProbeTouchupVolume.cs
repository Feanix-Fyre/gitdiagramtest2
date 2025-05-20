namespace UnityEngine.Rendering;

[ExecuteAlways]
[AddComponentMenu("Rendering/Probe Volume Touchup")]
public class ProbeTouchupVolume : MonoBehaviour
{
	[Range(0.0001f, 2f)]
	public float intensityScale;

	public bool invalidateProbes;

	public bool overrideDilationThreshold;

	[Range(0f, 0.99f)]
	public float overriddenDilationThreshold;

	public Vector3 size;
}
