namespace SodaCrate
{
    class Sodacrate
    {
        //public string[] bottles = new string[24];
        public Soda[]? sodas_in_crate;

        public int amt_bottles = 0;
        public int sum_bottles = 0;

        public void Run() 
        {
        
        }
        public void swapSoda() 
        {
        
        }
        public void addSoda() 
        { 
        
        }
        public void print_crate() 
        {
        
        }
        public void search_soda()
        {

        }
        public void sort_soda()
        {

        }
    }
    class Soda
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
    }
    
    internal class Program
    {
        private static void printMenu()
        {
            Console.WriteLine("Enter your selection: ");
            Console.WriteLine("1 - Add a soda to your crate.");
            Console.WriteLine("2 - Show contents of your crate.");
            Console.WriteLine("3 - Calculate value of your crate.");
            Console.WriteLine("4 - Search for soda in your crate.");
            Console.WriteLine("5 - Sort your crate.");
            Console.WriteLine("6 - Exit program.");
        }

        static void Main(string[] args)
        {
            bool end = false;
            while (end == false)
            {
                try
                {
                    printMenu();
                    string? input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}