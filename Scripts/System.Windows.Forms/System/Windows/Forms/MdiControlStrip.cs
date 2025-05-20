namespace System.Windows.Forms;

internal class MdiControlStrip
{
	public class SystemMenuItem : ToolStripMenuItem
	{
		private Form form;

		public Form MdiForm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SystemMenuItem(Form ownerForm)
		{
		}

		protected override void OnPaint(PaintEventArgs e)
		{
		}

		private void RestoreItemHandler(object sender, EventArgs e)
		{
		}

		private void MinimizeItemHandler(object sender, EventArgs e)
		{
		}

		private void CloseItemHandler(object sender, EventArgs e)
		{
		}

		private void NextItemHandler(object sender, EventArgs e)
		{
		}
	}

	public class ControlBoxMenuItem : ToolStripMenuItem
	{
		private Form form;

		private ControlBoxType type;

		public Form MdiForm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ControlBoxMenuItem(Form ownerForm, ControlBoxType type)
		{
		}

		protected override void OnPaint(PaintEventArgs e)
		{
		}

		private void RestoreItemHandler(object sender, EventArgs e)
		{
		}

		private void MinimizeItemHandler(object sender, EventArgs e)
		{
		}

		private void CloseItemHandler(object sender, EventArgs e)
		{
		}
	}

	public enum ControlBoxType
	{
		Close = 0,
		Min = 1,
		Max = 2
	}
}
