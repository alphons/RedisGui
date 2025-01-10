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
			splitContainer1 = new SplitContainer();
			splitContainer2 = new SplitContainer();
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
			menuStrip1.SuspendLayout();
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
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1034, 24);
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
			// 
			// statusStrip1
			// 
			statusStrip1.Location = new Point(0, 474);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(1034, 22);
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
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
			splitContainer1.Size = new Size(1034, 450);
			splitContainer1.SplitterDistance = 315;
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
			splitContainer2.Panel1.Controls.Add(treeView1);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(label3);
			splitContainer2.Panel2.Controls.Add(label2);
			splitContainer2.Panel2.Controls.Add(lblKey);
			splitContainer2.Panel2.Controls.Add(lblType);
			splitContainer2.Panel2.Controls.Add(listView1);
			splitContainer2.Size = new Size(1034, 315);
			splitContainer2.SplitterDistance = 343;
			splitContainer2.SplitterWidth = 10;
			splitContainer2.TabIndex = 0;
			// 
			// treeView1
			// 
			treeView1.Dock = DockStyle.Fill;
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageList1;
			treeView1.Location = new Point(0, 0);
			treeView1.Name = "treeView1";
			treeView1.SelectedImageIndex = 0;
			treeView1.Size = new Size(343, 315);
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
			label3.Location = new Point(13, 46);
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
			lblKey.Location = new Point(61, 46);
			lblKey.Name = "lblKey";
			lblKey.Size = new Size(16, 15);
			lblKey.TabIndex = 2;
			lblKey.Text = "...";
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.Location = new Point(61, 16);
			lblType.Name = "lblType";
			lblType.Size = new Size(16, 15);
			lblType.TabIndex = 1;
			lblType.Text = "...";
			// 
			// listView1
			// 
			listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(12, 79);
			listView1.Name = "listView1";
			listView1.Size = new Size(651, 233);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Field";
			columnHeader1.Width = 175;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Value";
			columnHeader2.Width = 353;
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
			txtData.Size = new Size(1019, 113);
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
			closeConnectionToolStripMenuItem.Click += closeConnectionToolStripMenuItem_Click;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1034, 496);
			Controls.Add(splitContainer1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "FormMain";
			Text = "redisgui";
			Load += Form_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			contextMenuStrip1.ResumeLayout(false);
			contextMenuStrip2.ResumeLayout(false);
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
	}
}
