namespace GuitarOOADDemo.Models
{
    internal class Inventory
    {

        //list to hold all guitars in the inventory
        public static List<Guitar> guitars = new List<Guitar>();



        //method to add guitar to the inventory
        public static void AddGuitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            //create a guitar object 
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
            guitars.Add(guitar);
        }

        //method to retrieve a guitar by its serial number
        public static Guitar GetGuitar(string serialNumber)
        {
            Guitar findGuitar = null;
            //iterate through the list of guitars
            foreach (Guitar guitar in guitars)
            {
                //check if the serial number matches
                if (guitar.SerialNumber.ToLower() == serialNumber.ToLower())
                    findGuitar = guitar;
            }
            return findGuitar;
        }

        //method to search for guitars that match a given specification
        public static List<Guitar> SearchGuitar(GuitarSpec gSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (Guitar guitar in guitars)
            {
                if (guitar.Spec.SearchMatch(gSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
