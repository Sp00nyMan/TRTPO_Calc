using System;
using System.Windows.Forms;
using TRTPO_CALC.Handler;

namespace TRTPO_CALC.Module
{
	public partial class Converter : UserControl
	{
		public event MainForm.ModuleEvent OnModuleChanged;
		private TextBox selectedBox;
		private TextBox unselectedBox;

		private readonly ButtonHandler buttonHandler = new ButtonHandler();
		private readonly KeyHandler keyHandler = new KeyHandler();

		public Converter()
		{
			InitializeComponent();
			selectedBox = CurrencyTextBox1;
			unselectedBox = CurrencyTextBox2;

			buttonHandler.OnDigit += OnDigitEnter;
			buttonHandler.OnControl += OnControl;

			keyHandler.OnDigit += OnDigitEnter;
			keyHandler.OnControl += OnControl;
			CurrencyComboBox1.Items.AddRange(Enum.GetNames(typeof(CurrencyParser.Currency)));
			CurrencyComboBox2.Items.AddRange(Enum.GetNames(typeof(CurrencyParser.Currency)));
			CurrencyComboBox1.SelectedIndex = 0;
			CurrencyComboBox2.SelectedIndex = 1;
		}

		private void OnDigitEnter(object sender, object digit)
		{
			if (!(digit.ToString() == Button_Comma.Text && selectedBox.Text.Contains(Button_Comma.Text)))
				selectedBox.AppendText(digit.ToString());
		}

		private void OnControl(object sender, object argumens)
		{
			switch ((string) argumens)
			{
				case "clear":
					selectedBox.Clear();
					break;
				case "backspace":
					if (selectedBox.Text != string.Empty)
						selectedBox.Text = selectedBox.Text.Remove(selectedBox.Text.Length - 1, 1);
					break;
			}

			OnTextChanged();
		}


		void OnTextChanged()
		{
			unselectedBox.Clear();
			if (selectedBox.Text != string.Empty)
			{
				try
				{
					string currency1 = selectedBox == CurrencyTextBox1 ? CurrencyComboBox1.Text : CurrencyComboBox2.Text;
					string currency2 = selectedBox == CurrencyTextBox1 ? CurrencyComboBox2.Text : CurrencyComboBox1.Text;
					double exchangeRate = CurrencyParser.getExchangeRate(currency1, currency2);
					unselectedBox.AppendText($"{Math.Round(double.Parse(selectedBox.Text) * exchangeRate, 4)}");
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
				}
			}
		}

		private void OnCalcClick(object sender, EventArgs e)
		{
			OnModuleChanged?.Invoke(this);
		}

		private void CurrencyTextBoxMouseClick(object sender, MouseEventArgs e)
		{
			unselectedBox = selectedBox;
			unselectedBox.BorderStyle = BorderStyle.None;
			selectedBox = (TextBox) sender;
			selectedBox.BorderStyle = BorderStyle.Fixed3D;
		}

		private void OnButtonClick(object sender, EventArgs e)
		{
			buttonHandler.Handle(this, sender);
			OnTextChanged();
		}

		private void OnKeyPressed(object sender, KeyPressEventArgs e)
		{
			keyHandler.Handle(this, e);
			e.Handled = true;
			OnTextChanged();
		}

		private void Converter_Load(object sender, EventArgs e)
		{
			Parent.KeyPress += OnKeyPressed;
		}

		private void SelectedIndexChanged(object sender, EventArgs e)
		{
			OnTextChanged();
		}
	}

}
