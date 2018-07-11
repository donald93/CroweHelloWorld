using CroweHelloWorld.App;
using CroweHelloWorld.Interfaces;
using CroweHelloWorld.Properties;
using CroweHelloWorld.Write;
using Unity;

namespace CroweHelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      IUnityContainer container = new UnityContainer();
      RegisterTypes(container);

      var helloWorld = container.Resolve<IHelloWorld>();
      var text = helloWorld.Text();

      var writer = container.Resolve<IWrite>();
      writer.Write(text);
    }

    static void RegisterTypes(IUnityContainer container)
    {
      container.RegisterType<IHelloWorld, HelloWorld>();
      var shouldWriteToConsole = Settings.Default["ShouldWriteToConsole"];
      if((bool)shouldWriteToConsole)
      {
        container.RegisterType<IWrite, ConsoleWriter>();
      }
      else
      {
        container.RegisterType<IWrite, DatabaseWriterExample>();
      }
      
      
      //container.RegisterType<IWrite, DatabaseWriterExample>();
    }
  }
}
