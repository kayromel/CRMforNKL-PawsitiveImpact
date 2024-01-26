using No_Kill_Inventory.Components.Pages;

namespace Testing;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bunit;

[TestClass]
public class ExampleTest : BunitTestContext
{
    [TestMethod]
    public void HelloWorldTest()
    {
        var cut = RenderComponent<HelloWorld>();
        
        cut.MarkupMatches("<h3>HelloWorld</h3>");
    }
}