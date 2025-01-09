
using StackExchange.Redis;
using System.Diagnostics;
using System.Net;

#nullable enable

namespace RedisGui
{
	public partial class Form1 : Form
	{
		private ConnectionMultiplexer? connection;
		private IServer? server;
		private IDatabase? db;

		public Form1()
		{
			InitializeComponent();

			//foreach (StockIconId icon in Enum.GetValues(typeof(StockIconId)))
			//	imageList.Images.Add(icon.ToString(), SystemIcons.GetStockIcon(icon, 24));

			imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.World, 24));
			imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.NetworkConnect, 24));
			imageList1.Images.Add(SystemIcons.GetStockIcon(StockIconId.Key, 24));

			//toolStrip1.Items.AddRange(imageList.Images.Keys.Cast<string>().Select(x =>
			//	new ToolStripButton(imageList.Images[x]) { ToolTipText = x  }).ToArray());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MakeConnection("127.0.0.1:6379");
		}

		private void AddConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MakeConnection("127.0.0.1:6379");
		}

		private void MakeConnection(string ConnectionString)
		{
			this.connection = ConnectionMultiplexer.Connect(ConnectionString);

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

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node == null)
				return;

			RedisKey key = new RedisKey(e.Node.Text);

			ShowValue(key);

		}

		private void ShowValue(RedisKey key)
		{
			this.lblType.Text = "";
			this.lblKey.Text = "";

			this.listView1.Items.Clear();

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
					foreach (var entry in db.HashGetAll(key))
					{
						
						var val = entry.Value.ToString();
						var name = entry.Name.ToString();

						if (name.Contains("absexp") && val != "-1")
							val = new DateTime(long.Parse(val)).ToString();
						if (name.Contains("sldexp") && val != "-1")
							val = TimeSpan.FromMilliseconds(long.Parse(val)/10000).ToString();

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

		
	}
}
