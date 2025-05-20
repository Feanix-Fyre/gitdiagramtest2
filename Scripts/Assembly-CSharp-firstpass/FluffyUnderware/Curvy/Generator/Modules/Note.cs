using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules;

[HelpURL("https://curvyeditor.com/doclink/cgnote")]
[ModuleInfo("Note", ModuleName = "Note", Description = "Creates a note")]
public class Note : CGModule, INoProcessing
{
	[TextArea(3, 10)]
	[SerializeField]
	private string m_Note;

	public string NoteText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	public override void Reset()
	{
	}
}
