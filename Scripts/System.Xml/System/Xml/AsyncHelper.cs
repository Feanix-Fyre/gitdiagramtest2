using System.Threading.Tasks;

namespace System.Xml;

internal static class AsyncHelper
{
	public static readonly Task DoneTask;

	public static readonly Task<bool> DoneTaskTrue;

	public static readonly Task<bool> DoneTaskFalse;

	public static readonly Task<int> DoneTaskZero;
}
