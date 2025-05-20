using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms.RTF;

namespace System.Windows.Forms;

internal class Document : IEnumerable, ICloneable
{
	internal struct Marker
	{
		internal Line line;

		internal LineTag tag;

		internal int pos;

		internal int height;

		public void Combine(Line move_to_line, int move_to_line_length)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator <(Marker lhs, Marker rhs)
		{
			return false;
		}

		public static bool operator >(Marker lhs, Marker rhs)
		{
			return false;
		}

		public static bool operator ==(Marker lhs, Marker rhs)
		{
			return false;
		}

		public static bool operator !=(Marker lhs, Marker rhs)
		{
			return false;
		}
	}

	private Line document;

	private int lines;

	private Line sentinel;

	private int document_id;

	private Random random;

	internal string password_char;

	private StringBuilder password_cache;

	private bool calc_pass;

	private int char_count;

	private bool enable_links;

	public static readonly StringFormat string_format;

	private int recalc_suspended;

	private bool recalc_pending;

	private int recalc_start;

	private int recalc_end;

	private bool recalc_optimize;

	private int update_suspended;

	private bool update_pending;

	private int update_start;

	internal bool multiline;

	internal HorizontalAlignment alignment;

	internal bool wrap;

	internal UndoManager undo;

	internal Marker caret;

	internal Marker selection_start;

	internal Marker selection_end;

	internal bool selection_visible;

	internal Marker selection_anchor;

	internal Marker selection_prev;

	internal bool selection_end_anchor;

	internal int viewport_x;

	internal int viewport_y;

	internal int offset_x;

	internal int offset_y;

	internal int viewport_width;

	internal int viewport_height;

	internal int document_x;

	internal int document_y;

	internal int crlf_size;

	internal TextBoxBase owner;

	internal static int caret_width;

	internal static int caret_shift;

	internal int left_margin;

	internal int top_margin;

	internal int right_margin;

	private EventHandler CaretMoved;

	private EventHandler LengthChanged;

	private EventHandler UIASelectionChanged;

	internal Line Root => null;

	internal int Lines => 0;

	internal Line CaretLine => null;

	internal int CaretPosition => 0;

	internal Point Caret => default(Point);

	internal LineTag CaretTag
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool EnableLinks => false;

	internal string PasswordChar
	{
		set
		{
		}
	}

	private StringBuilder PasswordCache => null;

	internal int ViewPortX
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int Length => 0;

	private int CharCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int ViewPortY
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int OffsetX
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int ViewPortWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int ViewPortHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int Width => 0;

	internal int Height => 0;

	internal bool Wrap
	{
		set
		{
		}
	}

	internal event EventHandler WidthChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	internal event EventHandler HeightChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	internal Document(TextBoxBase owner)
	{
	}

	internal void UpdateMargins()
	{
	}

	internal void SuspendRecalc()
	{
	}

	internal void ResumeRecalc(bool immediate_update)
	{
	}

	internal void SuspendUpdate()
	{
	}

	internal void ResumeUpdate(bool immediate_update)
	{
	}

	private void SetSelectionVisible(bool value)
	{
	}

	private void DecrementLines(int line_no)
	{
	}

	private void IncrementLines(int line_no)
	{
	}

	private void RebalanceAfterAdd(Line line1)
	{
	}

	private void RebalanceAfterDelete(Line line1)
	{
	}

	private void RotateLeft(Line line1)
	{
	}

	private void RotateRight(Line line1)
	{
	}

	internal void UpdateView(Line line, int pos)
	{
	}

	internal void UpdateView(Line line, int line_count, int pos)
	{
	}

	private void ScanForLinks(Line start_line, ref bool link_changed)
	{
	}

	private int FirstIndexOfAny(string haystack, string[] needles, int start_index, out int term_found)
	{
		term_found = default(int);
		return 0;
	}

	private void InvalidateLinks(Rectangle clip)
	{
	}

	internal void ScanForLinks(int start, int end, ref bool link_changed)
	{
	}

	internal void Empty()
	{
	}

	internal void PositionCaret(Line line, int pos)
	{
	}

	internal void PositionCaret(int x, int y)
	{
	}

	internal void CaretHasFocus()
	{
	}

	internal void CaretLostFocus()
	{
	}

	internal void AlignCaret()
	{
	}

	internal void AlignCaret(bool changeCaretTag)
	{
	}

	internal void UpdateCaret()
	{
	}

	internal void DisplayCaret()
	{
	}

	internal void MoveCaretToTextTag()
	{
	}

	internal void MoveCaret(CaretDirection direction)
	{
	}

	internal void GetVisibleLineIndexes(Rectangle clip, out int start, out int end)
	{
		start = default(int);
		end = default(int);
	}

	internal void Draw(Graphics g, Rectangle clip)
	{
	}

	private int GetLineEnding(string line, int start, out LineEnding ending)
	{
		ending = default(LineEnding);
		return 0;
	}

	private int GetLineEnding(string line, int start, out LineEnding ending, LineEnding type)
	{
		ending = default(LineEnding);
		return 0;
	}

	internal int LineEndingLength(LineEnding ending)
	{
		return 0;
	}

	internal string LineEndingToString(LineEnding ending)
	{
		return null;
	}

	internal LineEnding StringToLineEnding(string ending)
	{
		return default(LineEnding);
	}

	internal void Insert(Line line, int pos, bool update_caret, string s)
	{
	}

	internal void Insert(Line line, int pos, bool update_caret, string s, LineTag tag)
	{
	}

	internal void InsertString(Line line, int pos, string s)
	{
	}

	internal void InsertCharAtCaret(char ch, bool move_caret)
	{
	}

	internal void InsertPicture(Line line, int pos, Picture picture)
	{
	}

	internal void DeleteMultiline(Line start_line, int pos, int length)
	{
	}

	public void DeleteChars(Line line, int pos, int count)
	{
	}

	public void DeleteChar(Line line, int pos, bool forward)
	{
	}

	internal void Combine(int FirstLine, int SecondLine)
	{
	}

	internal void Combine(Line first, Line second)
	{
	}

	internal void Split(int LineNo, int pos)
	{
	}

	internal void Split(Line line, int pos)
	{
	}

	internal void Split(Line line, LineTag tag, int pos)
	{
	}

	internal void Add(int LineNo, string Text, System.Drawing.Font font, System.Drawing.Color color, LineEnding ending)
	{
	}

	internal void Add(int LineNo, string Text, HorizontalAlignment align, System.Drawing.Font font, System.Drawing.Color color, LineEnding ending)
	{
	}

	public virtual object Clone()
	{
		return null;
	}

	private void Delete(int LineNo)
	{
	}

	private void Delete(Line line1)
	{
	}

	internal void InvalidateLinesAfter(Line start)
	{
	}

	internal void Invalidate(Line start, int start_pos, Line end, int end_pos)
	{
	}

	internal void ExpandSelection(CaretSelection mode, bool to_caret)
	{
	}

	internal void SetSelectionToCaret(bool start)
	{
	}

	internal void SetSelection(Line start, int start_pos, Line end, int end_pos)
	{
	}

	internal void SetSelectionStart(Line start, int start_pos, bool invalidate)
	{
	}

	internal void SetSelectionStart(int character_index, bool invalidate)
	{
	}

	internal void SetSelectionEnd(Line end, int end_pos, bool invalidate)
	{
	}

	internal void SetSelectionEnd(int character_index, bool invalidate)
	{
	}

	internal void SetSelection(Line start, int start_pos)
	{
	}

	internal void InvalidateSelectionArea()
	{
	}

	internal string GetSelection()
	{
		return null;
	}

	internal void ReplaceSelection(string s, bool select_new)
	{
	}

	internal void CharIndexToLineTag(int index, out Line line_out, out LineTag tag_out, out int pos)
	{
		line_out = null;
		tag_out = null;
		pos = default(int);
	}

	internal int LineTagToCharIndex(Line line, int pos)
	{
		return 0;
	}

	internal int SelectionLength()
	{
		return 0;
	}

	internal Line GetLine(int LineNo)
	{
		return null;
	}

	internal Line GetLineByPixel(int offset, bool exact)
	{
		return null;
	}

	internal LineTag FindCursor(int x, int y, out int index)
	{
		index = default(int);
		return null;
	}

	internal void FormatText(Line start_line, int start_pos, Line end_line, int end_pos, System.Drawing.Font font, System.Drawing.Color color, System.Drawing.Color back_color, FormatSpecified specified)
	{
	}

	internal void RecalculateAlignments()
	{
	}

	internal bool RecalculateDocument(Graphics g)
	{
		return false;
	}

	internal bool RecalculateDocument(Graphics g, int start, int end, bool optimize)
	{
		return false;
	}

	private void owner_HandleCreated(object sender, EventArgs e)
	{
	}

	private void owner_VisibleChanged(object sender, EventArgs e)
	{
	}

	internal static bool IsWordSeparator(char ch)
	{
		return false;
	}

	internal int FindWordSeparator(Line line, int pos, bool forward)
	{
		return 0;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
