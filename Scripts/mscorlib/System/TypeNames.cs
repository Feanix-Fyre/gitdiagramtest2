namespace System;

internal class TypeNames
{
	internal abstract class ATypeName : TypeName, IEquatable<TypeName>
	{
		public abstract string DisplayName { get; }

		public bool Equals(TypeName other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}
	}
}
