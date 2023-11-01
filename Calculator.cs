namespace Hypotheker;

public class Calculator
{
    public double RunCalculator(int brutoInkomen, int leeftijd, bool heeftPartner, int brutoInkomenPartner, int leeftijdPartner, int rentevastePeriode)
    {
        double rente = 0.0;
        double maximaalHypotheekBedrag = (brutoInkomen + brutoInkomenPartner) * 4.5;
        double maandelijkseAflossing = maximaalHypotheekBedrag / (rentevastePeriode * 12);
        
        switch (rentevastePeriode)
        {
            case 1:
                rente = 2.0;
                break;
            case 5:
                rente = 3.0;
                break;
            case 10:
                rente = 3.5;
                break;
            case 20:
                rente = 4.5;
                break;
            case 30:
                rente = 5.0;
                break;
            default:
                rente = 5.0;
                break;
        }

        Prompts prompts = new Prompts();
        prompts.ShowResults(maximaalHypotheekBedrag, maandelijkseAflossing, rente, rentevastePeriode);
        return (brutoInkomen + brutoInkomenPartner) * (rente / 100);
    }
}