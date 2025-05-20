using System.Security;

namespace System.Net;

internal static class UnsafeNclNativeMethods
{
	internal static class HttpApi
	{
		internal static class HTTP_REQUEST_HEADER_ID
		{
			private static string[] m_Strings;

			internal static string ToString(int position)
			{
				return null;
			}
		}

		private static string[] m_Strings;
	}

	internal static class SecureStringHelper
	{
		internal static string CreateString(SecureString secureString)
		{
			return null;
		}

		internal static SecureString CreateSecureString(string plainString)
		{
			return null;
		}
	}
}
