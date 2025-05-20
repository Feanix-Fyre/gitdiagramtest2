using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

[Serializable]
internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver
{
	[SerializeField]
	private string m_Name;

	[SerializeField]
	private int m_RuleIndex;

	[SerializeField]
	private string m_Text;

	[SerializeField]
	private PickingMode m_PickingMode;

	[SerializeField]
	private string[] m_Classes;

	[SerializeField]
	private List<string> m_StylesheetPaths;

	[SerializeField]
	private List<StyleSheet> m_Stylesheets;

	[SerializeField]
	private bool m_SkipClone;

	public int ruleIndex => 0;

	public string[] classes => null;

	public List<string> stylesheetPaths => null;

	public bool hasStylesheetPaths => false;

	public List<StyleSheet> stylesheets => null;

	public bool hasStylesheets => false;

	internal bool skipClone => false;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
