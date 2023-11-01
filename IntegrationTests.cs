using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Hypotheker
{
    public class IntegrationTests
    {
        [Fact]
        public void CalculatorWithPartner()
        {
            Calculator calculator = new Calculator();
            int inkomen = 70000;
            int leeftijd = 30;
            bool heeftPartner = true;
            int inkomenPartner = 60000;
            int leeftijdPartner = 28;
            int rentevastePeriode = 5;

            double result = calculator.RunCalculator(inkomen, leeftijd, heeftPartner, inkomenPartner, leeftijdPartner, rentevastePeriode);

            double expected = 315000; 
            Assert.AreEqual(expected, result);
        }

        [Fact]
        public void CalculatorWithoutPartner()
        {
            Calculator calculator = new Calculator();
            int inkomen = 70000;
            int leeftijd = 30;
            bool heeftPartner = false;
            int inkomenPartner = 0;
            int leeftijdPartner = 0;
            int rentevastePeriode = 30;

            double result = calculator.RunCalculator(inkomen, leeftijd, heeftPartner, inkomenPartner, leeftijdPartner, rentevastePeriode);

            double expected = 315000; 
            Assert.AreEqual(expected, result);
        }

        [Fact]
        public void CalculatorWithForbiddenPostalCode()
        {
            string postcode = "9682";
            Prompts promts = new Prompts();
            bool validePostcode = promts.AccordeonMenu(postcode);

            Assert.AreEqual(false, validePostcode);
        }
    }
}