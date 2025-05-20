namespace UnityEngine.Playables;

public static class PlayableOutputExtensions
{
	public static void SetReferenceObject<U>(this U output, Object value) where U : struct, IPlayableOutput
	{
	}

	public static void SetUserData<U>(this U output, Object value) where U : struct, IPlayableOutput
	{
	}

	public static Playable GetSourcePlayable<U>(this U output) where U : struct, IPlayableOutput
	{
		return default(Playable);
	}

	public static void SetSourcePlayable<U, V>(this U output, V value, int port) where U : struct, IPlayableOutput where V : struct, IPlayable
	{
	}

	public static int GetSourceOutputPort<U>(this U output) where U : struct, IPlayableOutput
	{
		return 0;
	}

	public static void SetWeight<U>(this U output, float value) where U : struct, IPlayableOutput
	{
	}

	public static void PushNotification<U>(this U output, Playable origin, INotification notification, object context = null) where U : struct, IPlayableOutput
	{
	}

	public static void AddNotificationReceiver<U>(this U output, INotificationReceiver receiver) where U : struct, IPlayableOutput
	{
	}
}
