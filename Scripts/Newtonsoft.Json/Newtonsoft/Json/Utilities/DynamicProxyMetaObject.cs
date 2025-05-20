using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Utilities;

internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject where T : notnull
{
	private delegate DynamicMetaObject Fallback(DynamicMetaObject? errorSuggestion);

	private sealed class GetBinderAdapter : GetMemberBinder
	{
		internal GetBinderAdapter(InvokeMemberBinder binder)
			: base(null, ignoreCase: false)
		{
		}

		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject? errorSuggestion)
		{
			return null;
		}
	}

	private readonly DynamicProxy<T> _proxy;

	private static Expression[] NoArgs => null;

	internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
		: base(null, null)
	{
	}

	private bool IsOverridden(string method)
	{
		return false;
	}

	public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
	{
		return null;
	}

	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
	{
		return null;
	}

	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
	{
		return null;
	}

	public override DynamicMetaObject BindConvert(ConvertBinder binder)
	{
		return null;
	}

	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
	{
		return null;
	}

	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
	{
		return null;
	}

	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
	{
		return null;
	}

	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
	{
		return null;
	}

	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
	{
		return null;
	}

	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
	{
		return null;
	}

	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
	{
		return null;
	}

	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
	{
		return null;
	}

	private static IEnumerable<Expression> GetArgs(params DynamicMetaObject[] args)
	{
		return null;
	}

	private static Expression[] GetArgArray(DynamicMetaObject[] args)
	{
		return null;
	}

	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value)
	{
		return null;
	}

	private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
	{
		return null;
	}

	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback, Fallback? fallbackInvoke = null)
	{
		return null;
	}

	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, Fallback? fallbackInvoke)
	{
		return null;
	}

	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, Fallback fallback)
	{
		return null;
	}

	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback)
	{
		return null;
	}

	private BindingRestrictions GetRestrictions()
	{
		return null;
	}

	public override IEnumerable<string> GetDynamicMemberNames()
	{
		return null;
	}
}
