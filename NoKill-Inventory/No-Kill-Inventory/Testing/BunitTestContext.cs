namespace Testing;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bunit;

public class BunitTestContext : TestContextWrapper
{
    [TestInitialize]
    public void Setup() => TestContext = new Bunit.TestContext();

    [TestCleanup]
    public void TearDown() => TestContext?.Dispose();
}