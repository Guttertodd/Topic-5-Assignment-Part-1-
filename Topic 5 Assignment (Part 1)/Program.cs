namespace Topic_5_Assignment__Part_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string planet;
           
            double weight;
            Console.WriteLine("Please enter your curent earth weight:");
            double.TryParse(Console.ReadLine), out weight)
            Console.WriteLine("I have information for the following plannets:");
            Console.WriteLine("1. Venus    2. Mars    3. Jupiter");
            Console.WriteLine("4. Saturn   5. Uranus  6. Neptune");
            Console.WriteLine("Which planet are you visiting?");
            planet = Console.ReadLine().ToLower();

            if (planet == "1" || planet == "venus")
            {
                Console.WriteLine("Your weight would be " + weight * 0.79); 
            }
    }
}


     