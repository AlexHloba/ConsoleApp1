namespace ConsoleApp1.Practic
{
   public interface IVehicle
    {
        void Drive(int distance);
        bool Refuel(int amount);
    }

    public abstract class Car : IVehicle
    {
        public double fuel;
        public double consumption;


        public  Car (double initialFuel, double consumption)
        {
            this.fuel = initialFuel;
            this.consumption = consumption;
        }


        public void Drive(int distance)
        {
            if(fuel > 0)
            {
                Console.WriteLine("Автомобиль движется");
            }
            else
            {
                Console.WriteLine("Автомобиль не движется.Нет топлива");
            }
        }

        public bool Refuel(int amount)
        {
            if (amount > 0)
            {
                fuel += amount;
                return true;
            }
            return false;

        }  
       
    }
    public class SportsCar: Car
    {
        public SportsCar(double initialFuel, double consumption) : base(initialFuel, consumption)
        {
        }
    }
    public class Truck : Car
    {
        public Truck(double initialFuel, double consumption) : base(initialFuel, consumption)
        {
        }
    }


}
