using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Project.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private int _number;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, string address, int number)
    {
      _name = name;
      _address = address;
      _number = number;
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

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _name = newAddress;
    }

    public int GetNumber()
    {
      return _number;
    }

    public void SetNumber(int newNumber)
    {
      _number = newNumber;
    }

    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
