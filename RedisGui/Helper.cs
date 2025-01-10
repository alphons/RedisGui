using System.Buffers.Binary;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RedisGui;

public class Helper
{
	private static Int16 ReadInt16(byte[] b, ref int index)
	{
		var value = BinaryPrimitives.ReadInt16BigEndian(b.AsSpan(index, 2));
		index += 2;
		return value;
	}

	private static Int32 ReadInt32(byte[] b, ref int index)
	{
		var value = BinaryPrimitives.ReadInt32BigEndian(b.AsSpan(index, 4));
		index += 4;
		return value;
	}

	private static Guid ReadGuid(byte[] b, ref int index)
	{
		var guid = new Guid(b.AsSpan(index, 16));
		index += 16;
		return guid;
	}

	private static string ReadName(byte[] b, ref int index)
	{
		var lenName = ReadInt16(b, ref index);
		var name = Encoding.UTF8.GetString(b.AsSpan(index, lenName));
		index += lenName;
		return name;
	}

	private static string ReadVal(byte[] b, ref int index)
	{
		var lenVal = ReadInt32(b, ref index);
		var val = Encoding.UTF8.GetString(b.AsSpan(index, lenVal));
		index += lenVal;
		return val;
	}

	private static string ReadVersion(byte[] b, ref int index)
	{
		var major = b[index++];
		var minor = b[index++];
		return $"{major}.{minor}";
	}

	public static void SessionDecoder(ListView lv, byte[] b)
	{
		var index = 0;
		lv.Items.Add(new ListViewItem([ "Version", ReadVersion(b, ref index) ]));
		var count = ReadInt16(b, ref index);
		lv.Items.Add(new ListViewItem([ "Keys", count.ToString() ]));
		var guid = ReadGuid(b, ref index);
		lv.Items.Add(new ListViewItem([ "Guid", guid.ToString() ]));

		for (int i = 0; i < count; i++)
		{
			var name = ReadName(b, ref index);
			var val = ReadVal(b, ref index);
			lv.Items.Add(new ListViewItem([ name, val ]));
		}
	}

	public static string PrettyPrintJson(string json)
	{
		try
		{
			var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
			var options = new JsonSerializerOptions { WriteIndented = true };
			return Regex.Unescape(JsonSerializer.Serialize(jsonElement, options));
		}
		catch
		{
			return Regex.Unescape(json);
		}
	}

	public static string ConvertByteArrayToHexText(byte[] byteArray)
	{
		StringBuilder hexBuilder = new();

		for (int i = 0; i < byteArray.Length; i += 32)
		{
			var chunk = byteArray.Skip(i).Take(32).ToArray();
			var hexPart = string.Join(" ", chunk.Select((b, index) => (index > 0 && index % 16 == 0) ? $"- {b:X2}" : b.ToString("X2")));
			var asciiPart = new string(chunk.Select(b => (char)(b < 32 || b > 127 ? ' ' : (char)b)).ToArray());
			hexBuilder.AppendLine($"{i:X6} - {hexPart.PadRight(32 * 3 + 1)} - {asciiPart}");
		}

		return hexBuilder.ToString();
	}

}
