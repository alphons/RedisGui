
using Microsoft.Extensions.Configuration;

using StackExchange.Redis;
using System.Configuration;
using System.Diagnostics;
using System.Net;

namespace RedisGui;

public partial class FormMain : Form
{
	private readonly IConfiguration configuration;

	private readonly List<ConnectionPoint> connections = [];

	public FormMain()
	{
		InitializeComponent();

		var builder = new ConfigurationBuilder()
		   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
		this.configuration = builder.Build();

		var connectionStrings = configuration.GetSection("AppSettings:ConnectionStrings").Get<string[]>();

		if(connectionStrings != null)
			connections = connectionStrings.Select(x => new ConnectionPoint {  ConnectionString = x }).ToList();
		
		this.imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.World, 24));
		this.imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.NetworkConnect, 24));
		this.imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.Key, 24));
	}

	private async void Form_Load(object sender, EventArgs e)
	{
		await MakeConnectionAsync("127.0.0.1:6379");
	}

	private async void AddConnectionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		await MakeConnectionAsync("127.0.0.1:6379");
	}

	private async Task MakeConnectionAsync(string ConnectionString)
	{
		var connectionPoint = this.connections.FirstOrDefault(x => x.ConnectionString == ConnectionString);

		if (connectionPoint == null)
			return;

		foreach (TreeNode item in treeView1.Nodes)
		{
			if (item.Text == ConnectionString)
				return;
		}

		try
		{
			connectionPoint.Connection = await ConnectionMultiplexer.ConnectAsync(ConnectionString, x => x.AllowAdmin = true);
		}
		catch(RedisConnectionException)
		{
			return;
		}

		EndPoint endPoint = connectionPoint.Connection.GetEndPoints().First();

		connectionPoint.Server = connectionPoint.Connection.GetServer(endPoint);

		connectionPoint.Db = connectionPoint.Connection.GetDatabase();

		var connectionNode = new TreeNode(ConnectionString, 1, 1)
		{
			Tag = connectionPoint
		};

		var node = this.treeView1.Nodes.Add(connectionNode);

		await SearchAsync();

		this.timer1.Start();
	}

	private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (e.Node == null)
			return;

		var key = new RedisKey(e.Node.Text);

		if (e.Node.Parent == null)
			return;

		var connectionNode = e.Node.Parent;


		if (connectionNode.Tag is not ConnectionPoint connection || connection.Db == null)
			return;

		if (!connection.Db.KeyExists(key))
		{
			e.Node.Remove();
			return;
		}

		ShowValue(key);

	}


	private void ShowValue(RedisKey key)
	{
		this.lblType.Text = "";
		this.lblKey.Text = "";

		this.listView1.Items.Clear();
		this.txtData.Clear();

		if (this.treeView1.SelectedNode == null || this.treeView1.SelectedNode.Parent == null)
			return;


		if (this.treeView1.SelectedNode.Parent.Tag is not ConnectionPoint connectionNode || connectionNode.Db == null)
			return;

		var db = connectionNode.Db;

		if (!db.KeyExists(key))
			return;

		RedisType type = db.KeyType(key);

		this.lblType.Text = type.ToString();

		this.lblKey.Text = key.ToString();

		switch (type)
		{
			case RedisType.String:
				Debug.WriteLine($"String: {db.StringGet(key)}");
				break;
			case RedisType.Hash:
				foreach (HashEntry entry in db.HashGetAll(key))
				{

					var val = entry.Value.ToString();
					var name = entry.Name.ToString();

					if (val != "-1")
					{
						switch (name)
						{
							case "absexp":
								val = new DateTime(long.Parse(val)).ToString();
								break;
							case "sldexp":
								val = TimeSpan.FromMilliseconds(long.Parse(val) / 10000).ToString();
								break;
							case "data":
								name += $" ({val.Length})";
								if ((val.StartsWith('{') && val.EndsWith('}')) || (val.StartsWith('[') && val.EndsWith(']')))
								{
									this.txtData.Text = Helper.PrettyPrintJson(val);
								}
								if (val[0] == 0x02) // version 2.0
								{
									if (entry.Value.Box() is byte[] buffer)
									{
										//this.txtData.Text = Helper.ConvertByteArrayToHexText(buffer);
										Helper.SessionDecoder(this.listView1, name, buffer);
										continue;
									}
								}
								break;
						}
					}

					this.listView1.Items.Add(new ListViewItem([name, val]));
				}
				break;
			case RedisType.List:
				foreach (var item in db.ListRange(key))
				{
					Debug.WriteLine(item);
				}
				break;
			case RedisType.Set:
				foreach (var item in db.SetMembers(key))
				{
					Debug.WriteLine(item);
				}
				break;
			case RedisType.SortedSet:
				foreach (var item in db.SortedSetRangeByRankWithScores(key))
				{
					Debug.WriteLine($"{item.Element}: {item.Score}");
				}
				break;
			case RedisType.Stream:
				break;
			default:
				Debug.WriteLine($"Unknown type for key: {key}");
				break;
		}

	}

	private async Task ShowServerPropertiesAsync()
	{
		this.lblType.Text = "";
		this.lblKey.Text = "";

		this.listView1.Items.Clear();

		if (this.treeView1.SelectedNode == null)
			return;


		if (this.treeView1.SelectedNode.Tag is not ConnectionPoint connectionNode || connectionNode.Server == null)
			return;

		var kvs = await connectionNode.Server.ConfigGetAsync("*");

		foreach (var item in kvs)
		{
			this.listView1.Items.Add(new ListViewItem([item.Key, item.Value]));
		}
	}

	private async Task ShowServerInfoAsync()
	{
		this.lblType.Text = "";
		this.lblKey.Text = "";

		this.listView1.Items.Clear();

		if (this.treeView1.SelectedNode == null)
			return;


		if (this.treeView1.SelectedNode.Tag is not ConnectionPoint connectionNode || connectionNode.Server == null)
			return;

		var groups = await connectionNode.Server.InfoAsync();

		foreach (var group in groups)
		{
			this.listView1.Items.Add(new ListViewItem([group.Key, "======================"]));
			foreach (var item in group)
			{
				this.listView1.Items.Add(new ListViewItem([item.Key, item.Value]));
			}
		}
	}

	async private void ShowConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		await ShowServerPropertiesAsync();
	}

	async private void ShowInformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		await ShowServerInfoAsync();
	}

	private void TreeView_MouseUp(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			return;

		TreeNode node = this.treeView1.GetNodeAt(e.Location);
		if (node == null)
		{
			this.contextMenuStrip1.Show(this.treeView1, e.Location);
			return;
		}

		this.treeView1.SelectedNode = node;

		if (node.Parent == null)
			this.contextMenuStrip2.Show(this.treeView1, e.Location);
		else
			this.contextMenuStrip3.Show(this.treeView1, e.Location);
	}

	async private void CloseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.treeView1.SelectedNode == null)
			return;


		if (this.treeView1.SelectedNode.Tag is not ConnectionPoint connectionNode)
			return;

		if (connectionNode.Connection != null)
			await connectionNode.Connection.CloseAsync();

		connectionNode.Db = null;
		connectionNode.Server = null;
		connectionNode.Connection = null;

		this.treeView1.SelectedNode.Remove();
	}

	private void ListView_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.listView1.SelectedIndices.Count != 1)
			return;

		var lvi = this.listView1.Items[this.listView1.SelectedIndices[0]];

		if (lvi == null)
			return;

		if (lvi.Tag != null)
		{
			this.txtData.Text = Helper.ConvertByteArrayToHexText(lvi.Tag as byte[]);
			return;
		}

		var val = lvi.SubItems[1].Text;
		if ((val.StartsWith('{') && val.EndsWith('}')) || (val.StartsWith('[') && val.EndsWith(']')))
			this.txtData.Text = Helper.PrettyPrintJson(val);
		else
			this.txtData.Text = val;
	}

	private async void Timer_Tick(object sender, EventArgs e)
	{
		await SearchAsync();
	}

	private async Task SearchAsync()
	{
		var strSearch = this.txtSearch.Text.Trim();

		_ = int.TryParse(this.txtMaxKeys.Text, out int PageSize);

		foreach (TreeNode connectionNode in this.treeView1.Nodes)
		{
			if (connectionNode.Tag is not ConnectionPoint connectionPoint || connectionPoint.Server == null)
				continue;

			IAsyncEnumerator<RedisKey> keysAsync = connectionPoint
				.Server
				.KeysAsync(pattern: $"*{strSearch}*", pageSize: PageSize)
				.GetAsyncEnumerator();

			List<RedisKey> keys = [];
			while (await keysAsync.MoveNextAsync())
			{
				keys.Add(keysAsync.Current);
			}

			for (int j = connectionNode.Nodes.Count - 1; j >= 0; j--)
			{
				TreeNode keyNode = connectionNode.Nodes[j];

				if (keys.Contains(keyNode.Text))
					keys.Remove(keyNode.Text);
				else
					keyNode.Remove();
			}
			foreach (var newKey in keys)
			{
				connectionNode.Nodes.Add("", newKey, 2, 2);
			}
		}

	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	private async void Search_Click(object sender, EventArgs e)
	{
		await SearchAsync();
	}

	private async void DeleteKeyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.treeView1.SelectedNode == null)
			return;


		if (this.treeView1.SelectedNode.Tag is not ConnectionPoint connectionPoint || connectionPoint.Db == null)
			return;

		var key = this.treeView1.SelectedNode.Text;

		DialogResult result = MessageBox.Show("Delete the mofo?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

		if (result == DialogResult.OK)
		{
			await connectionPoint.Db.KeyDeleteAsync(new RedisKey(key));

			this.treeView1.SelectedNode.Remove();

			this.listView1.Items.Clear();
		}
	}

	private void FileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
	{
		this.toolStripMenuItem1.DropDownItems.Clear();

		List<string> connectionStrings = configuration
				.GetSection("AppSettings:ConnectionStrings")
				.Get<List<string>>() ?? [];
		this.toolStripMenuItem1.DropDownItems.AddRange(connectionStrings.Select(x => new ToolStripMenuItem(x)).ToArray());
	}

	private async void ToolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		var connectionString = e.ClickedItem?.Text;
		if (connectionString == null)
			return;
		await MakeConnectionAsync(connectionString);
	}
}
