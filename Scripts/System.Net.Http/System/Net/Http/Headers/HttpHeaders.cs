using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Net.Http.Headers;

/// <summary>A collection of headers and their values as defined in RFC 2616.</summary>
public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable
{
	private class HeaderBucket
	{
		public object Parsed;

		private List<string> values;

		public readonly Func<object, string> CustomToString;

		public bool HasStringValues => false;

		public List<string> Values
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HeaderBucket(object parsed, Func<object, string> converter)
		{
		}

		public string ParsedToString()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private KeyValuePair<string, IEnumerable<string>> _003C_003E2__current;

		public HttpHeaders _003C_003E4__this;

		private Dictionary<string, HeaderBucket>.Enumerator _003C_003E7__wrap1;

		KeyValuePair<string, IEnumerable<string>> IEnumerator<KeyValuePair<string, IEnumerable<string>>>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, IEnumerable<string>>);
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static readonly Dictionary<string, HeaderInfo> known_headers;

	private readonly Dictionary<string, HeaderBucket> headers;

	private readonly HttpHeaderKind HeaderKind;

	internal bool? connectionclose;

	internal bool? transferEncodingChunked;

	static HttpHeaders()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> class.</summary>
	protected HttpHeaders()
	{
	}

	internal HttpHeaders(HttpHeaderKind headerKind)
	{
	}

	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the specified header and its values were added to the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection without validating the provided information.</summary>
	/// <param name="name">The header to add to the collection.</param>
	/// <param name="values">The values of the header.</param>
	/// <returns>
	///   <see langword="true" /> if the specified header <paramref name="name" /> and <paramref name="values" /> could be added to the collection; otherwise <see langword="false" />.</returns>
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values)
	{
		return false;
	}

	private HeaderInfo CheckName(string name)
	{
		return null;
	}

	private bool TryCheckName(string name, out HeaderInfo headerInfo)
	{
		headerInfo = null;
		return false;
	}

	/// <summary>Returns an enumerator that can iterate through the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> instance.</summary>
	/// <returns>An enumerator for the <see cref="T:System.Net.Http.Headers.HttpHeaders" />.</returns>
	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__19))]
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator()
	{
		return null;
	}

	/// <summary>Gets an enumerator that can iterate through a <see cref="T:System.Net.Http.Headers.HttpHeaders" />.</summary>
	/// <returns>An instance of an implementation of an <see cref="T:System.Collections.IEnumerator" /> that can iterate through a <see cref="T:System.Net.Http.Headers.HttpHeaders" />.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Removes the specified header from the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
	/// <param name="name">The name of the header to remove from the collection.</param>
	/// <returns>Returns <see cref="T:System.Boolean" />.</returns>
	public bool Remove(string name)
	{
		return false;
	}

	internal static string GetSingleHeaderString(string key, IEnumerable<string> values)
	{
		return null;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.HttpHeaders" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}

	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter = null) where T : class
	{
	}

	private List<string> GetAllHeaderValues(HeaderBucket bucket, HeaderInfo headerInfo)
	{
		return null;
	}

	internal static HttpHeaderKind GetKnownHeaderKind(string name)
	{
		return default(HttpHeaderKind);
	}

	internal T GetValue<T>(string name)
	{
		return default(T);
	}

	internal HttpHeaderValueCollection<T> GetValues<T>(string name) where T : class
	{
		return null;
	}

	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter = null)
	{
	}
}
