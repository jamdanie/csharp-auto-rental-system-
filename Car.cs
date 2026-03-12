namespace AutoRental
{
    internal class Car
    {
        // be able to make a car object
        // need a ctor
        public Car ()
        {

        }

        // code a ctor that accepts all 4 parameters that defines a car
        // fully-specified ctor
        // Car car2 = new Car(1971, "Chocolate Brown", "Pontiac GTO", 69.99m);
        // this is an example of an overloaded ctor (NOT over-riding)
        public Car (int year, string paint, string makeModel, decimal price)
        {
            Year = year;
            PaintColor = paint;
            MakeModel = makeModel;
            RentalPrice = price;
        }

        // set additional parameters to define the car
        // Determine the manufacture year of the car
        public int Year { get; set; }

        // Determine the color of the car
        public string PaintColor { get; set; }

        // Determine the make-model of the car
        public string MakeModel { get; set; }

        // Determine the rental price for one day of the car
        public decimal RentalPrice { get; set; }

        // OUTPUT section 
        // we need a nice organized way to print out all the data 
        // from a car object and format it the way our programe needs
        // OUTPUT section /////////////////////////////////////////////////////
        // this is an example of overriding the "builtin" object.ToString() method

        public override string ToString()
        {
            string str = "******** Auto inventory; ";
            str += $"\n Year:  {Year}";
            str += $"\n Color: {PaintColor}";
            str += $"\n Model: {MakeModel}";
            str += $"\n Daily: {RentalPrice}";
            return str;
        }



    }
}