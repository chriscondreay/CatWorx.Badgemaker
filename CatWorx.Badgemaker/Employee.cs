using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.Badgemaker
{
  class Employee
  {
    public string FirstName;
    public string LastName;
    public int Id;
    public string PhotoUrl;
    public Employee(string firstName, string lastName, int id, string photoUrl) {
      FirstName = firstName;
      LastName = lastName;
      Id = id;
      PhotoUrl = photoUrl;
    }

    public string GetFullName() {
      return FirstName + " " + LastName;
    }

    public int GetId() {
      return Id;
    }

    public string GetPhotoUrl() {
      return PhotoUrl;
    }

    public string GetCompanyName() {
      return "Cat Worx";
    }
  }
}