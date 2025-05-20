namespace System.Data;

internal static class ExceptionBuilder
{
	private static void TraceException(string trace, Exception e)
	{
	}

	internal static Exception TraceExceptionAsReturnValue(Exception e)
	{
		return null;
	}

	internal static Exception TraceExceptionForCapture(Exception e)
	{
		return null;
	}

	internal static Exception TraceExceptionWithoutRethrow(Exception e)
	{
		return null;
	}

	internal static Exception _Argument(string error)
	{
		return null;
	}

	internal static Exception _Argument(string error, Exception innerException)
	{
		return null;
	}

	private static Exception _ArgumentNull(string paramName, string msg)
	{
		return null;
	}

	internal static Exception _ArgumentOutOfRange(string paramName, string msg)
	{
		return null;
	}

	private static Exception _IndexOutOfRange(string error)
	{
		return null;
	}

	private static Exception _InvalidOperation(string error)
	{
		return null;
	}

	private static Exception _InvalidEnumArgumentException(string error)
	{
		return null;
	}

	private static Exception _InvalidEnumArgumentException<T>(T value)
	{
		return null;
	}

	private static void ThrowDataException(string error, Exception innerException)
	{
	}

	private static Exception _Data(string error)
	{
		return null;
	}

	private static Exception _Constraint(string error)
	{
		return null;
	}

	private static Exception _InvalidConstraint(string error)
	{
		return null;
	}

	private static Exception _DeletedRowInaccessible(string error)
	{
		return null;
	}

	private static Exception _DuplicateName(string error)
	{
		return null;
	}

	private static Exception _InRowChangingEvent(string error)
	{
		return null;
	}

	private static Exception _NoNullAllowed(string error)
	{
		return null;
	}

	private static Exception _ReadOnly(string error)
	{
		return null;
	}

	private static Exception _RowNotInTable(string error)
	{
		return null;
	}

	private static Exception _VersionNotFound(string error)
	{
		return null;
	}

	public static Exception ArgumentNull(string paramName)
	{
		return null;
	}

	public static Exception ArgumentOutOfRange(string paramName)
	{
		return null;
	}

	public static Exception BadObjectPropertyAccess(string error)
	{
		return null;
	}

	public static Exception TypeNotAllowed(Type type)
	{
		return null;
	}

	public static Exception CannotModifyCollection()
	{
		return null;
	}

	public static Exception CaseInsensitiveNameConflict(string name)
	{
		return null;
	}

	public static Exception NamespaceNameConflict(string name)
	{
		return null;
	}

	public static Exception InvalidOffsetLength()
	{
		return null;
	}

	public static Exception ColumnNotInTheTable(string column, string table)
	{
		return null;
	}

	public static Exception ColumnNotInAnyTable()
	{
		return null;
	}

	public static Exception ColumnOutOfRange(int index)
	{
		return null;
	}

	public static Exception ColumnOutOfRange(string column)
	{
		return null;
	}

	public static Exception CannotAddColumn1(string column)
	{
		return null;
	}

	public static Exception CannotAddColumn2(string column)
	{
		return null;
	}

	public static Exception CannotAddColumn3()
	{
		return null;
	}

	public static Exception CannotAddColumn4(string column)
	{
		return null;
	}

	public static Exception CannotAddDuplicate(string column)
	{
		return null;
	}

	public static Exception CannotAddDuplicate2(string table)
	{
		return null;
	}

	public static Exception CannotAddDuplicate3(string table)
	{
		return null;
	}

	public static Exception CannotRemoveColumn()
	{
		return null;
	}

	public static Exception CannotRemovePrimaryKey()
	{
		return null;
	}

	public static Exception CannotRemoveChildKey(string relation)
	{
		return null;
	}

	public static Exception CannotRemoveConstraint(string constraint, string table)
	{
		return null;
	}

	public static Exception CannotRemoveExpression(string column, string expression)
	{
		return null;
	}

	public static Exception AddPrimaryKeyConstraint()
	{
		return null;
	}

	public static Exception NoConstraintName()
	{
		return null;
	}

	public static Exception ConstraintViolation(string constraint)
	{
		return null;
	}

	public static string KeysToString(object[] keys)
	{
		return null;
	}

	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values)
	{
		return null;
	}

	public static Exception ConstraintViolation(DataColumn[] columns, object[] values)
	{
		return null;
	}

	public static Exception ConstraintOutOfRange(int index)
	{
		return null;
	}

	public static Exception DuplicateConstraint(string constraint)
	{
		return null;
	}

	public static Exception DuplicateConstraintName(string constraint)
	{
		return null;
	}

	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk)
	{
		return null;
	}

	public static Exception UniqueConstraintViolation()
	{
		return null;
	}

	public static Exception ConstraintForeignTable()
	{
		return null;
	}

	public static Exception ConstraintParentValues()
	{
		return null;
	}

	public static Exception ConstraintAddFailed(DataTable table)
	{
		return null;
	}

	public static Exception ConstraintRemoveFailed()
	{
		return null;
	}

	public static Exception FailedCascadeDelete(string constraint)
	{
		return null;
	}

	public static Exception FailedCascadeUpdate(string constraint)
	{
		return null;
	}

	public static Exception FailedClearParentTable(string table, string constraint, string childTable)
	{
		return null;
	}

	public static Exception ForeignKeyViolation(string constraint, object[] keys)
	{
		return null;
	}

	public static Exception RemoveParentRow(ForeignKeyConstraint constraint)
	{
		return null;
	}

	public static string MaxLengthViolationText(string columnName)
	{
		return null;
	}

	public static string NotAllowDBNullViolationText(string columnName)
	{
		return null;
	}

	public static Exception CantAddConstraintToMultipleNestedTable(string tableName)
	{
		return null;
	}

	public static Exception AutoIncrementAndExpression()
	{
		return null;
	}

	public static Exception AutoIncrementAndDefaultValue()
	{
		return null;
	}

	public static Exception AutoIncrementSeed()
	{
		return null;
	}

	public static Exception CantChangeDataType()
	{
		return null;
	}

	public static Exception NullDataType()
	{
		return null;
	}

	public static Exception ColumnNameRequired()
	{
		return null;
	}

	public static Exception DefaultValueAndAutoIncrement()
	{
		return null;
	}

	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner)
	{
		return null;
	}

	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner)
	{
		return null;
	}

	public static Exception ExpressionAndUnique()
	{
		return null;
	}

	public static Exception ExpressionAndReadOnly()
	{
		return null;
	}

	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint)
	{
		return null;
	}

	public static Exception ExpressionInConstraint(DataColumn column)
	{
		return null;
	}

	public static Exception ExpressionCircular()
	{
		return null;
	}

	public static Exception NonUniqueValues(string column)
	{
		return null;
	}

	public static Exception NullKeyValues(string column)
	{
		return null;
	}

	public static Exception NullValues(string column)
	{
		return null;
	}

	public static Exception ReadOnlyAndExpression()
	{
		return null;
	}

	public static Exception ReadOnly(string column)
	{
		return null;
	}

	public static Exception UniqueAndExpression()
	{
		return null;
	}

	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException)
	{
		return null;
	}

	public static Exception CannotSetToNull(DataColumn column)
	{
		return null;
	}

	public static Exception LongerThanMaxLength(DataColumn column)
	{
		return null;
	}

	public static Exception CannotSetMaxLength(DataColumn column, int value)
	{
		return null;
	}

	public static Exception CannotSetMaxLength2(DataColumn column)
	{
		return null;
	}

	public static Exception CannotSetSimpleContentType(string columnName, Type type)
	{
		return null;
	}

	public static Exception CannotSetSimpleContent(string columnName, Type type)
	{
		return null;
	}

	public static Exception CannotChangeNamespace(string columnName)
	{
		return null;
	}

	public static Exception HasToBeStringType(DataColumn column)
	{
		return null;
	}

	public static Exception AutoIncrementCannotSetIfHasData(string typeName)
	{
		return null;
	}

	public static Exception INullableUDTwithoutStaticNull(string typeName)
	{
		return null;
	}

	public static Exception IComparableNotImplemented(string typeName)
	{
		return null;
	}

	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName)
	{
		return null;
	}

	public static Exception InvalidDataColumnMapping(Type type)
	{
		return null;
	}

	public static Exception CannotSetDateTimeModeForNonDateTimeColumns()
	{
		return null;
	}

	public static Exception InvalidDateTimeMode(DataSetDateTime mode)
	{
		return null;
	}

	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue)
	{
		return null;
	}

	public static Exception ColumnTypeNotSupported()
	{
		return null;
	}

	public static Exception SetFailed(string name)
	{
		return null;
	}

	public static Exception CanNotUseDataViewManager()
	{
		return null;
	}

	public static Exception CanNotUse()
	{
		return null;
	}

	public static Exception SetIListObject()
	{
		return null;
	}

	public static Exception AddNewNotAllowNull()
	{
		return null;
	}

	public static Exception NotOpen()
	{
		return null;
	}

	public static Exception CreateChildView()
	{
		return null;
	}

	public static Exception CanNotDelete()
	{
		return null;
	}

	public static Exception GetElementIndex(int index)
	{
		return null;
	}

	public static Exception AddExternalObject()
	{
		return null;
	}

	public static Exception CanNotClear()
	{
		return null;
	}

	public static Exception InsertExternalObject()
	{
		return null;
	}

	public static Exception RemoveExternalObject()
	{
		return null;
	}

	public static Exception KeyTableMismatch()
	{
		return null;
	}

	public static Exception KeyNoColumns()
	{
		return null;
	}

	public static Exception KeyTooManyColumns(int cols)
	{
		return null;
	}

	public static Exception KeyDuplicateColumns(string columnName)
	{
		return null;
	}

	public static Exception RelationDataSetMismatch()
	{
		return null;
	}

	public static Exception ColumnsTypeMismatch()
	{
		return null;
	}

	public static Exception KeyLengthMismatch()
	{
		return null;
	}

	public static Exception KeyLengthZero()
	{
		return null;
	}

	public static Exception ForeignRelation()
	{
		return null;
	}

	public static Exception KeyColumnsIdentical()
	{
		return null;
	}

	public static Exception RelationForeignTable(string t1, string t2)
	{
		return null;
	}

	public static Exception GetParentRowTableMismatch(string t1, string t2)
	{
		return null;
	}

	public static Exception SetParentRowTableMismatch(string t1, string t2)
	{
		return null;
	}

	public static Exception RelationForeignRow()
	{
		return null;
	}

	public static Exception RelationNestedReadOnly()
	{
		return null;
	}

	public static Exception TableCantBeNestedInTwoTables(string tableName)
	{
		return null;
	}

	public static Exception LoopInNestedRelations(string tableName)
	{
		return null;
	}

	public static Exception RelationDoesNotExist()
	{
		return null;
	}

	public static Exception ParentOrChildColumnsDoNotHaveDataSet()
	{
		return null;
	}

	public static Exception InValidNestedRelation(string childTableName)
	{
		return null;
	}

	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName)
	{
		return null;
	}

	public static Exception RowNotInTheDataSet()
	{
		return null;
	}

	public static Exception RowNotInTheTable()
	{
		return null;
	}

	public static Exception EditInRowChanging()
	{
		return null;
	}

	public static Exception EndEditInRowChanging()
	{
		return null;
	}

	public static Exception BeginEditInRowChanging()
	{
		return null;
	}

	public static Exception CancelEditInRowChanging()
	{
		return null;
	}

	public static Exception DeleteInRowDeleting()
	{
		return null;
	}

	public static Exception ValueArrayLength()
	{
		return null;
	}

	public static Exception NoCurrentData()
	{
		return null;
	}

	public static Exception NoOriginalData()
	{
		return null;
	}

	public static Exception NoProposedData()
	{
		return null;
	}

	public static Exception RowRemovedFromTheTable()
	{
		return null;
	}

	public static Exception DeletedRowInaccessible()
	{
		return null;
	}

	public static Exception RowAlreadyDeleted()
	{
		return null;
	}

	public static Exception RowEmpty()
	{
		return null;
	}

	public static Exception InvalidRowVersion()
	{
		return null;
	}

	public static Exception RowOutOfRange(int index)
	{
		return null;
	}

	public static Exception RowInsertTwice(int index, string tableName)
	{
		return null;
	}

	public static Exception RowInsertMissing(string tableName)
	{
		return null;
	}

	public static Exception RowAlreadyRemoved()
	{
		return null;
	}

	public static Exception MultipleParents()
	{
		return null;
	}

	public static Exception InvalidRowState(DataRowState state)
	{
		return null;
	}

	public static Exception InvalidRowBitPattern()
	{
		return null;
	}

	internal static Exception SetDataSetNameToEmpty()
	{
		return null;
	}

	internal static Exception SetDataSetNameConflicting(string name)
	{
		return null;
	}

	public static Exception DataSetUnsupportedSchema(string ns)
	{
		return null;
	}

	public static Exception MergeMissingDefinition(string obj)
	{
		return null;
	}

	public static Exception TablesInDifferentSets()
	{
		return null;
	}

	public static Exception RelationAlreadyExists()
	{
		return null;
	}

	public static Exception RowAlreadyInOtherCollection()
	{
		return null;
	}

	public static Exception RowAlreadyInTheCollection()
	{
		return null;
	}

	public static Exception RecordStateRange()
	{
		return null;
	}

	public static Exception IndexKeyLength(int length, int keyLength)
	{
		return null;
	}

	public static Exception RemovePrimaryKey(DataTable table)
	{
		return null;
	}

	public static Exception RelationAlreadyInOtherDataSet()
	{
		return null;
	}

	public static Exception RelationAlreadyInTheDataSet()
	{
		return null;
	}

	public static Exception RelationNotInTheDataSet(string relation)
	{
		return null;
	}

	public static Exception RelationOutOfRange(object index)
	{
		return null;
	}

	public static Exception DuplicateRelation(string relation)
	{
		return null;
	}

	public static Exception RelationTableNull()
	{
		return null;
	}

	public static Exception RelationDataSetNull()
	{
		return null;
	}

	public static Exception RelationTableWasRemoved()
	{
		return null;
	}

	public static Exception ParentTableMismatch()
	{
		return null;
	}

	public static Exception ChildTableMismatch()
	{
		return null;
	}

	public static Exception EnforceConstraint()
	{
		return null;
	}

	public static Exception CaseLocaleMismatch()
	{
		return null;
	}

	public static Exception CannotChangeCaseLocale()
	{
		return null;
	}

	public static Exception CannotChangeCaseLocale(Exception innerException)
	{
		return null;
	}

	public static Exception InvalidRemotingFormat(SerializationFormat mode)
	{
		return null;
	}

	public static Exception TableForeignPrimaryKey()
	{
		return null;
	}

	public static Exception TableCannotAddToSimpleContent()
	{
		return null;
	}

	public static Exception NoTableName()
	{
		return null;
	}

	public static Exception MultipleTextOnlyColumns()
	{
		return null;
	}

	public static Exception InvalidSortString(string sort)
	{
		return null;
	}

	public static Exception DuplicateTableName(string table)
	{
		return null;
	}

	public static Exception DuplicateTableName2(string table, string ns)
	{
		return null;
	}

	public static Exception SelfnestedDatasetConflictingName(string table)
	{
		return null;
	}

	public static Exception DatasetConflictingName(string table)
	{
		return null;
	}

	public static Exception TableAlreadyInOtherDataSet()
	{
		return null;
	}

	public static Exception TableAlreadyInTheDataSet()
	{
		return null;
	}

	public static Exception TableOutOfRange(int index)
	{
		return null;
	}

	public static Exception TableNotInTheDataSet(string table)
	{
		return null;
	}

	public static Exception TableInRelation()
	{
		return null;
	}

	public static Exception TableInConstraint(DataTable table, Constraint constraint)
	{
		return null;
	}

	public static Exception CanNotSerializeDataTableHierarchy()
	{
		return null;
	}

	public static Exception CanNotRemoteDataTable()
	{
		return null;
	}

	public static Exception CanNotSetRemotingFormat()
	{
		return null;
	}

	public static Exception CanNotSerializeDataTableWithEmptyName()
	{
		return null;
	}

	public static Exception TableNotFound(string tableName)
	{
		return null;
	}

	public static Exception AggregateException(AggregateType aggregateType, Type type)
	{
		return null;
	}

	public static Exception InvalidStorageType(TypeCode typecode)
	{
		return null;
	}

	public static Exception RangeArgument(int min, int max)
	{
		return null;
	}

	public static Exception NullRange()
	{
		return null;
	}

	public static Exception NegativeMinimumCapacity()
	{
		return null;
	}

	public static Exception ProblematicChars(char charValue)
	{
		return null;
	}

	public static Exception StorageSetFailed()
	{
		return null;
	}

	public static Exception SimpleTypeNotSupported()
	{
		return null;
	}

	public static Exception MissingAttribute(string attribute)
	{
		return null;
	}

	public static Exception MissingAttribute(string element, string attribute)
	{
		return null;
	}

	public static Exception InvalidAttributeValue(string name, string value)
	{
		return null;
	}

	public static Exception AttributeValues(string name, string value1, string value2)
	{
		return null;
	}

	public static Exception ElementTypeNotFound(string name)
	{
		return null;
	}

	public static Exception RelationParentNameMissing(string rel)
	{
		return null;
	}

	public static Exception RelationChildNameMissing(string rel)
	{
		return null;
	}

	public static Exception RelationTableKeyMissing(string rel)
	{
		return null;
	}

	public static Exception RelationChildKeyMissing(string rel)
	{
		return null;
	}

	public static Exception UndefinedDatatype(string name)
	{
		return null;
	}

	public static Exception DatatypeNotDefined()
	{
		return null;
	}

	public static Exception MismatchKeyLength()
	{
		return null;
	}

	public static Exception InvalidField(string name)
	{
		return null;
	}

	public static Exception InvalidSelector(string name)
	{
		return null;
	}

	public static Exception CircularComplexType(string name)
	{
		return null;
	}

	public static Exception CannotInstantiateAbstract(string name)
	{
		return null;
	}

	public static Exception InvalidKey(string name)
	{
		return null;
	}

	public static Exception DiffgramMissingTable(string name)
	{
		return null;
	}

	public static Exception DiffgramMissingSQL()
	{
		return null;
	}

	public static Exception DuplicateConstraintRead(string str)
	{
		return null;
	}

	public static Exception ColumnTypeConflict(string name)
	{
		return null;
	}

	public static Exception CannotConvert(string name, string type)
	{
		return null;
	}

	public static Exception MissingRefer(string name)
	{
		return null;
	}

	public static Exception InvalidPrefix(string name)
	{
		return null;
	}

	public static Exception CanNotDeserializeObjectType()
	{
		return null;
	}

	public static Exception IsDataSetAttributeMissingInSchema()
	{
		return null;
	}

	public static Exception TooManyIsDataSetAtributeInSchema()
	{
		return null;
	}

	public static Exception NestedCircular(string name)
	{
		return null;
	}

	public static Exception MultipleParentRows(string tableQName)
	{
		return null;
	}

	public static Exception PolymorphismNotSupported(string typeName)
	{
		return null;
	}

	public static Exception DataTableInferenceNotSupported()
	{
		return null;
	}

	internal static void ThrowMultipleTargetConverter(Exception innerException)
	{
	}

	public static Exception DuplicateDeclaration(string name)
	{
		return null;
	}

	public static Exception FoundEntity()
	{
		return null;
	}

	public static Exception MergeFailed(string name)
	{
		return null;
	}

	public static Exception ConvertFailed(Type type1, Type type2)
	{
		return null;
	}

	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr)
	{
		return null;
	}

	internal static Exception InternalRBTreeError(RBTreeError internalError)
	{
		return null;
	}

	public static Exception EnumeratorModified()
	{
		return null;
	}
}
