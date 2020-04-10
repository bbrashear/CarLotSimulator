using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Carlot listOfCars = new Carlot();

            Car myFirstCar = new Car();
            myFirstCar.Year = 2005;
            myFirstCar.Make = "Chevy";
            myFirstCar.Model = "Malibu";
            myFirstCar.EngineNoise = "....";
            myFirstCar.HonkNoise = "beeeep";
            myFirstCar.IsDriveable = false ;

            listOfCars.MakeList.Add(myFirstCar);

            Car mySecondCar = new Car() 
            {
                Year = 2014,
                Make = "Buick",
                Model = "Encore",
                EngineNoise = "vroom vroom",
                HonkNoise = "beep beep",
                IsDriveable = true
            };

            listOfCars.MakeList.Add(mySecondCar);

            Car myWifesCar = new Car(1999, "Toyota", "Camry", "putttt", "honk honk", true);

            listOfCars.MakeList.Add(myWifesCar);

            MakeNoise(myFirstCar);

            MakeNoise(mySecondCar);

            MakeNoise(myWifesCar);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            PrintAttributes(listOfCars);
        }

        public static void MakeNoise(Car car)
        {
            car.MakeEngineNoise();
            Console.WriteLine();
            car.MakeHonkNoise();
            Console.ReadLine();
        }

        public static void PrintAttributes(Carlot cars)
        {
            foreach(Car car in cars)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.EngineNoise);
                Console.WriteLine(car.HonkNoise);
                Console.WriteLine(car.IsDriveable);
            }
        }

    }
}
