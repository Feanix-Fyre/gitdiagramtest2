namespace UnityEngine.Playables;

public static class PlayableExtensions
{
	public static bool IsValid<U>(this U playable) where U : struct, IPlayable
	{
		return false;
	}

	public static PlayableGraph GetGraph<U>(this U playable) where U : struct, IPlayable
	{
		return default(PlayableGraph);
	}

	public static PlayState GetPlayState<U>(this U playable) where U : struct, IPlayable
	{
		return default(PlayState);
	}

	public static void Play<U>(this U playable) where U : struct, IPlayable
	{
	}

	public static void Pause<U>(this U playable) where U : struct, IPlayable
	{
	}

	public static void SetSpeed<U>(this U playable, double value) where U : struct, IPlayable
	{
	}

	public static void SetDuration<U>(this U playable, double value) where U : struct, IPlayable
	{
	}

	public static double GetDuration<U>(this U playable) where U : struct, IPlayable
	{
		return 0.0;
	}

	public static void SetTime<U>(this U playable, double value) where U : struct, IPlayable
	{
	}

	public static double GetTime<U>(this U playable) where U : struct, IPlayable
	{
		return 0.0;
	}

	public static double GetPreviousTime<U>(this U playable) where U : struct, IPlayable
	{
		return 0.0;
	}

	public static bool IsDone<U>(this U playable) where U : struct, IPlayable
	{
		return false;
	}

	public static void SetPropagateSetTime<U>(this U playable, bool value) where U : struct, IPlayable
	{
	}

	public static void SetInputCount<U>(this U playable, int value) where U : struct, IPlayable
	{
	}

	public static int GetInputCount<U>(this U playable) where U : struct, IPlayable
	{
		return 0;
	}

	public static Playable GetInput<U>(this U playable, int inputPort) where U : struct, IPlayable
	{
		return default(Playable);
	}

	public static void SetInputWeight<U>(this U playable, int inputIndex, float weight) where U : struct, IPlayable
	{
	}

	public static void SetInputWeight<U, V>(this U playable, V input, float weight) where U : struct, IPlayable where V : struct, IPlayable
	{
	}

	public static float GetInputWeight<U>(this U playable, int inputIndex) where U : struct, IPlayable
	{
		return 0f;
	}

	public static void SetTraversalMode<U>(this U playable, PlayableTraversalMode mode) where U : struct, IPlayable
	{
	}

	internal static DirectorWrapMode GetTimeWrapMode<U>(this U playable) where U : struct, IPlayable
	{
		return default(DirectorWrapMode);
	}

	internal static void SetTimeWrapMode<U>(this U playable, DirectorWrapMode value) where U : struct, IPlayable
	{
	}
}
