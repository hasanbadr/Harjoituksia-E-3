using System;

class Program
{
    static void Main()
    {
        Console.Write("Syötä sana: ");
        string sana = Console.ReadLine();

        if (sana.Length >= 2)
        {
            char[] sanaTaulukko = sana.ToCharArray();

            // Vaihdetaan ensimmäinen ja viimeinen kirjain
            char ensimmäinenKirjain = sanaTaulukko[0];
            sanaTaulukko[0] = sanaTaulukko[sanaTaulukko.Length - 1];
            sanaTaulukko[sanaTaulukko.Length - 1] = ensimmäinenKirjain;

            string uusiSana = new string(sanaTaulukko);
            Console.WriteLine(uusiSana);
        }
        else
        {
            Console.WriteLine("Syötä vähintään kaksi kirjainta sisältävä sana.");
        }
    }
}