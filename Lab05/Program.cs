using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new Car(Car.Countries.Ukarine, "AA4444AA", Car.AutoModel.Reno, 1000, 250)
                {
                    Color = "Red",
                    Speed = 40
                };
                Console.WriteLine(car.ToString());
            }
            catch (Car.CarException ex)
            {
               Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
