using System;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public sealed class InputRemoting : IObservable<InputRemoting.Message>, IObserver<InputRemoting.Message>
{
	public enum MessageType
	{
		Connect = 0,
		Disconnect = 1,
		NewLayout = 2,
		NewDevice = 3,
		NewEvents = 4,
		RemoveDevice = 5,
		RemoveLayout = 6,
		ChangeUsages = 7,
		StartSending = 8,
		StopSending = 9
	}

	public struct Message
	{
		public int participantId;

		public MessageType type;

		public byte[] data;
	}

	[Flags]
	private enum Flags
	{
		Sending = 1,
		StartSendingOnConnect = 2
	}

	[Serializable]
	internal struct RemoteSender
	{
		public int senderId;

		public InternedString[] layouts;

		public RemoteInputDevice[] devices;
	}

	[Serializable]
	internal struct RemoteInputDevice
	{
		public int remoteId;

		public int localId;

		public InputDeviceDescription description;
	}

	internal class Subscriber : IDisposable
	{
		public InputRemoting owner;

		public IObserver<Message> observer;

		public void Dispose()
		{
		}
	}

	private static class ConnectMsg
	{
		public static void Process(InputRemoting receiver)
		{
		}
	}

	private static class StartSendingMsg
	{
		public static void Process(InputRemoting receiver)
		{
		}
	}

	private static class StopSendingMsg
	{
		public static void Process(InputRemoting receiver)
		{
		}
	}

	private static class DisconnectMsg
	{
		public static void Process(InputRemoting receiver, Message msg)
		{
		}
	}

	private static class NewLayoutMsg
	{
		[Serializable]
		public struct Data
		{
			public string name;

			public string layoutJson;

			public bool isOverride;
		}

		public static Message? Create(InputRemoting sender, string layoutName)
		{
			return null;
		}

		public static void Process(InputRemoting receiver, Message msg)
		{
		}
	}

	private static class NewDeviceMsg
	{
		[Serializable]
		public struct Data
		{
			public string name;

			public string layout;

			public int deviceId;

			public string[] usages;

			public InputDeviceDescription description;
		}

		public static Message Create(InputDevice device)
		{
			return default(Message);
		}

		public static void Process(InputRemoting receiver, Message msg)
		{
		}
	}

	private static class NewEventsMsg
	{
		public static Message CreateResetEvent(InputDevice device, bool isHardReset)
		{
			return default(Message);
		}

		public static Message CreateStateEvent(InputDevice device)
		{
			return default(Message);
		}

		public unsafe static Message Create(InputEvent* events, int eventCount)
		{
			return default(Message);
		}

		public static void Process(InputRemoting receiver, Message msg)
		{
		}
	}

	private static class ChangeUsageMsg
	{
		[Serializable]
		public struct Data
		{
			public int deviceId;

			public string[] usages;
		}

		public static Message Create(InputDevice device)
		{
			return default(Message);
		}

		public static void Process(InputRemoting receiver, Message msg)
		{
		}
	}

	private static class RemoveDeviceMsg
	{
		public static Message Create(InputDevice device)
		{
			return default(Message);
		}

		public static void Process(InputRemoting receiver, Message msg)
		{
		}
	}

	private Flags m_Flags;

	private InputManager m_LocalManager;

	private Subscriber[] m_Subscribers;

	private RemoteSender[] m_Senders;

	public bool sending
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	internal InputManager manager => null;

	internal InputRemoting(InputManager manager, bool startSendingOnConnect = false)
	{
	}

	public void StartSending()
	{
	}

	public void StopSending()
	{
	}

	void IObserver<Message>.OnNext(Message msg)
	{
	}

	void IObserver<Message>.OnError(Exception error)
	{
	}

	void IObserver<Message>.OnCompleted()
	{
	}

	public IDisposable Subscribe(IObserver<Message> observer)
	{
		return null;
	}

	private void SendInitialMessages()
	{
	}

	private void SendAllGeneratedLayouts()
	{
	}

	private void SendLayout(string layoutName)
	{
	}

	private void SendAllDevices()
	{
	}

	private void SendDevice(InputDevice device)
	{
	}

	private void SendEvent(InputEventPtr eventPtr, InputDevice device)
	{
	}

	private void SendDeviceChange(InputDevice device, InputDeviceChange change)
	{
	}

	private void SendLayoutChange(string layout, InputControlLayoutChange change)
	{
	}

	private void Send(Message msg)
	{
	}

	private int FindOrCreateSenderRecord(int senderId)
	{
		return 0;
	}

	private static InternedString BuildLayoutNamespace(int senderId)
	{
		return default(InternedString);
	}

	private int FindLocalDeviceId(int remoteDeviceId, int senderIndex)
	{
		return 0;
	}

	private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex)
	{
		return null;
	}

	public void RemoveRemoteDevices(int participantId)
	{
	}

	private static byte[] SerializeData<TData>(TData data)
	{
		return null;
	}

	private static TData DeserializeData<TData>(byte[] data)
	{
		return default(TData);
	}
}
