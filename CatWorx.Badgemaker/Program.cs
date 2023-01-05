using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

// Namespace used to organize separation of code - like modules in node.js
namespace CatWorx.Badgemaker
{
  class Program
  {
    // Main is invoked when the program runs. There can only be one entry point to a program
    // void signifies that the return of ths executable method will be void
    // static implies that the scope of the method is at the class level, not the object level
    async static Task Main(string[] args)
    {
      List<Employee> employees = PeopleFetcher.GetEmployees();
      List<Employee> employees1 = await PeopleFetcher.GetFromApi();
      // employees = await PeopleFetcher.GetFromApi();
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }
  }
}
