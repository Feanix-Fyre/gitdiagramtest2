using System.Collections.Generic;

namespace System.Net.Http.Headers;

internal abstract class HeaderInfo
{
	private class HeaderTypeInfo<T, U> : HeaderInfo where U : class
	{
		private readonly TryParseDelegate<T> parser;

		public HeaderTypeInfo(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind)
			: base(null, default(HttpHeaderKind))
		{
		}

		public override void AddToCollection(object collection, object value)
		{
		}

		protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo)
		{
			return null;
		}

		public override List<string> ToStringCollection(object collection)
		{
			return null;
		}

		public override bool TryParse(string value, out object result)
		{
			result = null;
			return false;
		}
	}

	private class CollectionHeaderTypeInfo<T, U> : HeaderTypeInfo<T, U> where U : class
	{
		private readonly int minimalCount;

		private readonly string separator;

		private readonly TryParseListDelegate<T> parser;

		public override string Separator => null;

		public CollectionHeaderTypeInfo(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator)
			: base((string)null, (TryParseDelegate<T>)null, default(HttpHeaderKind))
		{
		}

		public override bool TryParse(string value, out object result)
		{
			result = null;
			return false;
		}
	}

	public bool AllowsMany;

	public readonly HttpHeaderKind HeaderKind;

	public readonly string Name;

	public Func<object, string> CustomToString { get; private set; }

	public virtual string Separator => null;

	protected HeaderInfo(string name, HttpHeaderKind headerKind)
	{
	}

	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString = null)
	{
		return null;
	}

	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") where T : class
	{
		return null;
	}

	public object CreateCollection(HttpHeaders headers)
	{
		return null;
	}

	public abstract void AddToCollection(object collection, object value);

	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	public abstract List<string> ToStringCollection(object collection);

	public abstract bool TryParse(string value, out object result);
}
