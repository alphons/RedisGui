namespace RedisGui
{
    partial class Form1
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
			contextMenuStrip1 = new ContextMenuStrip(components);
			addConnectionToolStripMenuItem = new ToolStripMenuItem();
			imageList1 = new ImageList(components);
			txtJson = new TextBox();
			label3 = new Label();
			label2 = new Label();
			lblKey = new Label();
			lblType = new Label();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(801, 24);
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
			statusStrip1.Location = new Point(0, 428);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(801, 22);
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
			splitContainer1.Size = new Size(801, 404);
			splitContainer1.SplitterDistance = 322;
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
			splitContainer2.Panel2.Controls.Add(txtJson);
			splitContainer2.Panel2.Controls.Add(label3);
			splitContainer2.Panel2.Controls.Add(label2);
			splitContainer2.Panel2.Controls.Add(lblKey);
			splitContainer2.Panel2.Controls.Add(lblType);
			splitContainer2.Panel2.Controls.Add(listView1);
			splitContainer2.Size = new Size(801, 322);
			splitContainer2.SplitterDistance = 266;
			splitContainer2.TabIndex = 0;
			// 
			// treeView1
			// 
			treeView1.ContextMenuStrip = contextMenuStrip1;
			treeView1.Dock = DockStyle.Fill;
			treeView1.ImageIndex = 0;
			treeView1.ImageList = imageList1;
			treeView1.Location = new Point(0, 0);
			treeView1.Name = "treeView1";
			treeView1.SelectedImageIndex = 0;
			treeView1.Size = new Size(266, 322);
			treeView1.TabIndex = 0;
			treeView1.AfterSelect += treeView1_AfterSelect;
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
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageSize = new Size(24, 24);
			imageList1.TransparentColor = Color.Transparent;
			// 
			// txtJson
			// 
			txtJson.AcceptsReturn = true;
			txtJson.AcceptsTab = true;
			txtJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtJson.Location = new Point(12, 190);
			txtJson.Multiline = true;
			txtJson.Name = "txtJson";
			txtJson.ReadOnly = true;
			txtJson.ScrollBars = ScrollBars.Both;
			txtJson.Size = new Size(507, 129);
			txtJson.TabIndex = 5;
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
			listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(12, 79);
			listView1.Name = "listView1";
			listView1.Size = new Size(507, 97);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Field";
			columnHeader1.Width = 75;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Value";
			columnHeader2.Width = 300;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(801, 450);
			Controls.Add(splitContainer1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "redisgui";
			Load += Form1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			contextMenuStrip1.ResumeLayout(false);
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
		private TextBox txtJson;
	}
}
