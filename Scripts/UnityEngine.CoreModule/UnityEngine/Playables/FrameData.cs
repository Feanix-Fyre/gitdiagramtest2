using System;

namespace UnityEngine.Playables;

public struct FrameData
{
	[Flags]
	internal enum Flags
	{
		Evaluate = 1,
		SeekOccured = 2,
		Loop = 4,
		Hold = 8,
		EffectivePlayStateDelayed = 0x10,
		EffectivePlayStatePlaying = 0x20
	}

	public enum EvaluationType
	{
		Evaluate = 0,
		Playback = 1
	}

	internal ulong m_FrameID;

	internal double m_DeltaTime;

	internal float m_Weight;

	internal float m_EffectiveWeight;

	internal double m_EffectiveParentDelay;

	internal float m_EffectiveParentSpeed;

	internal float m_EffectiveSpeed;

	internal Flags m_Flags;

	internal PlayableOutput m_Output;

	public float deltaTime => 0f;

	public float effectiveSpeed => 0f;

	public EvaluationType evaluationType => default(EvaluationType);

	public bool seekOccurred => false;

	public bool timeLooped => false;

	public bool timeHeld => false;

	public PlayableOutput output => default(PlayableOutput);

	public PlayState effectivePlayState => default(PlayState);

	private bool HasFlags(Flags flag)
	{
		return false;
	}
}
