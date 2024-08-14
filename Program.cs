using GuitarOOADDemo.Models;

namespace GuitarOOADDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //adding guitars to the inventory with different specifications
            Inventory.AddGuitar("SN01", 8700, new GuitarSpec(Builder.FENDER, "D-28", TypeGuitar.ELECTRIC, Wood.ALDER, Wood.ALDER, 11));
            Inventory.AddGuitar("SN025", 15000, new GuitarSpec(Builder.TAYLOR, "314ce", TypeGuitar.ACOUSTIC, Wood.SAPELE, Wood.BASSWOOD, 7));
            Inventory.AddGuitar("SN013", 5000, new GuitarSpec(Builder.MARTIN, "D-28", TypeGuitar.ACOUSTIC, Wood.SAPELE, Wood.ALDER, 12));
            Inventory.AddGuitar("SN042", 8700, new GuitarSpec(Builder.GIBSON, "Stratocaster", TypeGuitar.ELECTRIC, Wood.BASSWOOD, Wood.MAPLE, 6));
            Inventory.AddGuitar("SN087", 20000, new GuitarSpec(Builder.AIRLINE, "314ce-24", TypeGuitar.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, 7));
            Inventory.AddGuitar("SN097", 13900, new GuitarSpec(Builder.AIRLINE, "Custom-24", TypeGuitar.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, 11));


            //retrieve a guitar by its serial number
            Guitar findGuitar = Inventory.GetGuitar("SN01");
            Console.WriteLine("Get Guitar by Serial Number");
            Console.WriteLine("============================");


            //print the details of the found guitar
            Console.WriteLine(findGuitar);

            //search for guitars that match specific customer preference
            Console.WriteLine("\nSearch Guitar as per Customer's Preference");
            Console.WriteLine("==========================================");
            List<Guitar> searchGuitar = Inventory.SearchGuitar(new GuitarSpec(Builder.AIRLINE, "CUSTOM-24", TypeGuitar.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, 11));


            //display the search results
            if (searchGuitar.Count > 0)
            {
                Console.WriteLine($"Erin, you might like these guitars .....\n");
                foreach (Guitar item in searchGuitar)
                    //print the matching guitar
                    Console.WriteLine(item);
            }
            else Console.WriteLine("Sorry, we couldn't find a suitable guitar for you");
        }
    }
}
