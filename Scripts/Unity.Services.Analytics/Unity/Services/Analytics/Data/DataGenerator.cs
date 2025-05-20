using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics.Data;

internal class DataGenerator : IDataGenerator
{
	internal enum SessionEndState
	{
		PAUSED = 0,
		KILLEDINBACKGROUND = 1,
		KILLEDINFOREGROUND = 2,
		QUIT = 3
	}

	private readonly IBuffer m_Buffer;

	private readonly ICommonData m_CommonData;

	private readonly IDeviceData m_DeviceData;

	public DataGenerator(IBuffer buffer, ICommonData staticData, IDeviceData deviceData)
	{
	}

	public void SdkStartup(string callingMethodIdentifier)
	{
	}

	public void GameRunning(string callingMethodIdentifier)
	{
	}

	public void NewPlayer(string callingMethodIdentifier)
	{
	}

	public void GameStarted(string callingMethodIdentifier)
	{
	}

	public void GameEnded(string callingMethodIdentifier, SessionEndState quitState)
	{
	}

	public void ClientDevice(string callingMethodIdentifier)
	{
	}

	public void PushCommonParams(string callingMethodIdentifier)
	{
	}

	public void PushEvent(string callingMethodIdentifier, Event e)
	{
	}

	public void PushEmptyEvent(string name)
	{
	}
}
