using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld.App
{
  public class HelloWorld : IHelloWorld
  {
    public string Text()
    {
      return "Hello World";
    }
  }
}
