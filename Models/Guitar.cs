namespace GuitarOOADDemo.Models
{
    internal class Guitar
    {

        //represents a guitar
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; set; }



        //constructor that contains instance of guitar including it's builder, model, type etc
        public Guitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = guitarSpec;
        }

        // returns a string representation of the guitar, including its serial number, price, and specifications
        public override string ToString()
        {
            return $"\nGuitar Details: \n" +
                $"-------------------------------\n" +
                $"Serial No.         : {SerialNumber}\n" +
                $"Price              : {Price}\n" +
                $"Builder            : {Spec.Builder}\n" +
                $"Model              : {Spec.Model}\n" +
                $"Type               : {Spec.Type}\n" +
                $"Backwood           : {Spec.BackWood}\n" +
                $"Topwood            : {Spec.TopWood}\n" +
                $"Number of Strings  : {Spec.NumStrings}\n" +
                $"-------------------------------";
        }


    }
}
