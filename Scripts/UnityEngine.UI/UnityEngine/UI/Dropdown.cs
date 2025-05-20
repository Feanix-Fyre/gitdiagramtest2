using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[AddComponentMenu("UI/Legacy/Dropdown", 102)]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[SerializeField]
		private Text m_Text;

		[SerializeField]
		private Image m_Image;

		[SerializeField]
		private RectTransform m_RectTransform;

		[SerializeField]
		private Toggle m_Toggle;

		public Text text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Image image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectTransform rectTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Toggle toggle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		public virtual void OnCancel(BaseEventData eventData)
		{
		}
	}

	[Serializable]
	public class OptionData
	{
		[SerializeField]
		private string m_Text;

		[SerializeField]
		private Sprite m_Image;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OptionData()
		{
		}

		public OptionData(string text)
		{
		}

		public OptionData(Sprite image)
		{
		}

		public OptionData(string text, Sprite image)
		{
		}
	}

	[Serializable]
	public class OptionDataList
	{
		[SerializeField]
		private List<OptionData> m_Options;

		public List<OptionData> options
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

	[Serializable]
	public class DropdownEvent : UnityEvent<int>
	{
	}

	[CompilerGenerated]
	private sealed class _003CDelayedDestroyDropdownList_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Dropdown _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayedDestroyDropdownList_003Ed__75(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private RectTransform m_Template;

	[SerializeField]
	private Text m_CaptionText;

	[SerializeField]
	private Image m_CaptionImage;

	[Space]
	[SerializeField]
	private Text m_ItemText;

	[SerializeField]
	private Image m_ItemImage;

	[Space]
	[SerializeField]
	private int m_Value;

	[Space]
	[SerializeField]
	private OptionDataList m_Options;

	[SerializeField]
	[Space]
	private DropdownEvent m_OnValueChanged;

	[SerializeField]
	private float m_AlphaFadeSpeed;

	private GameObject m_Dropdown;

	private GameObject m_Blocker;

	private List<DropdownItem> m_Items;

	private TweenRunner<FloatTween> m_AlphaTweenRunner;

	private bool validTemplate;

	private const int kHighSortingLayer = 30000;

	private static OptionData s_NoOptionData;

	public RectTransform template
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Text captionText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Image captionImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Text itemText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Image itemImage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<OptionData> options
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DropdownEvent onValueChanged
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float alphaFadeSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void SetValueWithoutNotify(int input)
	{
	}

	private void Set(int value, bool sendCallback = true)
	{
	}

	protected Dropdown()
	{
	}

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	protected override void OnDisable()
	{
	}

	public void RefreshShownValue()
	{
	}

	public void AddOptions(List<OptionData> options)
	{
	}

	public void AddOptions(List<string> options)
	{
	}

	public void AddOptions(List<Sprite> options)
	{
	}

	public void ClearOptions()
	{
	}

	private void SetupTemplate(Canvas rootCanvas)
	{
	}

	private static T GetOrAddComponent<T>(GameObject go) where T : Component
	{
		return null;
	}

	public virtual void OnPointerClick(PointerEventData eventData)
	{
	}

	public virtual void OnSubmit(BaseEventData eventData)
	{
	}

	public virtual void OnCancel(BaseEventData eventData)
	{
	}

	public void Show()
	{
	}

	protected virtual GameObject CreateBlocker(Canvas rootCanvas)
	{
		return null;
	}

	protected virtual void DestroyBlocker(GameObject blocker)
	{
	}

	protected virtual GameObject CreateDropdownList(GameObject template)
	{
		return null;
	}

	protected virtual void DestroyDropdownList(GameObject dropdownList)
	{
	}

	protected virtual DropdownItem CreateItem(DropdownItem itemTemplate)
	{
		return null;
	}

	protected virtual void DestroyItem(DropdownItem item)
	{
	}

	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items)
	{
		return null;
	}

	private void AlphaFadeList(float duration, float alpha)
	{
	}

	private void AlphaFadeList(float duration, float start, float end)
	{
	}

	private void SetAlpha(float alpha)
	{
	}

	public void Hide()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedDestroyDropdownList_003Ed__75))]
	private IEnumerator DelayedDestroyDropdownList(float delay)
	{
		return null;
	}

	private void ImmediateDestroyDropdownList()
	{
	}

	private void OnSelectItem(Toggle toggle)
	{
	}
}
