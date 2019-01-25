namespace LEARNING_CONCEPTS
{
	public partial class BaseForm : System.Windows.Forms.Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

		// Solution (1)
		//protected System.Windows.Forms.Button exitButton; // In Designer File
		// /Solution (1)

		// Solution (2)
		//private System.Windows.Forms.Button exitButton; // In Designer File

		//protected System.Windows.Forms.Button MyExitButton
		//{
		//	get
		//	{
		//		return exitButton;
		//	}
		//}
		// /Solution (2)

		// Solution (3)
		//private System.Windows.Forms.Button exitButton; // In Designer File

		/// <summary>
		/// Property Bubbling
		/// </summary>
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
		// /Solution (3)

		private void BaseForm_Load(object sender, System.EventArgs e)
		{
			exitButton.BackColor = System.Drawing.Color.Khaki;
		}

		//private void ExitButton_Click(object sender, System.EventArgs e)
		//{
		//	System.Windows.Forms.Application.Exit();
		//}

		protected virtual void ExitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
