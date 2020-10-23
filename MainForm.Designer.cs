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
			this.calculator1 = new TRTPO_CALC.Module.Calculator();
			this.SuspendLayout();
			// 
			// calculator1
			// 
			this.calculator1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.calculator1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.calculator1.Location = new System.Drawing.Point(3, 3);
			this.calculator1.Name = "calculator1";
			this.calculator1.Size = new System.Drawing.Size(374, 474);
			this.calculator1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(380, 480);
			this.Controls.Add(this.calculator1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.Text = "CalCon";
			this.ResumeLayout(false);

		}

		#endregion

		private Calculator calculator1;
	}
}

