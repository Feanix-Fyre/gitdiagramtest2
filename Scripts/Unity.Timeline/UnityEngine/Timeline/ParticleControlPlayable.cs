using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class ParticleControlPlayable : PlayableBehaviour
{
	private const float kUnsetTime = float.MaxValue;

	private float m_LastPlayableTime;

	private float m_LastParticleTime;

	private uint m_RandomSeed;

	public ParticleSystem particleSystem { get; private set; }

	public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed)
	{
		return default(ScriptPlayable<ParticleControlPlayable>);
	}

	public void Initialize(ParticleSystem ps, uint randomSeed)
	{
	}

	private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData data)
	{
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	private void Simulate(float time, bool restart)
	{
	}
}
