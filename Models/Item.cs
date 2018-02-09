using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Project.Models
{
  public class Item
  {
    private string _name;
    private int _id;
    private static List<Item> _instances = new List<Item> {};

    public Item(string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
