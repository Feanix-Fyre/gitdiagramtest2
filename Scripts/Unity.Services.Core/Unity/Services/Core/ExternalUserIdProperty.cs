using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core;

internal class ExternalUserIdProperty
{
	private string m_UserId;

	public string UserId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action<string> UserIdChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}
}
