namespace Name_Case_Normalizer
{
	partial class FormNameCaseNormalizer
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBoxName = new TextBox();
			labelEnterYourName = new Label();
			buttonPush = new Button();
			labelNormalizedName = new Label();
			textBoxNormalizedName = new TextBox();
			SuspendLayout();
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(12, 27);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(276, 23);
			textBoxName.TabIndex = 0;
			textBoxName.KeyPress += textBoxName_KeyPress;
			// 
			// labelEnterYourName
			// 
			labelEnterYourName.AutoSize = true;
			labelEnterYourName.Location = new Point(12, 9);
			labelEnterYourName.Name = "labelEnterYourName";
			labelEnterYourName.Size = new Size(133, 15);
			labelEnterYourName.TabIndex = 1;
			labelEnterYourName.Text = "Please enter your name:";
			// 
			// buttonPush
			// 
			buttonPush.Location = new Point(12, 56);
			buttonPush.Name = "buttonPush";
			buttonPush.Size = new Size(75, 23);
			buttonPush.TabIndex = 2;
			buttonPush.Text = "Push";
			buttonPush.UseVisualStyleBackColor = true;
			buttonPush.Click += buttonPush_Click;
			// 
			// labelNormalizedName
			// 
			labelNormalizedName.AutoSize = true;
			labelNormalizedName.Location = new Point(12, 93);
			labelNormalizedName.Name = "labelNormalizedName";
			labelNormalizedName.Size = new Size(78, 15);
			labelNormalizedName.TabIndex = 3;
			labelNormalizedName.Text = "Your name is:";
			// 
			// textBoxNormalizedName
			// 
			textBoxNormalizedName.BackColor = SystemColors.Window;
			textBoxNormalizedName.Location = new Point(12, 111);
			textBoxNormalizedName.Multiline = true;
			textBoxNormalizedName.Name = "textBoxNormalizedName";
			textBoxNormalizedName.ReadOnly = true;
			textBoxNormalizedName.Size = new Size(276, 63);
			textBoxNormalizedName.TabIndex = 4;
			// 
			// FormNameCaseNormalizer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(299, 188);
			Controls.Add(textBoxNormalizedName);
			Controls.Add(labelNormalizedName);
			Controls.Add(buttonPush);
			Controls.Add(labelEnterYourName);
			Controls.Add(textBoxName);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "FormNameCaseNormalizer";
			Text = "Name Case Normalizer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxName;
		private Label labelEnterYourName;
		private Button buttonPush;
		private Label labelNormalizedName;
		private TextBox textBoxNormalizedName;
	}
}