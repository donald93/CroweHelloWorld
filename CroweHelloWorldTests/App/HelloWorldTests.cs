using CroweHelloWorld.App;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldTests.App
{
  [TestFixture]
  public class HelloWorldTests
  {
    private readonly string expectedText = "Hello World";

    [Test]
    public void Text_Returns_Hello_World()
    {
      var helloWorld = CreateHelloWorld();

      Assert.That(helloWorld.Text(), Is.EqualTo(expectedText));
    }

    private HelloWorld CreateHelloWorld()
    {
      return new HelloWorld();
    }
  }
}
