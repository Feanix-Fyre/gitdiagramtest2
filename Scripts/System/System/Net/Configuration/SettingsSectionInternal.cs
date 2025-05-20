using System.Net.Sockets;

namespace System.Net.Configuration;

internal sealed class SettingsSectionInternal
{
	private static readonly SettingsSectionInternal instance;

	internal readonly bool HttpListenerUnescapeRequestUrl;

	internal readonly IPProtectionLevel IPProtectionLevel;

	internal static SettingsSectionInternal Section => null;

	internal bool Ipv6Enabled => false;
}
