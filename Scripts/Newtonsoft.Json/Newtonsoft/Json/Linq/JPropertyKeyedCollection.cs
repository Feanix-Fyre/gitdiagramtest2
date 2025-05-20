using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace Newtonsoft.Json.Linq;

internal class JPropertyKeyedCollection : Collection<JToken>
{
	private static readonly IEqualityComparer<string> Comparer;

	private Dictionary<string, JToken>? _dictionary;

	public JToken this[string key] => null;

	public ICollection<string> Keys => null;

	public ICollection<JToken> Values => null;

	private void AddKey(string key, JToken item)
	{
	}

	protected void ChangeItemKey(JToken item, string newKey)
	{
	}

	protected override void ClearItems()
	{
	}

	public bool Contains(string key)
	{
		return false;
	}

	private bool ContainsItem(JToken item)
	{
		return false;
	}

	private void EnsureDictionary()
	{
	}

	private string GetKeyForItem(JToken item)
	{
		return null;
	}

	protected override void InsertItem(int index, JToken item)
	{
	}

	public bool Remove(string key)
	{
		return false;
	}

	protected override void RemoveItem(int index)
	{
	}

	private void RemoveKey(string key)
	{
	}

	protected override void SetItem(int index, JToken item)
	{
	}

	public bool TryGetValue(string key, [NotNullWhen(true)] out JToken? value)
	{
		value = null;
		return false;
	}

	public int IndexOfReference(JToken t)
	{
		return 0;
	}

	public bool Compare(JPropertyKeyedCollection other)
	{
		return false;
	}
}
