using System.Text.Json;

namespace Terminkalender;

public class FileHelper
{
    private static string path = "termine.json";
    public static void saveTermine(List<Termin> termine)
    {
        string jsonContent = JsonSerializer.Serialize(termine);
        File.WriteAllText(path, jsonContent);
    }

    public static List<Termin> loadTermine()
    {
        if (!File.Exists(path))
        {
            return new List<Termin>();
        }
        string jsonContent = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Termin>>(jsonContent);
    }
}