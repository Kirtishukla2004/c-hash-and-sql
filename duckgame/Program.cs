using System;
using duckgame;
namespace DuckGame
{
    public enum DuckType
    {
        rubber,
        mallard,
        redhead
    }

    
    public interface IDuck
    {
        DuckType Type { get; set; }
        string CanFly { get; set; }
        string IsQuak { get; set; }
        double Weight { get; set; }
        int Wings { get; set; }
        void Showdetails(DuckType type, string canFly, string isQuak);
    }

    class Program
    {
        static void Main(string[] args)
        {
            DuckManager manager = new DuckManager();
            while (true)
            {
                Console.WriteLine("Enter 1 to Add a duck in the list \n enter 2 to see the duck list with weight or wings \n enter 3 for seeing sorted ducklist according to weight \n enter 4 to see ducklist sorted according to wings  ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        manager.AddDuck();
                        break;
                    case 2:
                        manager.ShowAllDucks();
                        break;
                    case 3:
                        manager.weightiterate();
                        break;
                    case 4:
                        manager.wingiterate();
                        break;
                    default:
                        Console.WriteLine("Entered input is invaild ");
                        break;
                }
            }
            
        }
    }
}
