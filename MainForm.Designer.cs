using TRTPO_CALC.Module;
using TRTPO_CALC.Operations;

namespace TRTPO_CALC
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>

		private void InitializeComponent()
		{
			this.calculator = new TRTPO_CALC.Module.Calculator();
			this.converter = new TRTPO_CALC.Module.Converter();
			this.SuspendLayout();
			// 
			// calculator
			// 
			this.calculator.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.calculator.Dock = System.Windows.Forms.DockStyle.Fill;
			this.calculator.Location = new System.Drawing.Point(3, 3);
			this.calculator.Name = "calculator";
			this.calculator.Size = new System.Drawing.Size(374, 474);
			this.calculator.TabIndex = 0;
			this.calculator.TabStop = false;
			this.calculator.Visible = false;
			// 
			// converter
			// 
			this.converter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.converter.Location = new System.Drawing.Point(3, 3);
			this.converter.Name = "converter";
			this.converter.Size = new System.Drawing.Size(374, 474);
			this.converter.TabIndex = 0;
			this.converter.TabStop = false;
			this.converter.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(380, 480);
			this.Controls.Add(this.converter);
			this.Controls.Add(this.calculator);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.Text = "CalCon";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Calculator calculator;
		private Converter converter;
	}
}

