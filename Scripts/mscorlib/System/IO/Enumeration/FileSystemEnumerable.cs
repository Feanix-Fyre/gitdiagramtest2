using System.Collections;
using System.Collections.Generic;

namespace System.IO.Enumeration;

public class FileSystemEnumerable<TResult> : IEnumerable<TResult>, IEnumerable
{
	public delegate bool FindPredicate(ref FileSystemEntry entry);

	public delegate TResult FindTransform(ref FileSystemEntry entry);

	private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
	{
		private readonly FileSystemEnumerable<TResult> _enumerable;

		public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable)
			: base((string)null, (EnumerationOptions)null)
		{
		}

		protected override TResult TransformEntry(ref FileSystemEntry entry)
		{
			return default(TResult);
		}

		protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
		{
			return false;
		}

		protected override bool ShouldIncludeEntry(ref FileSystemEntry entry)
		{
			return false;
		}
	}

	private DelegateEnumerator _enumerator;

	private readonly FindTransform _transform;

	private readonly EnumerationOptions _options;

	private readonly string _directory;

	public FindPredicate ShouldIncludePredicate { get; set; }

	public FindPredicate ShouldRecursePredicate { get; }

	public FileSystemEnumerable(string directory, FindTransform transform, EnumerationOptions options = null)
	{
	}

	public IEnumerator<TResult> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
