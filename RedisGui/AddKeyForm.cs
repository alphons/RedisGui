namespace RedisGui;

public partial class AddKeyForm : Form
{
	public string? KeyType => this.comboBox1.SelectedValue?.ToString();

	public string KeyName => this.textBox1.Text.Trim();

	public string KeyValue => this.textBox2.Text.Trim();

	public AddKeyForm()
	{
		InitializeComponent();
	}

	private void OK_Click(object sender, EventArgs e)
	{
		this.DialogResult = DialogResult.OK;
		this.Close();
	}
}
