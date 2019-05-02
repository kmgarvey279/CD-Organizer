using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class CD
  {
    private string _title;
    private int _id;
    private static List<CD> _instances = new List<CD> {};

    public CD (string title)
    {
      _title = title;
      _instances.Add(this);
      _id = _instances.Count;

    }

    public string GetTitle()
    {
      return _title;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<CD> GetAll()
    {
      return _instances;
    }

    public static CD Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
