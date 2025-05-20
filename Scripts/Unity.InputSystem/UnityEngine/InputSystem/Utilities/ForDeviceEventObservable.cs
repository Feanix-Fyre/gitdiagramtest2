using System;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Utilities;

internal class ForDeviceEventObservable : IObservable<InputEventPtr>
{
	private class ForDevice : IObserver<InputEventPtr>
	{
		private IObserver<InputEventPtr> m_Observer;

		private InputDevice m_Device;

		private Type m_DeviceType;

		public ForDevice(Type deviceType, InputDevice device, IObserver<InputEventPtr> observer)
		{
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(InputEventPtr value)
		{
		}
	}

	private IObservable<InputEventPtr> m_Source;

	private InputDevice m_Device;

	private Type m_DeviceType;

	public ForDeviceEventObservable(IObservable<InputEventPtr> source, Type deviceType, InputDevice device)
	{
	}

	public IDisposable Subscribe(IObserver<InputEventPtr> observer)
	{
		return null;
	}
}
