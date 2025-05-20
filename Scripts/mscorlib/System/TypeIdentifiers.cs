namespace System;

internal class TypeIdentifiers
{
	private class Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName>
	{
		private string displayName;

		private string internal_name;

		public override string DisplayName => null;

		public string InternalName => null;

		internal Display(string displayName)
		{
		}

		private string GetInternalName()
		{
			return null;
		}
	}

	internal static TypeIdentifier FromDisplay(string displayName)
	{
		return null;
	}
}
