namespace Hypotheker;

public class Prompts
{
    public int brutoInkomen;
    public int brutoInkomenPartner = 0;
    public int leeftijd;
    public int leeftijdPartner = 0;
    public int rentevastePeriode;
    public bool heeftPartner = false;
    
    public void Initialize()
    {
        Console.SetCursorPosition(1, 1);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Welkom bij de hypotheek berekenings tool");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void AskInput()
    {
        Console.SetCursorPosition(1, 1);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Vul uw jaarlijkse bruto inkomen in:");
        Console.ForegroundColor = ConsoleColor.Blue;
        brutoInkomen = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n Vul uw leeftijd in:");
        Console.ForegroundColor = ConsoleColor.Blue;
        leeftijd = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n Heeft u een partner? (Ja/Nee)");
        Console.ForegroundColor = ConsoleColor.Blue;
        string partner = Console.ReadLine();
        Console.Clear();

        if (partner == "ja" | partner == "Ja")
        {
            heeftPartner = true;
            
            Console.SetCursorPosition(1, 1);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Vul uw partner's jaarlijkse bruto inkomen in:");
            Console.ForegroundColor = ConsoleColor.Blue;
            int brutoInkomenPartner = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Vul uw partner's leeftijd in:");
            Console.ForegroundColor = ConsoleColor.Blue;
            int leeftijdPartner = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    public void Calculate()
    {
        Console.Clear();
        Console.SetCursorPosition(1, 1);
        Console.WriteLine("\n Berekenen...");
        Thread.Sleep(3000);
        Console.Clear();
        Console.SetCursorPosition(1, 1);
        Console.WriteLine("\n Zoeken naar de goedkoopste hypotheker...");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public bool AccordeonMenu(string postcode)
    {
        Console.SetCursorPosition(1, 1);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Heb je maandelijkse financiële verplichtingen? (Ja/Nee):");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" Druk op 'Enter' om over te slaan");
        Console.ForegroundColor = ConsoleColor.Blue;
        string financieleVerplichtingen = Console.ReadLine();
        Console.Clear();

        if (financieleVerplichtingen == "ja" | financieleVerplichtingen == "Ja")
        {
            Console.SetCursorPosition(1, 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Deze feature gaat nooit bestaan, fuck dat!");
            Thread.Sleep(3000);
            Console.Clear();
        }
        
        Console.SetCursorPosition(1, 1);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Heb je al een huis op het oog? (Ja/Nee):");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" Druk op 'Enter' om over te slaan");
        string huisOpOog = Console.ReadLine();
        Console.Clear();

        if (huisOpOog == "ja" | huisOpOog == "Ja")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Wat is de postcode? (bijv: 6947):");
            Console.ForegroundColor = ConsoleColor.Blue;
            postcode = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Wat is de straatnaam?:");
            Console.ForegroundColor = ConsoleColor.Blue;
            string straatNaam = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Wat is het huisnummer?:");
            Console.ForegroundColor = ConsoleColor.Blue;
            int huisnummer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (postcode == "9679" || postcode == "9681" || postcode == "9682")
            {
                Console.Clear();
                Console.SetCursorPosition(1, 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Deze postcode is verboden!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n \n Druk op 'Enter' om af te sluiten");
                Console.ReadLine();
                return false;
            }
        } 
        
        Console.SetCursorPosition(1, 1);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Wat word uw rentevaste periode?: (1, 5, 10, 20 of 30 jaar)");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" Druk op 'Enter' om over te slaan");
        Console.ForegroundColor = ConsoleColor.Blue;
        rentevastePeriode = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        Calculator calculator = new Calculator();
        calculator.RunCalculator(brutoInkomen, leeftijd, heeftPartner, brutoInkomenPartner, leeftijdPartner, rentevastePeriode);
        return true;
    }

    public void ShowResults(double maximaalHypotheekBedrag, double maandelijkseAflossing, double rente, int looptijd)
    {
        Console.SetCursorPosition(1, 1);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("De goedkoopste hypotheker is: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Tycho's All Mighty Bank");
        Console.SetCursorPosition(1, 2);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Het maximale hypotheek bedrag is: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\u20AC" + maximaalHypotheekBedrag);
        Console.SetCursorPosition(1, 3);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("De maandelijkse aflossing zal zijn: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\u20AC" + maandelijkseAflossing);
        Console.SetCursorPosition(1, 4);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("De rente is: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(rente + "%");
        Console.SetCursorPosition(1, 5);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("De looptijd is: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(looptijd + " jaar");
        Console.SetCursorPosition(1, 7);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Druk op 'Enter' om af te sluiten");
        Console.ReadLine();
        Environment.Exit(0);
    }
}