using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<CD> _cds;

    public Artist(string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _cds = new List<CD>{};
    }

    public string GetName()
    {
      return _name;
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public List<CD> GetCDs()
    {
      return _cds;
    }

    public void AddCD(CD cd)
    {
      _cds.Add(cd);
    }

    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static Artist Search(string searchString)
    {
      foreach (Artist artist in _instances)
      {
        string name = artist.GetName();
        if (searchString.Contains(name))
        {
          return artist.GetId();
        }
      }
    }

  }
}
