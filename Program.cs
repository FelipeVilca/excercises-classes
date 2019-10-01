using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Skapa en konstruktor till din djur-klass som tar emot värden för namn, 
            ålder, ras eller vad du nu skapat för variabler. Använd konstruktorn i ett testobjekt.
            */
            Dog myDog = new Dog();
            
            Console.WriteLine("Hej vad har du för djur? ");
            string myDogName = Console.ReadLine();
            Console.WriteLine("Hur gammal är din " + myDogName + " ?");
            int myDogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vad är " + myDogName + " för ras? ");
            string myDogRace = Console.ReadLine();
            
            Console.WriteLine("Ditt favorit djur är " + myDogName + 
            " och är av rasen " + myDogRace + " och är " + myDogAge + " år gammal");
        }
    }
}
