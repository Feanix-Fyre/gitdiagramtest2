using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Data;

/// <summary>Represents the collection of <see cref="T:System.Data.DataRelation" /> objects for this <see cref="T:System.Data.DataSet" />.</summary>
[DefaultProperty("Table")]
[DefaultEvent("CollectionChanged")]
public abstract class DataRelationCollection : InternalDataCollectionBase
{
	internal sealed class DataTableRelationCollection : DataRelationCollection
	{
		private readonly DataTable _table;

		private readonly ArrayList _relations;

		private readonly bool _fParentCollection;

		protected override ArrayList List => null;

		public override DataRelation this[int index] => null;

		public override DataRelation this[string name] => null;

		internal event CollectionChangeEventHandler RelationPropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal DataTableRelationCollection(DataTable table, bool fParentCollection)
		{
		}

		private void EnsureDataSet()
		{
		}

		protected override DataSet GetDataSet()
		{
			return null;
		}

		private void AddCache(DataRelation relation)
		{
		}

		protected override void AddCore(DataRelation relation)
		{
		}

		private void RemoveCache(DataRelation relation)
		{
		}

		protected override void RemoveCore(DataRelation relation)
		{
		}
	}

	internal sealed class DataSetRelationCollection : DataRelationCollection
	{
		private readonly DataSet _dataSet;

		private readonly ArrayList _relations;

		private DataRelation[] _delayLoadingRelations;

		protected override ArrayList List => null;

		public override DataRelation this[int index] => null;

		public override DataRelation this[string name] => null;

		internal DataSetRelationCollection(DataSet dataSet)
		{
		}

		public override void Clear()
		{
		}

		protected override DataSet GetDataSet()
		{
			return null;
		}

		protected override void AddCore(DataRelation relation)
		{
		}

		protected override void RemoveCore(DataRelation relation)
		{
		}
	}

	private DataRelation _inTransition;

	private int _defaultNameIndex;

	private CollectionChangeEventHandler _onCollectionChangedDelegate;

	private CollectionChangeEventHandler _onCollectionChangingDelegate;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	internal int ObjectID => 0;

	/// <summary>Gets the <see cref="T:System.Data.DataRelation" /> object at the specified index.</summary>
	/// <param name="index">The zero-based index to find.</param>
	/// <returns>The <see cref="T:System.Data.DataRelation" />, or a null value if the specified <see cref="T:System.Data.DataRelation" /> does not exist.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection.</exception>
	public abstract DataRelation this[int index] { get; }

	/// <summary>Gets the <see cref="T:System.Data.DataRelation" /> object specified by name.</summary>
	/// <param name="name">The name of the relation to find.</param>
	/// <returns>The named <see cref="T:System.Data.DataRelation" />, or a null value if the specified <see cref="T:System.Data.DataRelation" /> does not exist.</returns>
	public abstract DataRelation this[string name] { get; }

	/// <summary>Occurs when the collection has changed.</summary>
	public event CollectionChangeEventHandler CollectionChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Adds a <see cref="T:System.Data.DataRelation" /> to the <see cref="T:System.Data.DataRelationCollection" />.</summary>
	/// <param name="relation">The <see langword="DataRelation" /> to add to the collection.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="relation" /> parameter is a null value.</exception>
	/// <exception cref="T:System.ArgumentException">The relation already belongs to this collection, or it belongs to another collection.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">The collection already has a relation with the specified name. (The comparison is not case sensitive.)</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The relation has entered an invalid state since it was created.</exception>
	public void Add(DataRelation relation)
	{
	}

	/// <summary>Performs verification on the table.</summary>
	/// <param name="relation">The relation to check.</param>
	/// <exception cref="T:System.ArgumentNullException">The relation is null.</exception>
	/// <exception cref="T:System.ArgumentException">The relation already belongs to this collection, or it belongs to another collection.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">The collection already has a relation with the same name. (The comparison is not case sensitive.)</exception>
	protected virtual void AddCore(DataRelation relation)
	{
	}

	internal string AssignName()
	{
		return null;
	}

	/// <summary>Clears the collection of any relations.</summary>
	public virtual void Clear()
	{
	}

	/// <summary>Verifies whether a <see cref="T:System.Data.DataRelation" /> with the specific name (case insensitive) exists in the collection.</summary>
	/// <param name="name">The name of the relation to find.</param>
	/// <returns>
	///   <see langword="true" />, if a relation with the specified name exists; otherwise <see langword="false" />.</returns>
	public virtual bool Contains(string name)
	{
		return false;
	}

	internal int InternalIndexOf(string name)
	{
		return 0;
	}

	/// <summary>This method supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <returns>The referenced DataSet.</returns>
	protected abstract DataSet GetDataSet();

	private string MakeName(int index)
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Data.DataRelationCollection.CollectionChanged" /> event.</summary>
	/// <param name="ccevent">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data.</param>
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataRelationCollection.CollectionChanged" /> event.</summary>
	/// <param name="ccevent">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data.</param>
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent)
	{
	}

	internal void RegisterName(string name)
	{
	}

	/// <summary>Removes the specified relation from the collection.</summary>
	/// <param name="relation">The relation to remove.</param>
	/// <exception cref="T:System.ArgumentNullException">The relation is a null value.</exception>
	/// <exception cref="T:System.ArgumentException">The relation does not belong to the collection.</exception>
	public void Remove(DataRelation relation)
	{
	}

	/// <summary>Removes the relation at the specified index from the collection.</summary>
	/// <param name="index">The index of the relation to remove.</param>
	/// <exception cref="T:System.ArgumentException">The collection does not have a relation at the specified index.</exception>
	public void RemoveAt(int index)
	{
	}

	/// <summary>Performs a verification on the specified <see cref="T:System.Data.DataRelation" /> object.</summary>
	/// <param name="relation">The <see langword="DataRelation" /> object to verify.</param>
	/// <exception cref="T:System.ArgumentNullException">The collection does not have a relation at the specified index.</exception>
	/// <exception cref="T:System.ArgumentException">The specified relation does not belong to this collection, or it belongs to another collection.</exception>
	protected virtual void RemoveCore(DataRelation relation)
	{
	}

	internal void UnregisterName(string name)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRelationCollection" /> class.</summary>
	protected DataRelationCollection()
	{
	}
}
