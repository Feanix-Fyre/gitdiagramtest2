using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace UnityEngine.Rendering;

public class DebugUI
{
	public class Container : Widget, IContainer
	{
		private const string k_IDToken = "#";

		internal bool hideDisplayName => false;

		public ObservableList<Widget> children { get; private set; }

		public override Panel panel
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Container()
		{
		}

		public Container(string id)
		{
		}

		public Container(string displayName, ObservableList<Widget> children)
		{
		}

		internal override void GenerateQueryPath()
		{
		}

		protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
		{
		}

		protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public class Foldout : Container, IValueField
	{
		public struct ContextMenuItem
		{
			public string displayName;

			public Action action;
		}

		public bool opened;

		public bool isHeader;

		public List<ContextMenuItem> contextMenuItems;

		public bool isReadOnly => false;

		public string[] columnLabels { get; set; }

		public string[] columnTooltips { get; set; }

		public Foldout()
		{
		}

		public Foldout(string displayName, ObservableList<Widget> children, string[] columnLabels = null, string[] columnTooltips = null)
		{
		}

		public bool GetValue()
		{
			return false;
		}

		object IValueField.GetValue()
		{
			return null;
		}

		public void SetValue(object value)
		{
		}

		public object ValidateValue(object value)
		{
			return null;
		}

		public void SetValue(bool value)
		{
		}
	}

	public class HBox : Container
	{
	}

	public class VBox : Container
	{
	}

	public class Table : Container
	{
		public class Row : Foldout
		{
		}

		public bool isReadOnly;

		private bool[] m_Header;

		public bool[] VisibleColumns => null;

		public void SetColumnVisibility(int index, bool visible)
		{
		}

		public bool GetColumnVisibility(int index)
		{
			return false;
		}

		protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
		{
		}

		protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
		{
		}
	}

	[Flags]
	public enum Flags
	{
		None = 0,
		EditorOnly = 2,
		RuntimeOnly = 4,
		EditorForceUpdate = 8,
		FrequentlyUsed = 0x10
	}

	public abstract class Widget
	{
		public struct NameAndTooltip
		{
			public string name;

			public string tooltip;
		}

		protected Panel m_Panel;

		protected IContainer m_Parent;

		public Func<bool> isHiddenCallback;

		public virtual Panel panel
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public virtual IContainer parent
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Flags flags { get; set; }

		public string displayName { get; set; }

		public string tooltip { get; set; }

		public string queryPath { get; private set; }

		public bool isEditorOnly => false;

		public bool isRuntimeOnly => false;

		public bool isInactiveInEditor => false;

		public bool isHidden => false;

		public NameAndTooltip nameAndTooltip
		{
			set
			{
			}
		}

		internal virtual void GenerateQueryPath()
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public interface IContainer
	{
		ObservableList<Widget> children { get; }

		string displayName { get; set; }

		string queryPath { get; }
	}

	public interface IValueField
	{
		object GetValue();

		void SetValue(object value);

		object ValidateValue(object value);
	}

	public class Button : Widget
	{
		public Action action { get; set; }
	}

	public class Value : Widget
	{
		public float refreshRate;

		public string formatString;

		public Func<object> getter { get; set; }

		public virtual object GetValue()
		{
			return null;
		}

		public virtual string FormatString(object value)
		{
			return null;
		}
	}

	public class ProgressBarValue : Value
	{
		public float min;

		public float max;

		public override string FormatString(object value)
		{
			return null;
		}
	}

	public class ValueTuple : Widget
	{
		public Value[] values;

		public int pinnedElementIndex;

		public int numElements => 0;

		public float refreshRate => 0f;
	}

	public abstract class Field<T> : Widget, IValueField
	{
		public Action<Field<T>, T> onValueChanged;

		public Func<T> getter { get; set; }

		public Action<T> setter { get; set; }

		object IValueField.ValidateValue(object value)
		{
			return null;
		}

		public virtual T ValidateValue(T value)
		{
			return default(T);
		}

		object IValueField.GetValue()
		{
			return null;
		}

		public T GetValue()
		{
			return default(T);
		}

		public void SetValue(object value)
		{
		}

		public virtual void SetValue(T value)
		{
		}
	}

	public class BoolField : Field<bool>
	{
	}

	public class HistoryBoolField : BoolField
	{
		public Func<bool>[] historyGetter { get; set; }

		public int historyDepth => 0;

		public bool GetHistoryValue(int historyIndex)
		{
			return false;
		}
	}

	public class IntField : Field<int>
	{
		public Func<int> min;

		public Func<int> max;

		public int incStep;

		public int intStepMult;

		public override int ValidateValue(int value)
		{
			return 0;
		}
	}

	public class UIntField : Field<uint>
	{
		public Func<uint> min;

		public Func<uint> max;

		public uint incStep;

		public uint intStepMult;

		public override uint ValidateValue(uint value)
		{
			return 0u;
		}
	}

	public class FloatField : Field<float>
	{
		public Func<float> min;

		public Func<float> max;

		public float incStep;

		public float incStepMult;

		public int decimals;

		public override float ValidateValue(float value)
		{
			return 0f;
		}
	}

	public abstract class EnumField<T> : Field<T>
	{
		public GUIContent[] enumNames;

		private int[] m_EnumValues;

		private static Regex s_NicifyRegEx;

		public int[] enumValues
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void AutoFillFromType(Type enumType)
		{
		}
	}

	public class EnumField : EnumField<int>
	{
		internal int[] quickSeparators;

		private int[] m_Indexes;

		internal int[] indexes => null;

		public Func<int> getIndex { get; set; }

		public Action<int> setIndex { get; set; }

		public int currentIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Type autoEnum
		{
			set
			{
			}
		}

		internal void InitQuickSeparators()
		{
		}

		public override void SetValue(int value)
		{
		}
	}

	public class ObjectPopupField : Field<Object>
	{
		public Func<IEnumerable<Object>> getObjects { get; set; }
	}

	public class HistoryEnumField : EnumField
	{
		public Func<int>[] historyIndexGetter { get; set; }

		public int historyDepth => 0;

		public int GetHistoryValue(int historyIndex)
		{
			return 0;
		}
	}

	public class BitField : EnumField<Enum>
	{
		private Type m_EnumType;

		public Type enumType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}

	public class ColorField : Field<Color>
	{
		public bool hdr;

		public bool showAlpha;

		public bool showPicker;

		public float incStep;

		public float incStepMult;

		public int decimals;

		public override Color ValidateValue(Color value)
		{
			return default(Color);
		}
	}

	public class Vector2Field : Field<Vector2>
	{
		public float incStep;

		public float incStepMult;

		public int decimals;
	}

	public class Vector3Field : Field<Vector3>
	{
		public float incStep;

		public float incStepMult;

		public int decimals;
	}

	public class Vector4Field : Field<Vector4>
	{
		public float incStep;

		public float incStepMult;

		public int decimals;
	}

	public class ObjectField : Field<Object>
	{
		public Type type;
	}

	public class ObjectListField : Field<Object[]>
	{
		public Type type;
	}

	public class MessageBox : Widget
	{
		public enum Style
		{
			Info = 0,
			Warning = 1,
			Error = 2
		}

		public Style style;
	}

	public class Panel : IContainer, IComparable<Panel>
	{
		public Flags flags { get; set; }

		public string displayName { get; set; }

		public int groupIndex { get; set; }

		public string queryPath => null;

		public bool isEditorOnly => false;

		public bool isRuntimeOnly => false;

		public bool isInactiveInEditor => false;

		public bool editorForceUpdate => false;

		public ObservableList<Widget> children { get; private set; }

		public event Action<Panel> onSetDirty
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

		protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
		{
		}

		protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e)
		{
		}

		public void SetDirty()
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IComparable<Panel>.CompareTo(Panel other)
		{
			return 0;
		}
	}
}
