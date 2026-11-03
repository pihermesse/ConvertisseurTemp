namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.

        Console.WriteLine("=== Convertisseur de températures ===");
        Console.WriteLine("1. De Celsius à Fahrenheit");
        Console.WriteLine("2. De Fahrenheit à Celsius");

        Console.Write("Entrez votre choix (1 ou 2) : ");
        int choix = Convert.ToInt32(Console.ReadLine());

        Console.Write("Entrez une température : ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        double resultat = 0;

        if (choix == 1)
        {
            resultat = (temperature * 9 / 5) + 32;

            Console.WriteLine("\nVotre température vaut " + resultat + "°F");
        }
        else if (choix == 2)
        {
            resultat = (temperature - 32) * 5 / 9;

            Console.WriteLine("\nVotre température vaut " + resultat + "°C");
        }
        else
        {
            Console.WriteLine("Choix invalide !");
        }
    }
}