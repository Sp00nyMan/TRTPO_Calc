using System.Windows.Forms;

namespace TRTPO_CALC.Module
{
	partial class Calculator
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		public void InitializeComponent()
		{
			TRTPO_CALC.Operations.Power power1 = new TRTPO_CALC.Operations.Power();
			TRTPO_CALC.Operations.Division division1 = new TRTPO_CALC.Operations.Division();
			TRTPO_CALC.Operations.Multiplication multiplication1 = new TRTPO_CALC.Operations.Multiplication();
			TRTPO_CALC.Operations.Subtraction subtraction1 = new TRTPO_CALC.Operations.Subtraction();
			TRTPO_CALC.Operations.Equals equals1 = new TRTPO_CALC.Operations.Equals();
			TRTPO_CALC.Operations.Summation summation1 = new TRTPO_CALC.Operations.Summation();
			this.MainContainer = new System.Windows.Forms.SplitContainer();
			this.Container1 = new System.Windows.Forms.SplitContainer();
			this.Container1_1 = new System.Windows.Forms.SplitContainer();
			this.OutputBox = new System.Windows.Forms.TextBox();
			this.Container1_2 = new System.Windows.Forms.SplitContainer();
			this.Container1_2_1 = new System.Windows.Forms.SplitContainer();
			this.Button_Convert = new System.Windows.Forms.Button();
			this.Container1_2_2 = new System.Windows.Forms.SplitContainer();
			this.Button_Clear = new System.Windows.Forms.Button();
			this.Button_Backspace = new System.Windows.Forms.Button();
			this.Container1_3 = new System.Windows.Forms.SplitContainer();
			this.Container1_3_1 = new System.Windows.Forms.SplitContainer();
			this.Button_7 = new System.Windows.Forms.Button();
			this.Button_8 = new System.Windows.Forms.Button();
			this.Container1_3_2 = new System.Windows.Forms.SplitContainer();
			this.Button_9 = new System.Windows.Forms.Button();
			this.Container2 = new System.Windows.Forms.SplitContainer();
			this.Container2_1 = new System.Windows.Forms.SplitContainer();
			this.Container2_1_1 = new System.Windows.Forms.SplitContainer();
			this.Container2_1_1_1 = new System.Windows.Forms.SplitContainer();
			this.Button_4 = new System.Windows.Forms.Button();
			this.Button_5 = new System.Windows.Forms.Button();
			this.Container2_1_1_2 = new System.Windows.Forms.SplitContainer();
			this.Button_6 = new System.Windows.Forms.Button();
			this.Container2_2 = new System.Windows.Forms.SplitContainer();
			this.Container2_2_1 = new System.Windows.Forms.SplitContainer();
			this.Button_1 = new System.Windows.Forms.Button();
			this.Button_2 = new System.Windows.Forms.Button();
			this.Container2_2_2 = new System.Windows.Forms.SplitContainer();
			this.Button_3 = new System.Windows.Forms.Button();
			this.Container2_3 = new System.Windows.Forms.SplitContainer();
			this.Container2_3_1 = new System.Windows.Forms.SplitContainer();
			this.Button_Comma = new System.Windows.Forms.Button();
			this.Button_0 = new System.Windows.Forms.Button();
			this.Container2_3_2 = new System.Windows.Forms.SplitContainer();
			this.Button_Power = new System.Windows.Forms.Button();
			this.Button_Divide = new System.Windows.Forms.Button();
			this.Button_Mult = new System.Windows.Forms.Button();
			this.Button_Minus = new System.Windows.Forms.Button();
			this.Button_Equals = new System.Windows.Forms.Button();
			this.Button_Plus = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
			this.MainContainer.Panel1.SuspendLayout();
			this.MainContainer.Panel2.SuspendLayout();
			this.MainContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1)).BeginInit();
			this.Container1.Panel1.SuspendLayout();
			this.Container1.Panel2.SuspendLayout();
			this.Container1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1_1)).BeginInit();
			this.Container1_1.Panel1.SuspendLayout();
			this.Container1_1.Panel2.SuspendLayout();
			this.Container1_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1_2)).BeginInit();
			this.Container1_2.Panel1.SuspendLayout();
			this.Container1_2.Panel2.SuspendLayout();
			this.Container1_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1_2_1)).BeginInit();
			this.Container1_2_1.Panel1.SuspendLayout();
			this.Container1_2_1.Panel2.SuspendLayout();
			this.Container1_2_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1_2_2)).BeginInit();
			this.Container1_2_2.Panel1.SuspendLayout();
			this.Container1_2_2.Panel2.SuspendLayout();
			this.Container1_2_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1_3)).BeginInit();
			this.Container1_3.Panel1.SuspendLayout();
			this.Container1_3.Panel2.SuspendLayout();
			this.Container1_3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1_3_1)).BeginInit();
			this.Container1_3_1.Panel1.SuspendLayout();
			this.Container1_3_1.Panel2.SuspendLayout();
			this.Container1_3_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container1_3_2)).BeginInit();
			this.Container1_3_2.Panel1.SuspendLayout();
			this.Container1_3_2.Panel2.SuspendLayout();
			this.Container1_3_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2)).BeginInit();
			this.Container2.Panel1.SuspendLayout();
			this.Container2.Panel2.SuspendLayout();
			this.Container2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_1)).BeginInit();
			this.Container2_1.Panel1.SuspendLayout();
			this.Container2_1.Panel2.SuspendLayout();
			this.Container2_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_1_1)).BeginInit();
			this.Container2_1_1.Panel1.SuspendLayout();
			this.Container2_1_1.Panel2.SuspendLayout();
			this.Container2_1_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_1_1_1)).BeginInit();
			this.Container2_1_1_1.Panel1.SuspendLayout();
			this.Container2_1_1_1.Panel2.SuspendLayout();
			this.Container2_1_1_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_1_1_2)).BeginInit();
			this.Container2_1_1_2.Panel1.SuspendLayout();
			this.Container2_1_1_2.Panel2.SuspendLayout();
			this.Container2_1_1_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_2)).BeginInit();
			this.Container2_2.Panel1.SuspendLayout();
			this.Container2_2.Panel2.SuspendLayout();
			this.Container2_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_2_1)).BeginInit();
			this.Container2_2_1.Panel1.SuspendLayout();
			this.Container2_2_1.Panel2.SuspendLayout();
			this.Container2_2_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_2_2)).BeginInit();
			this.Container2_2_2.Panel1.SuspendLayout();
			this.Container2_2_2.Panel2.SuspendLayout();
			this.Container2_2_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_3)).BeginInit();
			this.Container2_3.Panel1.SuspendLayout();
			this.Container2_3.Panel2.SuspendLayout();
			this.Container2_3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_3_1)).BeginInit();
			this.Container2_3_1.Panel1.SuspendLayout();
			this.Container2_3_1.Panel2.SuspendLayout();
			this.Container2_3_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Container2_3_2)).BeginInit();
			this.Container2_3_2.Panel1.SuspendLayout();
			this.Container2_3_2.Panel2.SuspendLayout();
			this.Container2_3_2.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainContainer
			// 
			this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainContainer.IsSplitterFixed = true;
			this.MainContainer.Location = new System.Drawing.Point(0, 0);
			this.MainContainer.Margin = new System.Windows.Forms.Padding(0);
			this.MainContainer.Name = "MainContainer";
			this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// MainContainer.Panel1
			// 
			this.MainContainer.Panel1.Controls.Add(this.Container1);
			// 
			// MainContainer.Panel2
			// 
			this.MainContainer.Panel2.Controls.Add(this.Container2);
			this.MainContainer.Size = new System.Drawing.Size(402, 536);
			this.MainContainer.SplitterDistance = 265;
			this.MainContainer.TabIndex = 1;
			this.MainContainer.TabStop = false;
			// 
			// Container1
			// 
			this.Container1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1.IsSplitterFixed = true;
			this.Container1.Location = new System.Drawing.Point(0, 0);
			this.Container1.Margin = new System.Windows.Forms.Padding(0);
			this.Container1.Name = "Container1";
			this.Container1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Container1.Panel1
			// 
			this.Container1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container1.Panel1.Controls.Add(this.Container1_1);
			// 
			// Container1.Panel2
			// 
			this.Container1.Panel2.BackColor = System.Drawing.Color.Fuchsia;
			this.Container1.Panel2.Controls.Add(this.Container1_3);
			this.Container1.Size = new System.Drawing.Size(402, 265);
			this.Container1.SplitterDistance = 175;
			this.Container1.TabIndex = 0;
			this.Container1.TabStop = false;
			// 
			// Container1_1
			// 
			this.Container1_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container1_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1_1.IsSplitterFixed = true;
			this.Container1_1.Location = new System.Drawing.Point(0, 0);
			this.Container1_1.Name = "Container1_1";
			this.Container1_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Container1_1.Panel1
			// 
			this.Container1_1.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
			this.Container1_1.Panel1.Controls.Add(this.OutputBox);
			// 
			// Container1_1.Panel2
			// 
			this.Container1_1.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Container1_1.Panel2.Controls.Add(this.Container1_2);
			this.Container1_1.Size = new System.Drawing.Size(402, 175);
			this.Container1_1.SplitterDistance = 85;
			this.Container1_1.TabIndex = 0;
			this.Container1_1.TabStop = false;
			// 
			// OutputBox
			// 
			this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OutputBox.Location = new System.Drawing.Point(0, 0);
			this.OutputBox.Multiline = true;
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.ReadOnly = true;
			this.OutputBox.Size = new System.Drawing.Size(402, 85);
			this.OutputBox.TabIndex = 0;
			this.OutputBox.TabStop = false;
			this.OutputBox.WordWrap = false;
			// 
			// Container1_2
			// 
			this.Container1_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container1_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1_2.IsSplitterFixed = true;
			this.Container1_2.Location = new System.Drawing.Point(0, 0);
			this.Container1_2.Name = "Container1_2";
			// 
			// Container1_2.Panel1
			// 
			this.Container1_2.Panel1.Controls.Add(this.Container1_2_1);
			// 
			// Container1_2.Panel2
			// 
			this.Container1_2.Panel2.Controls.Add(this.Container1_2_2);
			this.Container1_2.Size = new System.Drawing.Size(402, 86);
			this.Container1_2.SplitterDistance = 198;
			this.Container1_2.TabIndex = 0;
			this.Container1_2.TabStop = false;
			// 
			// Container1_2_1
			// 
			this.Container1_2_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1_2_1.IsSplitterFixed = true;
			this.Container1_2_1.Location = new System.Drawing.Point(0, 0);
			this.Container1_2_1.Name = "Container1_2_1";
			// 
			// Container1_2_1.Panel1
			// 
			this.Container1_2_1.Panel1.Controls.Add(this.Button_Convert);
			// 
			// Container1_2_1.Panel2
			// 
			this.Container1_2_1.Panel2.Controls.Add(this.Button_Power);
			this.Container1_2_1.Size = new System.Drawing.Size(198, 86);
			this.Container1_2_1.SplitterDistance = 96;
			this.Container1_2_1.TabIndex = 0;
			this.Container1_2_1.TabStop = false;
			// 
			// Button_Convert
			// 
			this.Button_Convert.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Convert.Location = new System.Drawing.Point(0, 0);
			this.Button_Convert.Name = "Button_Convert";
			this.Button_Convert.Size = new System.Drawing.Size(96, 86);
			this.Button_Convert.TabIndex = 0;
			this.Button_Convert.Tag = "";
			this.Button_Convert.Text = "Convert";
			this.Button_Convert.UseVisualStyleBackColor = true;
			this.Button_Convert.Click += new System.EventHandler(this.OnConvertClicked);
			// 
			// Container1_2_2
			// 
			this.Container1_2_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1_2_2.IsSplitterFixed = true;
			this.Container1_2_2.Location = new System.Drawing.Point(0, 0);
			this.Container1_2_2.Name = "Container1_2_2";
			// 
			// Container1_2_2.Panel1
			// 
			this.Container1_2_2.Panel1.Controls.Add(this.Button_Clear);
			// 
			// Container1_2_2.Panel2
			// 
			this.Container1_2_2.Panel2.Controls.Add(this.Button_Backspace);
			this.Container1_2_2.Size = new System.Drawing.Size(200, 86);
			this.Container1_2_2.SplitterDistance = 98;
			this.Container1_2_2.TabIndex = 0;
			this.Container1_2_2.TabStop = false;
			// 
			// Button_Clear
			// 
			this.Button_Clear.AccessibleName = "clear";
			this.Button_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Clear.Location = new System.Drawing.Point(0, 0);
			this.Button_Clear.Name = "Button_Clear";
			this.Button_Clear.Size = new System.Drawing.Size(98, 86);
			this.Button_Clear.TabIndex = 0;
			this.Button_Clear.Tag = "control";
			this.Button_Clear.Text = "C";
			this.Button_Clear.UseVisualStyleBackColor = true;
			this.Button_Clear.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_Backspace
			// 
			this.Button_Backspace.AccessibleName = "backspace";
			this.Button_Backspace.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Backspace.Location = new System.Drawing.Point(0, 0);
			this.Button_Backspace.Name = "Button_Backspace";
			this.Button_Backspace.Size = new System.Drawing.Size(98, 86);
			this.Button_Backspace.TabIndex = 0;
			this.Button_Backspace.Tag = "control";
			this.Button_Backspace.Text = "<-";
			this.Button_Backspace.UseVisualStyleBackColor = true;
			this.Button_Backspace.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container1_3
			// 
			this.Container1_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container1_3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1_3.IsSplitterFixed = true;
			this.Container1_3.Location = new System.Drawing.Point(0, 0);
			this.Container1_3.Name = "Container1_3";
			// 
			// Container1_3.Panel1
			// 
			this.Container1_3.Panel1.Controls.Add(this.Container1_3_1);
			// 
			// Container1_3.Panel2
			// 
			this.Container1_3.Panel2.Controls.Add(this.Container1_3_2);
			this.Container1_3.Size = new System.Drawing.Size(402, 86);
			this.Container1_3.SplitterDistance = 198;
			this.Container1_3.TabIndex = 0;
			this.Container1_3.TabStop = false;
			// 
			// Container1_3_1
			// 
			this.Container1_3_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1_3_1.IsSplitterFixed = true;
			this.Container1_3_1.Location = new System.Drawing.Point(0, 0);
			this.Container1_3_1.Name = "Container1_3_1";
			// 
			// Container1_3_1.Panel1
			// 
			this.Container1_3_1.Panel1.Controls.Add(this.Button_7);
			// 
			// Container1_3_1.Panel2
			// 
			this.Container1_3_1.Panel2.Controls.Add(this.Button_8);
			this.Container1_3_1.Size = new System.Drawing.Size(198, 86);
			this.Container1_3_1.SplitterDistance = 96;
			this.Container1_3_1.TabIndex = 0;
			this.Container1_3_1.TabStop = false;
			// 
			// Button_7
			// 
			this.Button_7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_7.Location = new System.Drawing.Point(0, 0);
			this.Button_7.Name = "Button_7";
			this.Button_7.Size = new System.Drawing.Size(96, 86);
			this.Button_7.TabIndex = 0;
			this.Button_7.Tag = "digit";
			this.Button_7.Text = "7";
			this.Button_7.UseVisualStyleBackColor = true;
			this.Button_7.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_8
			// 
			this.Button_8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_8.Location = new System.Drawing.Point(0, 0);
			this.Button_8.Name = "Button_8";
			this.Button_8.Size = new System.Drawing.Size(98, 86);
			this.Button_8.TabIndex = 0;
			this.Button_8.Tag = "digit";
			this.Button_8.Text = "8";
			this.Button_8.UseVisualStyleBackColor = true;
			this.Button_8.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container1_3_2
			// 
			this.Container1_3_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container1_3_2.IsSplitterFixed = true;
			this.Container1_3_2.Location = new System.Drawing.Point(0, 0);
			this.Container1_3_2.Name = "Container1_3_2";
			// 
			// Container1_3_2.Panel1
			// 
			this.Container1_3_2.Panel1.Controls.Add(this.Button_9);
			// 
			// Container1_3_2.Panel2
			// 
			this.Container1_3_2.Panel2.Controls.Add(this.Button_Divide);
			this.Container1_3_2.Size = new System.Drawing.Size(200, 86);
			this.Container1_3_2.SplitterDistance = 98;
			this.Container1_3_2.TabIndex = 0;
			this.Container1_3_2.TabStop = false;
			// 
			// Button_9
			// 
			this.Button_9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_9.Location = new System.Drawing.Point(0, 0);
			this.Button_9.Name = "Button_9";
			this.Button_9.Size = new System.Drawing.Size(98, 86);
			this.Button_9.TabIndex = 0;
			this.Button_9.Tag = "digit";
			this.Button_9.Text = "9";
			this.Button_9.UseVisualStyleBackColor = true;
			this.Button_9.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container2
			// 
			this.Container2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2.IsSplitterFixed = true;
			this.Container2.Location = new System.Drawing.Point(0, 0);
			this.Container2.Name = "Container2";
			this.Container2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Container2.Panel1
			// 
			this.Container2.Panel1.Controls.Add(this.Container2_1);
			// 
			// Container2.Panel2
			// 
			this.Container2.Panel2.BackColor = System.Drawing.Color.Fuchsia;
			this.Container2.Panel2.Controls.Add(this.Container2_3);
			this.Container2.Size = new System.Drawing.Size(402, 267);
			this.Container2.SplitterDistance = 177;
			this.Container2.TabIndex = 0;
			this.Container2.TabStop = false;
			// 
			// Container2_1
			// 
			this.Container2_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_1.IsSplitterFixed = true;
			this.Container2_1.Location = new System.Drawing.Point(0, 0);
			this.Container2_1.Name = "Container2_1";
			this.Container2_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Container2_1.Panel1
			// 
			this.Container2_1.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
			this.Container2_1.Panel1.Controls.Add(this.Container2_1_1);
			// 
			// Container2_1.Panel2
			// 
			this.Container2_1.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Container2_1.Panel2.Controls.Add(this.Container2_2);
			this.Container2_1.Size = new System.Drawing.Size(402, 177);
			this.Container2_1.SplitterDistance = 86;
			this.Container2_1.TabIndex = 0;
			this.Container2_1.TabStop = false;
			// 
			// Container2_1_1
			// 
			this.Container2_1_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container2_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_1_1.IsSplitterFixed = true;
			this.Container2_1_1.Location = new System.Drawing.Point(0, 0);
			this.Container2_1_1.Name = "Container2_1_1";
			// 
			// Container2_1_1.Panel1
			// 
			this.Container2_1_1.Panel1.Controls.Add(this.Container2_1_1_1);
			// 
			// Container2_1_1.Panel2
			// 
			this.Container2_1_1.Panel2.Controls.Add(this.Container2_1_1_2);
			this.Container2_1_1.Size = new System.Drawing.Size(402, 86);
			this.Container2_1_1.SplitterDistance = 198;
			this.Container2_1_1.TabIndex = 0;
			this.Container2_1_1.TabStop = false;
			// 
			// Container2_1_1_1
			// 
			this.Container2_1_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_1_1_1.IsSplitterFixed = true;
			this.Container2_1_1_1.Location = new System.Drawing.Point(0, 0);
			this.Container2_1_1_1.Name = "Container2_1_1_1";
			// 
			// Container2_1_1_1.Panel1
			// 
			this.Container2_1_1_1.Panel1.Controls.Add(this.Button_4);
			// 
			// Container2_1_1_1.Panel2
			// 
			this.Container2_1_1_1.Panel2.Controls.Add(this.Button_5);
			this.Container2_1_1_1.Size = new System.Drawing.Size(198, 86);
			this.Container2_1_1_1.SplitterDistance = 96;
			this.Container2_1_1_1.TabIndex = 0;
			this.Container2_1_1_1.TabStop = false;
			// 
			// Button_4
			// 
			this.Button_4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_4.Location = new System.Drawing.Point(0, 0);
			this.Button_4.Name = "Button_4";
			this.Button_4.Size = new System.Drawing.Size(96, 86);
			this.Button_4.TabIndex = 0;
			this.Button_4.Tag = "digit";
			this.Button_4.Text = "4";
			this.Button_4.UseVisualStyleBackColor = true;
			this.Button_4.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_5
			// 
			this.Button_5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_5.Location = new System.Drawing.Point(0, 0);
			this.Button_5.Name = "Button_5";
			this.Button_5.Size = new System.Drawing.Size(98, 86);
			this.Button_5.TabIndex = 0;
			this.Button_5.Tag = "digit";
			this.Button_5.Text = "5";
			this.Button_5.UseVisualStyleBackColor = true;
			this.Button_5.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container2_1_1_2
			// 
			this.Container2_1_1_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_1_1_2.IsSplitterFixed = true;
			this.Container2_1_1_2.Location = new System.Drawing.Point(0, 0);
			this.Container2_1_1_2.Name = "Container2_1_1_2";
			// 
			// Container2_1_1_2.Panel1
			// 
			this.Container2_1_1_2.Panel1.Controls.Add(this.Button_6);
			// 
			// Container2_1_1_2.Panel2
			// 
			this.Container2_1_1_2.Panel2.Controls.Add(this.Button_Mult);
			this.Container2_1_1_2.Size = new System.Drawing.Size(200, 86);
			this.Container2_1_1_2.SplitterDistance = 98;
			this.Container2_1_1_2.TabIndex = 0;
			this.Container2_1_1_2.TabStop = false;
			// 
			// Button_6
			// 
			this.Button_6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_6.Location = new System.Drawing.Point(0, 0);
			this.Button_6.Name = "Button_6";
			this.Button_6.Size = new System.Drawing.Size(98, 86);
			this.Button_6.TabIndex = 0;
			this.Button_6.Tag = "digit";
			this.Button_6.Text = "6";
			this.Button_6.UseVisualStyleBackColor = true;
			this.Button_6.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container2_2
			// 
			this.Container2_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container2_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_2.IsSplitterFixed = true;
			this.Container2_2.Location = new System.Drawing.Point(0, 0);
			this.Container2_2.Name = "Container2_2";
			// 
			// Container2_2.Panel1
			// 
			this.Container2_2.Panel1.Controls.Add(this.Container2_2_1);
			// 
			// Container2_2.Panel2
			// 
			this.Container2_2.Panel2.Controls.Add(this.Container2_2_2);
			this.Container2_2.Size = new System.Drawing.Size(402, 87);
			this.Container2_2.SplitterDistance = 198;
			this.Container2_2.TabIndex = 0;
			this.Container2_2.TabStop = false;
			// 
			// Container2_2_1
			// 
			this.Container2_2_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_2_1.IsSplitterFixed = true;
			this.Container2_2_1.Location = new System.Drawing.Point(0, 0);
			this.Container2_2_1.Name = "Container2_2_1";
			// 
			// Container2_2_1.Panel1
			// 
			this.Container2_2_1.Panel1.Controls.Add(this.Button_1);
			// 
			// Container2_2_1.Panel2
			// 
			this.Container2_2_1.Panel2.Controls.Add(this.Button_2);
			this.Container2_2_1.Size = new System.Drawing.Size(198, 87);
			this.Container2_2_1.SplitterDistance = 96;
			this.Container2_2_1.TabIndex = 0;
			this.Container2_2_1.TabStop = false;
			// 
			// Button_1
			// 
			this.Button_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_1.Location = new System.Drawing.Point(0, 0);
			this.Button_1.Name = "Button_1";
			this.Button_1.Size = new System.Drawing.Size(96, 87);
			this.Button_1.TabIndex = 0;
			this.Button_1.Tag = "digit";
			this.Button_1.Text = "1";
			this.Button_1.UseVisualStyleBackColor = true;
			this.Button_1.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_2
			// 
			this.Button_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_2.Location = new System.Drawing.Point(0, 0);
			this.Button_2.Name = "Button_2";
			this.Button_2.Size = new System.Drawing.Size(98, 87);
			this.Button_2.TabIndex = 0;
			this.Button_2.Tag = "digit";
			this.Button_2.Text = "2";
			this.Button_2.UseVisualStyleBackColor = true;
			this.Button_2.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container2_2_2
			// 
			this.Container2_2_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_2_2.IsSplitterFixed = true;
			this.Container2_2_2.Location = new System.Drawing.Point(0, 0);
			this.Container2_2_2.Name = "Container2_2_2";
			// 
			// Container2_2_2.Panel1
			// 
			this.Container2_2_2.Panel1.Controls.Add(this.Button_3);
			// 
			// Container2_2_2.Panel2
			// 
			this.Container2_2_2.Panel2.Controls.Add(this.Button_Minus);
			this.Container2_2_2.Size = new System.Drawing.Size(200, 87);
			this.Container2_2_2.SplitterDistance = 98;
			this.Container2_2_2.TabIndex = 0;
			this.Container2_2_2.TabStop = false;
			// 
			// Button_3
			// 
			this.Button_3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_3.Location = new System.Drawing.Point(0, 0);
			this.Button_3.Name = "Button_3";
			this.Button_3.Size = new System.Drawing.Size(98, 87);
			this.Button_3.TabIndex = 0;
			this.Button_3.Tag = "digit";
			this.Button_3.Text = "3";
			this.Button_3.UseVisualStyleBackColor = true;
			this.Button_3.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container2_3
			// 
			this.Container2_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Container2_3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_3.IsSplitterFixed = true;
			this.Container2_3.Location = new System.Drawing.Point(0, 0);
			this.Container2_3.Name = "Container2_3";
			// 
			// Container2_3.Panel1
			// 
			this.Container2_3.Panel1.Controls.Add(this.Container2_3_1);
			// 
			// Container2_3.Panel2
			// 
			this.Container2_3.Panel2.Controls.Add(this.Container2_3_2);
			this.Container2_3.Size = new System.Drawing.Size(402, 86);
			this.Container2_3.SplitterDistance = 198;
			this.Container2_3.TabIndex = 0;
			this.Container2_3.TabStop = false;
			// 
			// Container2_3_1
			// 
			this.Container2_3_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_3_1.IsSplitterFixed = true;
			this.Container2_3_1.Location = new System.Drawing.Point(0, 0);
			this.Container2_3_1.Name = "Container2_3_1";
			// 
			// Container2_3_1.Panel1
			// 
			this.Container2_3_1.Panel1.Controls.Add(this.Button_Comma);
			// 
			// Container2_3_1.Panel2
			// 
			this.Container2_3_1.Panel2.Controls.Add(this.Button_0);
			this.Container2_3_1.Size = new System.Drawing.Size(198, 86);
			this.Container2_3_1.SplitterDistance = 96;
			this.Container2_3_1.TabIndex = 0;
			this.Container2_3_1.TabStop = false;
			// 
			// Button_Comma
			// 
			this.Button_Comma.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Comma.Location = new System.Drawing.Point(0, 0);
			this.Button_Comma.Name = "Button_Comma";
			this.Button_Comma.Size = new System.Drawing.Size(96, 86);
			this.Button_Comma.TabIndex = 0;
			this.Button_Comma.Tag = "digit";
			this.Button_Comma.Text = ",";
			this.Button_Comma.UseVisualStyleBackColor = true;
			this.Button_Comma.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_0
			// 
			this.Button_0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_0.Location = new System.Drawing.Point(0, 0);
			this.Button_0.Name = "Button_0";
			this.Button_0.Size = new System.Drawing.Size(98, 86);
			this.Button_0.TabIndex = 0;
			this.Button_0.Tag = "digit";
			this.Button_0.Text = "0";
			this.Button_0.UseVisualStyleBackColor = true;
			this.Button_0.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Container2_3_2
			// 
			this.Container2_3_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container2_3_2.IsSplitterFixed = true;
			this.Container2_3_2.Location = new System.Drawing.Point(0, 0);
			this.Container2_3_2.Name = "Container2_3_2";
			// 
			// Container2_3_2.Panel1
			// 
			this.Container2_3_2.Panel1.Controls.Add(this.Button_Equals);
			// 
			// Container2_3_2.Panel2
			// 
			this.Container2_3_2.Panel2.Controls.Add(this.Button_Plus);
			this.Container2_3_2.Size = new System.Drawing.Size(200, 86);
			this.Container2_3_2.SplitterDistance = 98;
			this.Container2_3_2.TabIndex = 0;
			this.Container2_3_2.TabStop = false;
			// 
			// Button_Power
			// 
			this.Button_Power.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Power.Location = new System.Drawing.Point(0, 0);
			this.Button_Power.Name = "Button_Power";
			this.Button_Power.Size = new System.Drawing.Size(98, 86);
			this.Button_Power.TabIndex = 0;
			this.Button_Power.Tag = power1;
			this.Button_Power.Text = "Power";
			this.Button_Power.UseVisualStyleBackColor = true;
			this.Button_Power.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_Divide
			// 
			this.Button_Divide.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Divide.Location = new System.Drawing.Point(0, 0);
			this.Button_Divide.Name = "Button_Divide";
			this.Button_Divide.Size = new System.Drawing.Size(98, 86);
			this.Button_Divide.TabIndex = 0;
			this.Button_Divide.Tag = division1;
			this.Button_Divide.Text = "/";
			this.Button_Divide.UseVisualStyleBackColor = true;
			this.Button_Divide.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_Mult
			// 
			this.Button_Mult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Mult.Location = new System.Drawing.Point(0, 0);
			this.Button_Mult.Name = "Button_Mult";
			this.Button_Mult.Size = new System.Drawing.Size(98, 86);
			this.Button_Mult.TabIndex = 0;
			this.Button_Mult.Tag = multiplication1;
			this.Button_Mult.Text = "X";
			this.Button_Mult.UseVisualStyleBackColor = true;
			this.Button_Mult.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_Minus
			// 
			this.Button_Minus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Minus.Location = new System.Drawing.Point(0, 0);
			this.Button_Minus.Name = "Button_Minus";
			this.Button_Minus.Size = new System.Drawing.Size(98, 87);
			this.Button_Minus.TabIndex = 0;
			this.Button_Minus.Tag = subtraction1;
			this.Button_Minus.Text = "-";
			this.Button_Minus.UseVisualStyleBackColor = true;
			this.Button_Minus.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_Equals
			// 
			this.Button_Equals.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Equals.Location = new System.Drawing.Point(0, 0);
			this.Button_Equals.Name = "Button_Equals";
			this.Button_Equals.Size = new System.Drawing.Size(98, 86);
			this.Button_Equals.TabIndex = 0;
			this.Button_Equals.Tag = equals1;
			this.Button_Equals.Text = "=";
			this.Button_Equals.UseVisualStyleBackColor = true;
			this.Button_Equals.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Button_Plus
			// 
			this.Button_Plus.AccessibleName = "";
			this.Button_Plus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Button_Plus.Location = new System.Drawing.Point(0, 0);
			this.Button_Plus.Name = "Button_Plus";
			this.Button_Plus.Size = new System.Drawing.Size(98, 86);
			this.Button_Plus.TabIndex = 0;
			this.Button_Plus.Tag = summation1;
			this.Button_Plus.Text = "+";
			this.Button_Plus.UseVisualStyleBackColor = true;
			this.Button_Plus.Click += new System.EventHandler(this.OnButtonClick);
			// 
			// Calculator
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.MainContainer);
			this.Name = "Calculator";
			this.Size = new System.Drawing.Size(402, 536);
			this.Load += new System.EventHandler(this.Calculator_Load);
			this.MainContainer.Panel1.ResumeLayout(false);
			this.MainContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
			this.MainContainer.ResumeLayout(false);
			this.Container1.Panel1.ResumeLayout(false);
			this.Container1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1)).EndInit();
			this.Container1.ResumeLayout(false);
			this.Container1_1.Panel1.ResumeLayout(false);
			this.Container1_1.Panel1.PerformLayout();
			this.Container1_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1_1)).EndInit();
			this.Container1_1.ResumeLayout(false);
			this.Container1_2.Panel1.ResumeLayout(false);
			this.Container1_2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1_2)).EndInit();
			this.Container1_2.ResumeLayout(false);
			this.Container1_2_1.Panel1.ResumeLayout(false);
			this.Container1_2_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1_2_1)).EndInit();
			this.Container1_2_1.ResumeLayout(false);
			this.Container1_2_2.Panel1.ResumeLayout(false);
			this.Container1_2_2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1_2_2)).EndInit();
			this.Container1_2_2.ResumeLayout(false);
			this.Container1_3.Panel1.ResumeLayout(false);
			this.Container1_3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1_3)).EndInit();
			this.Container1_3.ResumeLayout(false);
			this.Container1_3_1.Panel1.ResumeLayout(false);
			this.Container1_3_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1_3_1)).EndInit();
			this.Container1_3_1.ResumeLayout(false);
			this.Container1_3_2.Panel1.ResumeLayout(false);
			this.Container1_3_2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container1_3_2)).EndInit();
			this.Container1_3_2.ResumeLayout(false);
			this.Container2.Panel1.ResumeLayout(false);
			this.Container2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2)).EndInit();
			this.Container2.ResumeLayout(false);
			this.Container2_1.Panel1.ResumeLayout(false);
			this.Container2_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_1)).EndInit();
			this.Container2_1.ResumeLayout(false);
			this.Container2_1_1.Panel1.ResumeLayout(false);
			this.Container2_1_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_1_1)).EndInit();
			this.Container2_1_1.ResumeLayout(false);
			this.Container2_1_1_1.Panel1.ResumeLayout(false);
			this.Container2_1_1_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_1_1_1)).EndInit();
			this.Container2_1_1_1.ResumeLayout(false);
			this.Container2_1_1_2.Panel1.ResumeLayout(false);
			this.Container2_1_1_2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_1_1_2)).EndInit();
			this.Container2_1_1_2.ResumeLayout(false);
			this.Container2_2.Panel1.ResumeLayout(false);
			this.Container2_2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_2)).EndInit();
			this.Container2_2.ResumeLayout(false);
			this.Container2_2_1.Panel1.ResumeLayout(false);
			this.Container2_2_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_2_1)).EndInit();
			this.Container2_2_1.ResumeLayout(false);
			this.Container2_2_2.Panel1.ResumeLayout(false);
			this.Container2_2_2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_2_2)).EndInit();
			this.Container2_2_2.ResumeLayout(false);
			this.Container2_3.Panel1.ResumeLayout(false);
			this.Container2_3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_3)).EndInit();
			this.Container2_3.ResumeLayout(false);
			this.Container2_3_1.Panel1.ResumeLayout(false);
			this.Container2_3_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_3_1)).EndInit();
			this.Container2_3_1.ResumeLayout(false);
			this.Container2_3_2.Panel1.ResumeLayout(false);
			this.Container2_3_2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Container2_3_2)).EndInit();
			this.Container2_3_2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer MainContainer;
		private System.Windows.Forms.SplitContainer Container1;
		private System.Windows.Forms.SplitContainer Container1_1;
		private System.Windows.Forms.TextBox OutputBox;
		private System.Windows.Forms.SplitContainer Container1_2;
		private System.Windows.Forms.SplitContainer Container1_2_1;
		private System.Windows.Forms.Button Button_Convert;
		private System.Windows.Forms.Button Button_Power;
		private System.Windows.Forms.SplitContainer Container1_2_2;
		private System.Windows.Forms.Button Button_Clear;
		private System.Windows.Forms.Button Button_Backspace;
		private System.Windows.Forms.SplitContainer Container1_3;
		private System.Windows.Forms.SplitContainer Container1_3_1;
		private System.Windows.Forms.Button Button_7;
		private System.Windows.Forms.Button Button_8;
		private System.Windows.Forms.SplitContainer Container1_3_2;
		private System.Windows.Forms.Button Button_9;
		private System.Windows.Forms.Button Button_Divide;
		private System.Windows.Forms.SplitContainer Container2;
		private System.Windows.Forms.SplitContainer Container2_1;
		private System.Windows.Forms.SplitContainer Container2_1_1;
		private System.Windows.Forms.SplitContainer Container2_1_1_1;
		private System.Windows.Forms.Button Button_4;
		private System.Windows.Forms.Button Button_5;
		private System.Windows.Forms.SplitContainer Container2_1_1_2;
		private System.Windows.Forms.Button Button_6;
		private System.Windows.Forms.Button Button_Mult;
		private System.Windows.Forms.SplitContainer Container2_2;
		private System.Windows.Forms.SplitContainer Container2_2_1;
		private System.Windows.Forms.Button Button_1;
		private System.Windows.Forms.Button Button_2;
		private System.Windows.Forms.SplitContainer Container2_2_2;
		private System.Windows.Forms.Button Button_3;
		private System.Windows.Forms.Button Button_Minus;
		private System.Windows.Forms.SplitContainer Container2_3;
		private System.Windows.Forms.SplitContainer Container2_3_1;
		private System.Windows.Forms.Button Button_Comma;
		private System.Windows.Forms.Button Button_0;
		private System.Windows.Forms.SplitContainer Container2_3_2;
		private System.Windows.Forms.Button Button_Equals;
		private System.Windows.Forms.Button Button_Plus;
	}
}
