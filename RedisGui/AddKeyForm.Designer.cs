namespace RedisGui
{
	partial class AddKeyForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKeyForm));
			button1 = new Button();
			button2 = new Button();
			label1 = new Label();
			comboBox1 = new ComboBox();
			label2 = new Label();
			textBox1 = new TextBox();
			label3 = new Label();
			textBox2 = new TextBox();
			comboBox2 = new ComboBox();
			label4 = new Label();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(294, 258);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += OK_Click;
			// 
			// button2
			// 
			button2.Location = new Point(375, 258);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 1;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 15);
			label1.Name = "label1";
			label1.Size = new Size(31, 15);
			label1.TabIndex = 2;
			label1.Text = "Type";
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "string", "array", "set", "zset", "hash", "stream" });
			comboBox1.Location = new Point(53, 12);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(397, 23);
			comboBox1.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 51);
			label2.Name = "label2";
			label2.Size = new Size(26, 15);
			label2.TabIndex = 4;
			label2.Text = "Key";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(53, 48);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(397, 23);
			textBox1.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 83);
			label3.Name = "label3";
			label3.Size = new Size(35, 15);
			label3.TabIndex = 6;
			label3.Text = "Value";
			// 
			// textBox2
			// 
			textBox2.AcceptsReturn = true;
			textBox2.AcceptsTab = true;
			textBox2.Location = new Point(53, 80);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.ScrollBars = ScrollBars.Both;
			textBox2.Size = new Size(397, 140);
			textBox2.TabIndex = 7;
			// 
			// comboBox2
			// 
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "raw", "json", "to hex", "from hex", "to base64", "fron base64", "to unicode", "from unicode" });
			comboBox2.Location = new Point(354, 229);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(96, 23);
			comboBox2.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(312, 232);
			label4.Name = "label4";
			label4.Size = new Size(36, 15);
			label4.TabIndex = 9;
			label4.Text = "views";
			// 
			// AddKeyForm
			// 
			AcceptButton = button1;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = button2;
			ClientSize = new Size(464, 295);
			Controls.Add(label4);
			Controls.Add(comboBox2);
			Controls.Add(textBox2);
			Controls.Add(label3);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AddKeyForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "AddKeyForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Label label1;
		private ComboBox comboBox1;
		private Label label2;
		private TextBox textBox1;
		private Label label3;
		private TextBox textBox2;
		private ComboBox comboBox2;
		private Label label4;
	}
}