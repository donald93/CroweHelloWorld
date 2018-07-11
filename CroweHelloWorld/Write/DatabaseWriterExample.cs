using CroweHelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld.Write
{
  public class DatabaseWriterExample : IWrite
  {
    private string DatabasePrefix = "This is just an example to show the inheritance/dependency injection working: ";
    public void Write(string line)
    {
      Console.WriteLine(DatabasePrefix + line);
      Console.ReadLine();
    }
  }
}
