namespace System.Net;

internal static class ExceptionHelper
{
	internal static NotImplementedException MethodNotImplementedException => null;

	internal static NotImplementedException PropertyNotImplementedException => null;

	internal static WebException TimeoutException => null;

	internal static NotSupportedException PropertyNotSupportedException => null;

	internal static WebException RequestAbortedException => null;
}
