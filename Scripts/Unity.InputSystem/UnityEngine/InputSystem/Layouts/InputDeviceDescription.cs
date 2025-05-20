using System;

namespace UnityEngine.InputSystem.Layouts;

[Serializable]
public struct InputDeviceDescription : IEquatable<InputDeviceDescription>
{
	private struct DeviceDescriptionJson
	{
		public string @interface;

		public string type;

		public string product;

		public string serial;

		public string version;

		public string manufacturer;

		public string capabilities;
	}

	[SerializeField]
	private string m_InterfaceName;

	[SerializeField]
	private string m_DeviceClass;

	[SerializeField]
	private string m_Manufacturer;

	[SerializeField]
	private string m_Product;

	[SerializeField]
	private string m_Serial;

	[SerializeField]
	private string m_Version;

	[SerializeField]
	private string m_Capabilities;

	public string interfaceName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string deviceClass
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string manufacturer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string product
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string serial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string version
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string capabilities
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool empty => false;

	public override string ToString()
	{
		return null;
	}

	public bool Equals(InputDeviceDescription other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(InputDeviceDescription left, InputDeviceDescription right)
	{
		return false;
	}

	public static bool operator !=(InputDeviceDescription left, InputDeviceDescription right)
	{
		return false;
	}

	public string ToJson()
	{
		return null;
	}

	public static InputDeviceDescription FromJson(string json)
	{
		return default(InputDeviceDescription);
	}

	internal static bool ComparePropertyToDeviceDescriptor(string propertyName, string propertyValue, string deviceDescriptor)
	{
		return false;
	}
}
