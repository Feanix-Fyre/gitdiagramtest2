namespace System.Data;

internal sealed class Function
{
	internal readonly string _name;

	internal readonly FunctionId _id;

	internal readonly Type _result;

	internal readonly bool _isValidateArguments;

	internal readonly bool _isVariantArgumentList;

	internal readonly int _argumentCount;

	internal readonly Type[] _parameters;

	internal static string[] s_functionName;

	internal Function(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3)
	{
	}
}
