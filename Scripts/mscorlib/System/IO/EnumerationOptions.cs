namespace System.IO;

public class EnumerationOptions
{
	internal static EnumerationOptions Compatible { get; }

	private static EnumerationOptions CompatibleRecursive { get; }

	internal static EnumerationOptions Default { get; }

	public bool RecurseSubdirectories { get; set; }

	public bool IgnoreInaccessible { get; set; }

	public int BufferSize { get; }

	public FileAttributes AttributesToSkip { get; set; }

	public MatchType MatchType { get; set; }

	public MatchCasing MatchCasing { get; }

	public bool ReturnSpecialDirectories { get; }

	internal static EnumerationOptions FromSearchOption(SearchOption searchOption)
	{
		return null;
	}
}
