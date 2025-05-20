namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class NameInfo
{
	internal string NIFullName;

	internal long NIobjectId;

	internal long NIassemId;

	internal InternalPrimitiveTypeE NIprimitiveTypeEnum;

	internal Type NItype;

	internal bool NIisSealed;

	internal bool NIisArray;

	internal bool NIisArrayItem;

	internal bool NItransmitTypeOnObject;

	internal bool NItransmitTypeOnMember;

	internal bool NIisParentTypeOnObject;

	internal InternalArrayTypeE NIarrayEnum;

	private bool NIsealedStatusChecked;

	public bool IsSealed => false;

	public string NIname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal NameInfo()
	{
	}

	internal void Init()
	{
	}
}
