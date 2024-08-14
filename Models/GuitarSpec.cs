namespace GuitarOOADDemo.Models
{
    internal class GuitarSpec
    {
        //represents specification of guitar
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public TypeGuitar Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumStrings { get; set; }


        //constructor that contains instance of guitar specs with the specified builder, model, type, woods, and number of strings
        public GuitarSpec(Builder builder, string model, TypeGuitar type, Wood backWood, Wood topWood, int numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }


        //method to check if this guitar specification matches another specification
        //here gSpec is the guitar specification to compare with
        //it will return true if all fields match, false otherwise
        public bool SearchMatch(GuitarSpec gSpec)
        {
            if (Builder == gSpec.Builder &&
                Model.ToLower() == gSpec.Model.ToLower() &&
                Type == gSpec.Type &&
                BackWood == gSpec.BackWood &&
                TopWood == gSpec.TopWood &&
                NumStrings == gSpec.NumStrings)
                return true;
            return false;
        }

    }
}
