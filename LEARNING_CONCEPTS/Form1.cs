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
			// Solution (1)
			// هیچگاه برای دسترسی به
			// Property
			// های کنترل‌های کلاس پدر نباید
			// Access Modifier
			// های آن کنترل‌ها را از حالت
			// private
			// خارج نماییم
			// /Solution (1)

			// Solution (2)
			//MyExitButton.BackColor = System.Drawing.Color.Yellow;
			// /Solution (2)

			// Solution (3)
			ExitButtonBackColor = System.Drawing.Color.Yellow;
			// /Solution (3)
		}

		protected override void ExitButton_Click(object sender, System.EventArgs e)
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
				base.ExitButton_Click(sender, e);
			}
		}
	}
}
