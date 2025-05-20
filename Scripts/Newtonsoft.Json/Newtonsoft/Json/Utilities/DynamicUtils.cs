using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities;

internal static class DynamicUtils
{
	internal static class BinderWrapper
	{
		public const string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private const string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		private static object? _getCSharpArgumentInfoArray;

		private static object? _setCSharpArgumentInfoArray;

		private static MethodCall<object?, object?>? _getMemberCall;

		private static MethodCall<object?, object?>? _setMemberCall;

		private static bool _init;

		private static void Init()
		{
		}

		private static object CreateSharpArgumentInfoArray(params int[] values)
		{
			return null;
		}

		private static void CreateMemberCalls()
		{
		}

		public static CallSiteBinder GetMember(string name, Type context)
		{
			return null;
		}

		public static CallSiteBinder SetMember(string name, Type context)
		{
			return null;
		}
	}

	public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
	{
		return null;
	}
}
