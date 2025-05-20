using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class PrefabControlPlayable : PlayableBehaviour
{
	private GameObject m_Instance;

	public GameObject prefabInstance => null;

	public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform)
	{
		return default(ScriptPlayable<PrefabControlPlayable>);
	}

	public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform)
	{
		return null;
	}

	public override void OnPlayableDestroy(Playable playable)
	{
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	private static void SetHideFlagsRecursive(GameObject gameObject)
	{
	}
}
