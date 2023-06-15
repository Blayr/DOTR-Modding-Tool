using System;
using System.IO;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

public class ConfigManager
{
  private static ConfigManager instance;
  private string filePath;
  private ConfigData configData;

  private ConfigManager(string filePath)
  {
    this.filePath = filePath;
    configData = new ConfigData();
  }

  public static void InitializeInstance(string filePath)
  {
    if (instance != null)
    {
      throw new InvalidOperationException("ConfigManager instance has already been initialized.");
    }
    instance = new ConfigManager(filePath);
    instance.LoadConfig();
  }
  public static ConfigManager Instance
  {
    get
    {
      if (instance == null)
      {
        throw new InvalidOperationException("ConfigManager has not been initialized. Call InitializeInstance first.");
      }
      return instance;
    }
  }

  public void LoadConfig()
  {
    if (File.Exists(filePath))
    {
      try
      {
        using (var file = new StreamReader(filePath))
        {
          var deserializer = new DeserializerBuilder().Build();
          configData = deserializer.Deserialize<ConfigData>(file);
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error loading config file: " + ex.Message);
      }
    } else {
        // Create a new config file
        SaveConfig();
    }
  }

  public void SaveConfig()
  {
    try
    {
      var serializer = new SerializerBuilder().Build();
      var yaml = serializer.Serialize(configData);

      using (var file = new StreamWriter(filePath))
      {
        file.Write(yaml);
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine("Error saving config file: " + ex.Message);
    }
  }

  public string GetIsoPath()
  {
    return configData.IsoPath;
  }

  public void SetIsoPath(string isoPath)
  {
    configData.IsoPath = isoPath;
  }

  public bool GetSkipIsoDialog()
  {
    return configData.SkipIsoDialog;
  }

  public void SetSkipIsoDialog(bool skipIsoDialog)
  {
    configData.SkipIsoDialog = skipIsoDialog;
  }
}

public class ConfigData
{
  public string IsoPath
  {
    get { return isoPath; }
    set { isoPath = value; }
  }
  private string isoPath;

  public bool SkipIsoDialog
  {
    get { return skipIsoDialog; }
    set { skipIsoDialog = value; }
  }
  private bool skipIsoDialog;
}
