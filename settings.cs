using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class Settings
{
    private Dictionary<string, object> _data;
    private string _filePath;

    public Settings(string filePath)
    {
        _data = new Dictionary<string, object>();
        _filePath = filePath;
        LoadData();
    }

    public object this[string key]
    {
        get => _data.ContainsKey(key) ? _data[key] : null;
        set
        {
            if (_data.ContainsKey(key))
                _data[key] = value;
            else
                _data.Add(key, value);

            SaveData();
        }
    }
    public bool TestKey(string key)
    {
        if (_data.ContainsKey(key))
            return true;
        else
            return false;
    }
    private void SaveData()
    {
        string jsonData = JsonConvert.SerializeObject(_data, Formatting.Indented);
        File.WriteAllText(_filePath, jsonData);
    }

    private void LoadData()
    {
        if (File.Exists(_filePath))
        {
            string jsonData = File.ReadAllText(_filePath);
            _data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
        }
    }
}
