namespace RedisGui
{
    partial class FormMain
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
			components = new System.ComponentModel.Container();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			splitContainer1 = new SplitContainer();
			splitContainer2 = new SplitContainer();
			button1 = new Button();
			txtMaxKeys = new TextBox();
			label4 = new Label();
			txtSearch = new TextBox();
			treeView1 = new TreeView();
			imageList1 = new ImageList(components);
			label3 = new Label();
			label2 = new Label();
			lblKey = new Label();
			lblType = new Label();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			txtData = new TextBox();
			contextMenuStrip1 = new ContextMenuStrip(components);
			addConnectionToolStripMenuItem = new ToolStripMenuItem();
			contextMenuStrip2 = new ContextMenuStrip(components);
			showInformationToolStripMenuItem = new ToolStripMenuItem();
			showConfigurationToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			closeConnectionToolStripMenuItem = new ToolStripMenuItem();
			timer1 = new System.Windows.Forms.Timer(components);
			contextMenuStrip3 = new ContextMenuStrip(components);
			deleteKeyToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			contextMenuStrip1.SuspendLayout();
			contextMenuStrip2.SuspendLayout();
			contextMenuStrip3.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1074, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(93, 22);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
			statusStrip1.Location = new Point(0, 522);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1074, 22);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Image = Properties.Resources.blue;
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.RightToLeftAutoMirrorImage = true;
			toolStripStatusLabel1.Size = new Size(16, 17);
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 24);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(txtData);
			splitContainer1.Size = new Size(1074, 498);
			splitContainer1.SplitterDistance = 300;
			splitContainer1.SplitterWidth = 10;
			splitContainer1.TabIndex = 2;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(button1);
			splitContainer2.Panel1.Controls.Add(txtMaxKeys);
			splitContainer2.Panel1.Controls.Add(label4);
			splitContainer2.Panel1.Controls.Add(txtSearch);
			splitContainer2.Panel1.Controls.Add(treeView1);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(label3);
			splitContainer2.Panel2.Controls.Add(label2);
			splitContainer2.Panel2.Controls.Add(lblKey);
			splitContainer2.Panel2.Controls.Add(lblType);
			splitContainer2.Panel2.Controls.Add(listView1);
			splitContainer2.Size = new Size(1074, 300);
			splitContainer2.SplitterDistance = 355;
			splitContainer2.SplitterWidth = 10;
			splitContainer2.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(152, 10);
			button1.Name = "button1";
			button1.Size = new Size(61, 23);
			button1.TabIndex = 5;
			button1.Text = "search";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Search_Click;
			// 
			// txtMaxKeys
			// 
			txtMaxKeys.Location = new Point(279, 10);
			txtMaxKeys.Name = "txtMaxKeys";
			txtMaxKeys.Size = new Size(41, 23);
			txtMaxKeys.TabIndex = 4;
			txtMaxKeys.Text = "100";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(219, 13);
			label4.Name = "label4";
			label4.Size = new Size(54, 15);
			label4.TabIndex = 3;
			label4.Text = "MaxKeys";
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(3, 10);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(143, 23);
			txtSearch.TabIndex = 2;
			// 
			// treeView1
			// 
			treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageList1;
			treeView1.Location = new Point(0, 49);
			treeView1.Name = "treeView1";
			treeView1.SelectedImageIndex = 0;
			treeView1.Size = new Size(355, 251);
			treeView1.TabIndex = 0;
			treeView1.AfterSelect += TreeView_AfterSelect;
			treeView1.MouseUp += TreeView_MouseUp;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageSize = new Size(24, 24);
			imageList1.TransparentColor = Color.Transparent;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(172, 17);
			label3.Name = "label3";
			label3.Size = new Size(29, 15);
			label3.TabIndex = 4;
			label3.Text = "Key:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(13, 17);
			label2.Name = "label2";
			label2.Size = new Size(34, 15);
			label2.TabIndex = 3;
			label2.Text = "Type:";
			// 
			// lblKey
			// 
			lblKey.AutoSize = true;
			lblKey.Location = new Point(222, 17);
			lblKey.Name = "lblKey";
			lblKey.Size = new Size(16, 15);
			lblKey.TabIndex = 2;
			lblKey.Text = "...";
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.Location = new Point(68, 17);
			lblType.Name = "lblType";
			lblType.Size = new Size(16, 15);
			lblType.TabIndex = 1;
			lblType.Text = "...";
			// 
			// listView1
			// 
			listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			listView1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(12, 49);
			listView1.Name = "listView1";
			listView1.Size = new Size(685, 248);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			listView1.SelectedIndexChanged += ListView_SelectedIndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Field";
			columnHeader1.Width = 175;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Value";
			columnHeader2.Width = 500;
			// 
			// txtData
			// 
			txtData.AcceptsReturn = true;
			txtData.AcceptsTab = true;
			txtData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtData.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtData.Location = new Point(3, 3);
			txtData.Multiline = true;
			txtData.Name = "txtData";
			txtData.ReadOnly = true;
			txtData.ScrollBars = ScrollBars.Both;
			txtData.Size = new Size(1059, 140);
			txtData.TabIndex = 5;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addConnectionToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(171, 26);
			// 
			// addConnectionToolStripMenuItem
			// 
			addConnectionToolStripMenuItem.Name = "addConnectionToolStripMenuItem";
			addConnectionToolStripMenuItem.Size = new Size(170, 22);
			addConnectionToolStripMenuItem.Text = "Add Connection...";
			addConnectionToolStripMenuItem.Click += AddConnectionToolStripMenuItem_Click;
			// 
			// contextMenuStrip2
			// 
			contextMenuStrip2.Items.AddRange(new ToolStripItem[] { showInformationToolStripMenuItem, showConfigurationToolStripMenuItem, toolStripSeparator1, closeConnectionToolStripMenuItem });
			contextMenuStrip2.Name = "contextMenuStrip2";
			contextMenuStrip2.Size = new Size(181, 76);
			// 
			// showInformationToolStripMenuItem
			// 
			showInformationToolStripMenuItem.Name = "showInformationToolStripMenuItem";
			showInformationToolStripMenuItem.Size = new Size(180, 22);
			showInformationToolStripMenuItem.Text = "Show Information";
			showInformationToolStripMenuItem.Click += ShowInformationToolStripMenuItem_Click;
			// 
			// showConfigurationToolStripMenuItem
			// 
			showConfigurationToolStripMenuItem.Name = "showConfigurationToolStripMenuItem";
			showConfigurationToolStripMenuItem.Size = new Size(180, 22);
			showConfigurationToolStripMenuItem.Text = "Show Configuration";
			showConfigurationToolStripMenuItem.Click += ShowConfigurationToolStripMenuItem_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(177, 6);
			// 
			// closeConnectionToolStripMenuItem
			// 
			closeConnectionToolStripMenuItem.Name = "closeConnectionToolStripMenuItem";
			closeConnectionToolStripMenuItem.Size = new Size(180, 22);
			closeConnectionToolStripMenuItem.Text = "Close Connection";
			closeConnectionToolStripMenuItem.Click += CloseConnectionToolStripMenuItem_Click;
			// 
			// timer1
			// 
			timer1.Interval = 5000;
			timer1.Tick += Timer_Tick;
			// 
			// contextMenuStrip3
			// 
			contextMenuStrip3.Items.AddRange(new ToolStripItem[] { deleteKeyToolStripMenuItem });
			contextMenuStrip3.Name = "contextMenuStrip3";
			contextMenuStrip3.Size = new Size(130, 26);
			// 
			// deleteKeyToolStripMenuItem
			// 
			deleteKeyToolStripMenuItem.Name = "deleteKeyToolStripMenuItem";
			deleteKeyToolStripMenuItem.Size = new Size(129, 22);
			deleteKeyToolStripMenuItem.Text = "Delete Key";
			deleteKeyToolStripMenuItem.Click += DeleteKeyToolStripMenuItem_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1074, 544);
			Controls.Add(splitContainer1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "FormMain";
			Text = "redisgui";
			Load += Form_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel1.PerformLayout();
			splitContainer2.Panel2.ResumeLayout(false);
			splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			contextMenuStrip1.ResumeLayout(false);
			contextMenuStrip2.ResumeLayout(false);
			contextMenuStrip3.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private StatusStrip statusStrip1;
		private SplitContainer splitContainer1;
		private SplitContainer splitContainer2;
		private TreeView treeView1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem addConnectionToolStripMenuItem;
		private ImageList imageList1;
		private Label lblType;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private Label label3;
		private Label label2;
		private Label lblKey;
		private TextBox txtData;
		private ContextMenuStrip contextMenuStrip2;
		private ToolStripMenuItem showConfigurationToolStripMenuItem;
		private ToolStripMenuItem showInformationToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem closeConnectionToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ContextMenuStrip contextMenuStrip3;
		private ToolStripMenuItem deleteKeyToolStripMenuItem;
		private TextBox txtMaxKeys;
		private Label label4;
		private TextBox txtSearch;
		private Button button1;
	}
}
