using System;


namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string valueIn;
            bool isNumber;
            double measurement;
            double measurement2;

            Console.WriteLine("Make your choice for the geometric shape you would like to calculate the area\nfor:\n"+
                              "1. Square\n"+
                              "2. Triangle\n"+
                              "3. Circle");

            valueIn = Console.ReadLine();
            isNumber = int.TryParse(valueIn, out choice);

            while(isNumber==false||choice<1||choice>3)
            {
                Console.WriteLine("Invalid choice!!!!");
                valueIn = Console.ReadLine();
                isNumber = int.TryParse(valueIn, out choice);
            }

            if(choice==1)
            {
                Console.WriteLine("Square");
                Console.WriteLine("Enter the length of the sides");
                valueIn = Console.ReadLine();
                isNumber = double.TryParse(valueIn, out measurement);

                while (isNumber == false||measurement<0)
                {
                    Console.WriteLine("Invalid choice!!!!");
                    valueIn = Console.ReadLine();
                    isNumber = double.TryParse(valueIn, out measurement);
                }

                Square geo1 = new Square(measurement);
                Console.WriteLine("Area: {0}", geo1.getArea(geo1.side,geo1.side));
            }

            if(choice==2)
            {
                Console.WriteLine("Triangle");
                Console.WriteLine("Enter the length of the base: ");
                valueIn = Console.ReadLine();
                isNumber = double.TryParse(valueIn, out measurement);

                while (isNumber == false || measurement < 0)
                {
                    Console.WriteLine("Invalid choice!!!!");
                    valueIn = Console.ReadLine();
                    isNumber = double.TryParse(valueIn, out measurement);
                }

                Console.WriteLine("Enter the length of the height: ");
                valueIn = Console.ReadLine();
                isNumber = double.TryParse(valueIn, out measurement2);

                while (isNumber == false || measurement2 < 0)
                {
                    Console.WriteLine("Invalid choice!!!!");
                    valueIn = Console.ReadLine();
                    isNumber = double.TryParse(valueIn, out measurement2);
                }

                Triangle geo1 = new Triangle(measurement, measurement2);
                Console.WriteLine("Area: {0}", geo1.getArea(geo1.Base,geo1.height));
            }

            if(choice==3)
            {
                Console.WriteLine("Circle");
                Console.WriteLine("Enter the radius");
                valueIn = Console.ReadLine();
                isNumber = double.TryParse(valueIn, out measurement);

                while (isNumber == false || measurement < 0)
                {
                    Console.WriteLine("Invalid choice!!!!");
                    valueIn = Console.ReadLine();
                    isNumber = double.TryParse(valueIn, out measurement);
                }

                Circle geo1 = new Circle(measurement);
                Console.WriteLine("Area: {0}",geo1.getArea(geo1.radius,geo1.radius));
            }

            Console.ReadKey();
        }
    }
}
