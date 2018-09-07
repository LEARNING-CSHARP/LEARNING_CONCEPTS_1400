namespace LEARNING_CONCEPTS
{
	public partial class BaseForm : System.Windows.Forms.Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

		//protected System.Windows.Forms.Button MyExitButton
		//{
		//	get
		//	{
		//		return exitButton;
		//	}
		//}

		protected System.Drawing.Color ExitButtonBackColor
		{
			get
			{
				return exitButton.BackColor;
			}
			set
			{
				exitButton.BackColor = value;
			}
		}

		private void BaseForm_Load(object sender, System.EventArgs e)
		{
			exitButton.BackColor = System.Drawing.Color.Khaki;
		}

		//private void exitButton_Click(object sender, System.EventArgs e)
		//{
		//	System.Windows.Forms.Application.Exit();
		//}

		protected virtual void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
