using System.Runtime.Serialization;

namespace System;

/// <summary>Represents information about an operating system, such as the version and platform identifier. This class cannot be inherited.</summary>
[Serializable]
public sealed class OperatingSystem : ISerializable, ICloneable
{
	private readonly Version _version;

	private readonly PlatformID _platform;

	private readonly string _servicePack;

	private string _versionString;

	/// <summary>Gets a <see cref="T:System.PlatformID" /> enumeration value that identifies the operating system platform.</summary>
	/// <returns>One of the <see cref="T:System.PlatformID" /> values.</returns>
	public PlatformID Platform => default(PlatformID);

	/// <summary>Gets a <see cref="T:System.Version" /> object that identifies the operating system.</summary>
	/// <returns>A <see cref="T:System.Version" /> object that describes the major version, minor version, build, and revision numbers for the operating system.</returns>
	public Version Version => null;

	/// <summary>Gets the concatenated string representation of the platform identifier, version, and service pack that are currently installed on the operating system.</summary>
	/// <returns>The string representation of the values returned by the <see cref="P:System.OperatingSystem.Platform" />, <see cref="P:System.OperatingSystem.Version" />, and <see cref="P:System.OperatingSystem.ServicePack" /> properties.</returns>
	public string VersionString => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.OperatingSystem" /> class, using the specified platform identifier value and version object.</summary>
	/// <param name="platform">One of the <see cref="T:System.PlatformID" /> values that indicates the operating system platform.</param>
	/// <param name="version">A <see cref="T:System.Version" /> object that indicates the version of the operating system.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="version" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="platform" /> is not a <see cref="T:System.PlatformID" /> enumeration value.</exception>
	public OperatingSystem(PlatformID platform, Version version)
	{
	}

	internal OperatingSystem(PlatformID platform, Version version, string servicePack)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data necessary to deserialize this instance.</summary>
	/// <param name="info">The object to populate with serialization information.</param>
	/// <param name="context">The place to store and retrieve serialized data. Reserved for future use.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Creates an <see cref="T:System.OperatingSystem" /> object that is identical to this instance.</summary>
	/// <returns>An <see cref="T:System.OperatingSystem" /> object that is a copy of this instance.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Converts the value of this <see cref="T:System.OperatingSystem" /> object to its equivalent string representation.</summary>
	/// <returns>The string representation of the values returned by the <see cref="P:System.OperatingSystem.Platform" />, <see cref="P:System.OperatingSystem.Version" />, and <see cref="P:System.OperatingSystem.ServicePack" /> properties.</returns>
	public override string ToString()
	{
		return null;
	}
}
