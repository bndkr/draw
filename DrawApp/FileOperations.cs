using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
  public class JsonDrawObject
  {
    public string? name { get; set; }
    public int x { get; set; }
    public int y { get; set; }
  }

  public static class FileOperations
  {
    public static void SaveFile(Control.ControlCollection colloction, string path)
    {
      var objects = new List<JsonDrawObject>();
      foreach (var item in colloction)
      {
        var drawObject = (DrawObject)item;
        var json = new JsonDrawObject {
          name = drawObject.m_name,
          x = drawObject.m_xpos,
          y = drawObject.m_ypos,
        };
        objects.Add(json);
      }
      var file = System.Text.Json.JsonSerializer.Serialize(objects);
      System.IO.File.WriteAllText(path, file);
    }
    public static List<JsonDrawObject>? LoadFile(string path)
    {
      var file = System.IO.File.ReadAllText(path);
      var jsonObject = System.Text.Json.JsonSerializer.Deserialize<List<JsonDrawObject>>(file);
      return jsonObject;
    }
  }
}
