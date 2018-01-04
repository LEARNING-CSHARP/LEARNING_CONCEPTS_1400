namespace LEARNING_CONCEPTS
{
	public partial class Form1 : BaseForm
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// هیچگاه برای دسترسی به
			// Property
			// های کنترل‌های کلاس پدر نباید
			// Access Modifier
			// های آن کنترل‌ها را از حالت
			// private
			// خارج نماییم
			ExitButtonBackColor = System.Drawing.Color.Yellow;
		}

		protected override void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult result =
				System.Windows.Forms.MessageBox.Show
				(text: "آیا به خروج از برنامه اطمینان دارید؟",
				caption: "سوال",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (result == System.Windows.Forms.DialogResult.Yes)
			{
				base.exitButton_Click(sender, e);
			}
		}
	}
}
