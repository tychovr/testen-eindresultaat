using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hypotheker;

[TestClass]
public class UnitTests
{
    [TestMethod]
    [DataRow(70000, 30, false, 0, 0, 10)]
    public void TestCalculatorWithoutPartner(int bruteInkomen, int leeftijd, bool heeftPartner, int brutoInkomenPartner, int leeftijdPartner, int rentevastePeriode)
    {
        Calculator calculator = new Calculator();
        double result = calculator.RunCalculator(bruteInkomen, leeftijd, heeftPartner, brutoInkomenPartner, leeftijdPartner, rentevastePeriode);
        Assert.AreEqual(315000, result);
    }
    
    [TestMethod]
    [DataRow(70000, 30, true, 60000, 28, 5)]
    public void TestCalculatorWithPartner(int bruteInkomen, int leeftijd, bool heeftPartner, int brutoInkomenPartner, int leeftijdPartner, int rentevastePeriode)
    {
        Calculator calculator = new Calculator();
        double result = calculator.RunCalculator(bruteInkomen, leeftijd, heeftPartner, brutoInkomenPartner, leeftijdPartner, rentevastePeriode);
        Assert.AreEqual(315000, result);
    }
}