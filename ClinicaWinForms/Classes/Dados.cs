using System.Text.Json;
using System.IO;
using System.Collections.Generic;

public static class Persistencia
{
    public static void Salvar<T>(string caminho, List<T> dados)
    {
        string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(caminho, json);
    }

    public static List<T> Carregar<T>(string caminho)
    {
        if (!File.Exists(caminho)) return new List<T>();
        string json = File.ReadAllText(caminho);
        return JsonSerializer.Deserialize<List<T>>(json);
    }
}
