using CroweHelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld.Write
{
  public class ConsoleWriter : IWrite
  {

    public void Write(string line)
    {
      Console.WriteLine(line);
      Console.ReadLine();
    }
  }
}
