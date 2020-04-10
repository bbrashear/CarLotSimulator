using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Carlot
    {
        public Carlot()
        {

        }
        public Carlot(List<Car> listOfCars)
        {
            CarList = listOfCars;
        }

        public List<Car> CarList { get; set; }

    }
}
