using System;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Configuration;

internal class ExternalUserId : IExternalUserId, IServiceComponent
{
	public string UserId => null;

	public event Action<string> UserIdChanged
	{
		add
		{
		}
		remove
		{
		}
	}
}
