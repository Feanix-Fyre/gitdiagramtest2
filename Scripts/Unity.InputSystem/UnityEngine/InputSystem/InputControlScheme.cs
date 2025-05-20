using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[Serializable]
public struct InputControlScheme : IEquatable<InputControlScheme>
{
	public struct MatchResult : IEnumerable<MatchResult.Match>, IEnumerable, IDisposable
	{
		internal enum Result
		{
			AllSatisfied = 0,
			MissingRequired = 1,
			MissingOptional = 2
		}

		public struct Match
		{
			internal int m_RequirementIndex;

			internal DeviceRequirement[] m_Requirements;

			internal InputControlList<InputControl> m_Controls;

			public InputControl control => null;

			public InputDevice device => null;

			public int requirementIndex => 0;

			public DeviceRequirement requirement => default(DeviceRequirement);

			public bool isOptional => false;
		}

		private struct Enumerator : IEnumerator<Match>, IEnumerator, IDisposable
		{
			internal int m_Index;

			internal DeviceRequirement[] m_Requirements;

			internal InputControlList<InputControl> m_Controls;

			public Match Current => default(Match);

			object IEnumerator.Current => null;

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		internal Result m_Result;

		internal float m_Score;

		internal InputControlList<InputDevice> m_Devices;

		internal InputControlList<InputControl> m_Controls;

		internal DeviceRequirement[] m_Requirements;

		public float score => 0f;

		public bool isSuccessfulMatch => false;

		public bool hasMissingRequiredDevices => false;

		public bool hasMissingOptionalDevices => false;

		public InputControlList<InputDevice> devices => default(InputControlList<InputDevice>);

		public Match this[int index] => default(Match);

		public IEnumerator<Match> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	public struct DeviceRequirement : IEquatable<DeviceRequirement>
	{
		[Flags]
		internal enum Flags
		{
			None = 0,
			Optional = 1,
			Or = 2
		}

		[SerializeField]
		internal string m_ControlPath;

		[SerializeField]
		internal Flags m_Flags;

		public string controlPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isOptional
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isAND
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isOR
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(DeviceRequirement other)
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

		public static bool operator ==(DeviceRequirement left, DeviceRequirement right)
		{
			return false;
		}

		public static bool operator !=(DeviceRequirement left, DeviceRequirement right)
		{
			return false;
		}
	}

	[Serializable]
	internal struct SchemeJson
	{
		[Serializable]
		public struct DeviceJson
		{
			public string devicePath;

			public bool isOptional;

			public bool isOR;

			public DeviceRequirement ToDeviceEntry()
			{
				return default(DeviceRequirement);
			}

			public static DeviceJson From(DeviceRequirement requirement)
			{
				return default(DeviceJson);
			}
		}

		public string name;

		public string bindingGroup;

		public DeviceJson[] devices;

		public InputControlScheme ToScheme()
		{
			return default(InputControlScheme);
		}

		public static SchemeJson ToJson(InputControlScheme scheme)
		{
			return default(SchemeJson);
		}

		public static SchemeJson[] ToJson(InputControlScheme[] schemes)
		{
			return null;
		}

		public static InputControlScheme[] ToSchemes(SchemeJson[] schemes)
		{
			return null;
		}
	}

	[SerializeField]
	internal string m_Name;

	[SerializeField]
	internal string m_BindingGroup;

	[SerializeField]
	internal DeviceRequirement[] m_DeviceRequirements;

	public string name => null;

	public string bindingGroup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<DeviceRequirement> deviceRequirements => default(ReadOnlyArray<DeviceRequirement>);

	public InputControlScheme(string name, IEnumerable<DeviceRequirement> devices = null, string bindingGroup = null)
	{
		m_Name = null;
		m_BindingGroup = null;
		m_DeviceRequirements = null;
	}

	internal void SetNameAndBindingGroup(string name, string bindingGroup = null)
	{
	}

	public static InputControlScheme? FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false) where TDevices : IReadOnlyList<InputDevice> where TSchemes : IEnumerable<InputControlScheme>
	{
		return null;
	}

	public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out MatchResult matchResult, InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false) where TDevices : IReadOnlyList<InputDevice> where TSchemes : IEnumerable<InputControlScheme>
	{
		controlScheme = default(InputControlScheme);
		matchResult = default(MatchResult);
		return false;
	}

	public static InputControlScheme? FindControlSchemeForDevice<TSchemes>(InputDevice device, TSchemes schemes) where TSchemes : IEnumerable<InputControlScheme>
	{
		return null;
	}

	public bool SupportsDevice(InputDevice device)
	{
		return false;
	}

	public MatchResult PickDevicesFrom<TDevices>(TDevices devices, InputDevice favorDevice = null) where TDevices : IReadOnlyList<InputDevice>
	{
		return default(MatchResult);
	}

	public bool Equals(InputControlScheme other)
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

	public override string ToString()
	{
		return null;
	}

	public static bool operator ==(InputControlScheme left, InputControlScheme right)
	{
		return false;
	}

	public static bool operator !=(InputControlScheme left, InputControlScheme right)
	{
		return false;
	}
}
