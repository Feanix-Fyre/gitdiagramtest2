using System.Reflection;

namespace System.Linq.Expressions;

internal static class CachedReflectionInfo
{
	private static MethodInfo s_CallSiteOps_SetNotMatched;

	private static MethodInfo s_CallSiteOps_CreateMatchmaker;

	private static MethodInfo s_CallSiteOps_GetMatch;

	private static MethodInfo s_CallSiteOps_ClearMatch;

	private static MethodInfo s_CallSiteOps_UpdateRules;

	private static MethodInfo s_CallSiteOps_GetRules;

	private static MethodInfo s_CallSiteOps_GetRuleCache;

	private static MethodInfo s_CallSiteOps_GetCachedRules;

	private static MethodInfo s_CallSiteOps_AddRule;

	private static MethodInfo s_CallSiteOps_MoveRule;

	private static MethodInfo s_CallSiteOps_Bind;

	private static MethodInfo s_String_op_Equality_String_String;

	private static MethodInfo s_Math_Pow_Double_Double;

	public static MethodInfo CallSiteOps_SetNotMatched => null;

	public static MethodInfo CallSiteOps_CreateMatchmaker => null;

	public static MethodInfo CallSiteOps_GetMatch => null;

	public static MethodInfo CallSiteOps_ClearMatch => null;

	public static MethodInfo CallSiteOps_UpdateRules => null;

	public static MethodInfo CallSiteOps_GetRules => null;

	public static MethodInfo CallSiteOps_GetRuleCache => null;

	public static MethodInfo CallSiteOps_GetCachedRules => null;

	public static MethodInfo CallSiteOps_AddRule => null;

	public static MethodInfo CallSiteOps_MoveRule => null;

	public static MethodInfo CallSiteOps_Bind => null;

	public static MethodInfo String_op_Equality_String_String => null;

	public static MethodInfo Math_Pow_Double_Double => null;
}
