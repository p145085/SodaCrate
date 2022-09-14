namespace SodaCrate
{
    public class Sodacrate
    {
        //public string[] bottles = new string[24];
        public List<Soda> SodasInCrate = new List<Soda>();

        public int AmtBottles = 0;
        public int SumBottles = 0;

        private static void PrintMenu()
        {
            Console.WriteLine("Enter your selection: ");
            Console.WriteLine("1 - Add a soda to your crate.");
            Console.WriteLine("2 - Show contents of your crate.");
            Console.WriteLine("3 - Calculate value of your crate.");
            Console.WriteLine("4 - Search for soda in your crate.");
            Console.WriteLine("5 - Sort your crate.");
            Console.WriteLine("6 - Exit program.");
        }
        public static void Run()
        {
            var sodacrate = new Sodacrate();

            bool End = false;
            while (End == false)
            {
                try
                {
                    PrintMenu();
                    string? input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            sodacrate.AddSoda();
                            break;
                        case "2":
                            sodacrate.PrintCrate();
                            break;
                        case "3":
                            Console.WriteLine(sodacrate.Calculate_Total() + " SEK"); 
                            break;
                        case "4":
                            Console.WriteLine("Enter your search: ");
                            sodacrate.SearchSoda(Console.ReadLine());
                            break;
                        case "5":
                            sodacrate.SortSoda();
                            break;
                        case "6":
                            End = true;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public int? Calculate_Total()
        {
            int? total = 0;
            foreach (Soda soda in SodasInCrate)
            {
                if (soda.Price != null)
                {
                    return total += soda.Price;
                }
                else { return null; }
            }
            return total;
        }
        public void SwapSoda()
        {

        }
        public void PrintAddMenu()
        {
            Console.WriteLine("Enter your selection: ");
            Console.WriteLine("1 - Add a Coca-Cola.");
            Console.WriteLine("2 - Add a Fanta.");
            Console.WriteLine("3 - Add a Sprite.");
            Console.WriteLine("4 - Add a Pepsi.");
            Console.WriteLine("5 - Add a Loka.");
            Console.WriteLine("6 - I changed my mind, I don't want to add a new soda.");
        }
        public void AddSoda()
        {
            PrintAddMenu();
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Soda cola = new Soda("Coca-Cola", "Carbonated", 15);
                    SodasInCrate.Add(cola);
                    AmtBottles++;
                    PrintCrate();
                    break;
                case "2":
                    Soda fanta = new Soda("Fanta", "Carbonated", 15);
                    SodasInCrate.Add(fanta);
                    AmtBottles++;
                    PrintCrate();
                    break;
                case "3":
                    Soda sprite = new Soda("Sprite", "Carbonated", 15);
                    SodasInCrate.Add(sprite);
                    AmtBottles++;
                    PrintCrate();
                    break;
                case "4":
                    Soda pepsi = new Soda("Pepsi", "Carbonated", 15);
                    SodasInCrate.Add(pepsi);
                    AmtBottles++;
                    PrintCrate();
                    break;
                case "5":
                    Soda loka = new Soda("Loka", "Carbonated", 15);
                    SodasInCrate.Add(loka);
                    AmtBottles++;
                    PrintCrate();
                    break;
            }
        }
        public void PrintCrate()
        {
            foreach (Soda soda in SodasInCrate)
            {
                if (soda != null)
                {
                    Console.WriteLine(soda.ToString());
                }
                else
                {
                    Console.WriteLine("Empty slot.");
                }
            }
        }
        public void SearchSoda(string search)
        {
            Console.WriteLine("Searching...");
            try
            {
                foreach (Soda soda in SodasInCrate)
                {
                    if (soda.Name == search)
                    {
                        Console.WriteLine("Found: " + soda.Name);
                    }
                    else
                    {
                        Console.WriteLine("No search results found.");
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Search ended.");
            }
            
        }
        public void SortSoda()
        {
            Console.WriteLine("Sorting sodas alphabetically.");
            SodasInCrate.Sort();
            PrintCrate();
        }
    }
    public class Soda
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int? Price { get; set; }

        public Soda(string? name, string? type, int? price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
        public override string ToString()
        {
            return "Name: " + this.Name + "\n"
                + "Type: " + this.Type + "\n"
                + "Price: " + this.Price + "\n";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sodacrate.Run();
        }
    }
}
