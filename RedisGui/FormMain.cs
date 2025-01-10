
using StackExchange.Redis;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;


namespace RedisGui
{
	public partial class FormMain : Form
	{
		private ConnectionMultiplexer? connection;
		private IServer? server;
		private IDatabase? db;

		public FormMain()
		{
			InitializeComponent();

			imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.World, 24));
			imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.NetworkConnect, 24));
			imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.Key, 24));

		}

		private void Form_Load(object sender, EventArgs e)
		{
			MakeConnection("127.0.0.1:6379");
		}

		private void AddConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MakeConnection("127.0.0.1:6379");
		}

		private void MakeConnection(string ConnectionString)
		{
			this.connection = ConnectionMultiplexer.Connect(ConnectionString, x => x.AllowAdmin = true);

			EndPoint endPoint = connection.GetEndPoints().First();

			this.server = connection.GetServer(endPoint);

			this.db = connection.GetDatabase();

			var node = this.treeView1.Nodes.Add("", endPoint.ToString(), 1, 1);

			LoadKeys(node);
		}

		private void LoadKeys(TreeNode node)
		{
			if (this.server == null)
				return;

			try
			{
				RedisKey[] keys = this.server.Keys(pattern: "*").ToArray();

				node.Nodes.Clear();

				foreach (var key in keys)
				{
					node.Nodes.Add(new TreeNode(key, 2, 2));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading keys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node == null)
				return;

			var key = new RedisKey(e.Node.Text);

			if (this.db == null)
				return;

			if (e.Node.Parent == null)
				return;

			if (!db.KeyExists(key))
			{
				e.Node.Remove();
				return;
			}

			ShowValue(key);

		}

		private static string PrettyPrintJson(string json)
		{
			try
			{
				var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
				var options = new JsonSerializerOptions { WriteIndented = true };
				return JsonSerializer.Serialize(jsonElement, options);
			}
			catch
			{
				return json;
			}
		}

		private static string ConvertByteArrayToHexText(byte[] byteArray)
		{
			StringBuilder hexBuilder = new();

			StringBuilder chars = new();

			for (int i = 0; i < byteArray.Length; i++)
			{
				if (i % 32 == 0)
				{
					hexBuilder.Append(i.ToString("X4"));
					hexBuilder.Append(" - ");
				}
				hexBuilder.Append(byteArray[i].ToString("X2"));
				hexBuilder.Append(' ');

				var c = (char)byteArray[i];
				if (c < ' ' || c > 0x7f)
					c = ' ';
				chars.Append(c);

				if ((i + 1) % 16 == 0)
				{
					hexBuilder.Append("- ");
				}

				if ((i + 1) % 32 == 0)
				{
					hexBuilder.AppendLine(chars.ToString());
					chars = new();
				}
			}

			var last = byteArray.Length % 32;
			var todo = (32 * 3) - 3 * last + 2;
			if (last < 16)
				todo += 2;
			if(todo>0)
			{
				for (int i = 0; i < todo; i++)
					hexBuilder.Append(' ');
				hexBuilder.AppendLine(chars.ToString());
			}

			return hexBuilder.ToString();
		}

		private void ShowValue(RedisKey key)
		{
			this.lblType.Text = "";
			this.lblKey.Text = "";

			this.listView1.Items.Clear();
			this.txtData.Clear();

			if (this.db == null)
				return;

			if (!db.KeyExists(key))
				return;

			RedisType type = this.db.KeyType(key);

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
									if (val.StartsWith('{') && val.EndsWith('}'))
										this.txtData.Text = Regex.Unescape(PrettyPrintJson(val));
									if (val[0]<0x10)
									{
										if(entry.Value.Box() is byte[] buffer)
										{
											this.txtData.Text = ConvertByteArrayToHexText(buffer);
										}
									}
									break;
							}
						}

						this.listView1.Items.Add(new ListViewItem([entry.Name.ToString(), val]));
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

			if (this.server == null)
				return;

			var kvs = await this.server.ConfigGetAsync("*");

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

			if (this.server == null)
				return;

			var groups = await this.server.InfoAsync();

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
			if (node != null)
			{
				if (node.Parent == null)
					this.contextMenuStrip2.Show(this.treeView1, e.Location);
				return;
			}

			this.contextMenuStrip1.Show(this.treeView1, e.Location);

		}

		async private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.treeView1.SelectedNode.Remove();
			this.db = null;
			this.server = null;
			if(this.connection != null)
				await this.connection.CloseAsync();
			this.connection = null;
		}
	}
}
