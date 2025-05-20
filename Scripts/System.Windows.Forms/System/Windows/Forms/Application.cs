using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms;

/// <summary>Provides <see langword="static" /> methods and properties to manage an application, such as methods to start and stop an application, to process Windows messages, and properties to get information about an application. This class cannot be inherited.</summary>
public sealed class Application
{
	internal class MWFThread
	{
		private ApplicationContext context;

		private bool messageloop_started;

		private bool handling_exception;

		private int thread_id;

		private static readonly Hashtable threads;

		public ApplicationContext Context
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool MessageLoop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandlingException
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int LoopCount => 0;

		public static MWFThread Current => null;

		private MWFThread()
		{
		}

		public void Exit()
		{
		}
	}

	private static bool browser_embedded;

	private static InputLanguage input_language;

	private static string safe_caption_format;

	private static readonly ArrayList message_filters;

	private static readonly FormCollection forms;

	private static ToolStrip keyboard_capture;

	private static VisualStyleState visual_style_state;

	private static bool visual_styles_enabled;

	internal static bool use_compatible_text_rendering;

	private static EventHandler ApplicationExit;

	private static EventHandler ThreadExit;

	private static ThreadExceptionEventHandler ThreadException;

	private static EventHandler FormAdded;

	private static EventHandler PreRun;

	/// <summary>Gets a value indicating whether the caller can quit this application.</summary>
	/// <returns>
	///   <see langword="true" /> if the caller can quit this application; otherwise, <see langword="false" />.</returns>
	public static bool AllowQuit => false;

	/// <summary>Gets or sets the culture information for the current thread.</summary>
	/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> representing the culture information for the current thread.</returns>
	public static CultureInfo CurrentCulture => null;

	/// <summary>Gets a value indicating whether a message loop exists on this thread.</summary>
	/// <returns>
	///   <see langword="true" /> if a message loop exists; otherwise, <see langword="false" />.</returns>
	public static bool MessageLoop => false;

	/// <summary>Gets a value specifying whether the current application is drawing controls with visual styles.</summary>
	/// <returns>
	///   <see langword="true" /> if visual styles are enabled for controls in the client area of application windows; otherwise, <see langword="false" />.</returns>
	public static bool RenderWithVisualStyles => false;

	/// <summary>Gets a value that specifies how visual styles are applied to application windows.</summary>
	/// <returns>A bitwise combination of the <see cref="T:System.Windows.Forms.VisualStyles.VisualStyleState" /> values.</returns>
	public static VisualStyleState VisualStyleState => default(VisualStyleState);

	internal static ToolStrip KeyboardCapture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal static bool VisualStylesEnabled => false;

	static Application()
	{
	}

	private static void InitializeUIAutomation()
	{
	}

	/// <summary>Processes all Windows messages currently in the message queue.</summary>
	public static void DoEvents()
	{
	}

	/// <summary>Runs any filters against a window message, and returns a copy of the modified message.</summary>
	/// <param name="message">The Windows event message to filter.</param>
	/// <returns>
	///   <see langword="true" /> if the filters were processed; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static bool FilterMessage(ref Message message)
	{
		return false;
	}

	/// <summary>Informs all message pumps that they must terminate, and then closes all application windows after the messages have been processed.</summary>
	public static void Exit()
	{
	}

	/// <summary>Informs all message pumps that they must terminate, and then closes all application windows after the messages have been processed.</summary>
	/// <param name="e">Returns whether any <see cref="T:System.Windows.Forms.Form" /> within the application cancelled the exit.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static void Exit(CancelEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Application.ThreadException" /> event.</summary>
	/// <param name="t">An <see cref="T:System.Exception" /> that represents the exception that was thrown.</param>
	public static void OnThreadException(Exception t)
	{
	}

	internal static void FirePreRun()
	{
	}

	private static void DisableFormsForModalLoop(Queue toplevels, ApplicationContext context)
	{
	}

	private static void EnableFormsForModalLoop(Queue toplevels, ApplicationContext context)
	{
	}

	internal static void RunLoop(bool Modal, ApplicationContext context)
	{
	}

	internal static void AddForm(Form f)
	{
	}

	internal static void RemoveForm(Form f)
	{
	}

	private static bool ControlOnToolStrip(Control c)
	{
		return false;
	}
}
