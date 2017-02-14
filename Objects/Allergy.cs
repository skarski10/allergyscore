using System.Collections.Generic;
using System;
using System.IO;

namespace AllergyApp.Objects
{
  public class Allergy
  {
    private static List<string> _allergyList = new List<string>();
    private int _userInput;

    public Allergy(int userInput)
    {
      _userInput = userInput;
      if(_userInput / 128 == 1)
      {
          _userInput = userInput - 128;
          _allergyList.Add("cats");
      }
      if(_userInput / 64 == 1)
      {
        _userInput = _userInput - 64;
        _allergyList.Add("pollen");
      }
      if(_userInput / 32 == 1)
      {
        _userInput = _userInput - 32;
        _allergyList.Add("chocolate");
      }
      if(_userInput / 16 == 1)
      {
        _userInput = _userInput - 16;
        _allergyList.Add("tomatoes");
      }
      if(_userInput / 8 == 1)
      {
        _userInput = _userInput - 8;
        _allergyList.Add("strawberries");
      }
      if(_userInput / 4 == 1)
      {
        _userInput = _userInput - 4;
        _allergyList.Add("shellfish");
      }
      if(_userInput / 2 == 1)
      {
        _userInput = _userInput - 2;
        _allergyList.Add("peanuts");
      }
      if(_userInput / 1 == 1)
      {
        _userInput = _userInput - 4;
        _allergyList.Add("eggs");
      }
    }

    public static List<string> GetAll()
    {
      return _allergyList;
    }

    public static void ClearAll()
    {
      _allergyList.Clear();
    }
  }
}
