namespace LEARNING_CONCEPTS
{
	public partial class BaseForm : System.Windows.Forms.Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

		protected System.Drawing.Color ExitButtonBackColor
		{
			get
			{
				return (exitButton.BackColor);
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

		protected virtual void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
