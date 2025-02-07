using System;
using System.Collections;
using System.Collections.Generic;
using DuckGame;

namespace duckgame
{
    public class DuckManager
    {
        List<IDuck> ducklist = new List<IDuck>();

        public void AddDuck()
        {
            Console.WriteLine("Enter the duck type (Rubber, Mallard, Redhead): ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter 'yes' or 'no' if the duck can fly: ");
            string canFly = Console.ReadLine().ToLower();
            Console.WriteLine("Enter 'yes' or 'no' if the duck can quack (if squeak, write 's'):");
            string isQuak = Console.ReadLine().ToLower();

            double weight;
            while (true)
            {
                Console.WriteLine("Enter weight of duck:");
                if (double.TryParse(Console.ReadLine(), out weight))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number for weight.");
            }

            int wings;
            while (true)
            {
                Console.WriteLine("Enter number of wings:");
                if (int.TryParse(Console.ReadLine(), out wings))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number for wings.");
            }

            if (Enum.TryParse(userInput, true, out DuckType selectedDuck))
            {
                IDuck newDuck = null;

                switch (selectedDuck)
                {
                    case DuckType.rubber:
                         newDuck = new Rubber(DuckType.rubber, canFly, isQuak, weight, wings);
                        break;
                    case DuckType.mallard:
                        newDuck = new Mallared(DuckType.mallard, canFly, isQuak, weight, wings);
                        break;
                    case DuckType.redhead:
                        newDuck = new Redhead(DuckType.redhead, canFly, isQuak, weight, wings);
                        break;
                    default:
                        Console.WriteLine("Invalid duck type!");
                        return;
                }

                ducklist.Add(newDuck);
                Console.WriteLine($"Duck of type {selectedDuck} added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid duck type entered!");
            }
        }
     

        public void ShowAllDucks()
        {
            if (ducklist.Count == 0)
            {
                Console.WriteLine("No ducks available.");
                return;
            }

            Console.WriteLine("\nDuck List:");
            foreach (IDuck duck in ducklist)
            {
                Console.WriteLine($"Duck Type: {duck.Type}, Weight: {duck.Weight}, Wings: {duck.Wings}");
                Console.WriteLine(duck.CanFly == "yes" ? "The duck can fly." : "The duck cannot fly.");
                if (duck.IsQuak == "yes") Console.WriteLine("The duck can quack.");
                else if (duck.IsQuak == "s") Console.WriteLine("The duck squeaks.");
                else Console.WriteLine("The duck cannot quack.");
                Console.WriteLine("-----------------");
            }
        }

        public void weightiterate()
        {
            ducklist.Sort((duck1, duck2) => duck1.Weight.CompareTo(duck2.Weight));
            foreach (IDuck duck in ducklist)
            {
                Console.WriteLine($"Duck Type: {duck.Type}, Weight: {duck.Weight}, Wings: {duck.Wings}");
                Console.WriteLine(duck.CanFly == "yes" ? "The duck can fly." : "The duck cannot fly.");
                if (duck.IsQuak == "yes") Console.WriteLine("The duck can quack.");
                else if (duck.IsQuak == "s") Console.WriteLine("The duck squeaks.");
                else Console.WriteLine("The duck cannot quack.");
               
            }
        }
        public void wingiterate()
        {
            ducklist.Sort((duck1, duck2) => duck1.Wings.CompareTo(duck2.Wings));
            foreach (IDuck duck in ducklist)
            {
                Console.WriteLine($"Duck Type: {duck.Type}, Weight: {duck.Weight}, Wings: {duck.Wings}");
                Console.WriteLine(duck.CanFly == "yes" ? "The duck can fly." : "The duck cannot fly.");
                if (duck.IsQuak == "yes") Console.WriteLine("The duck can quack.");
                else if (duck.IsQuak == "s") Console.WriteLine("The duck squeaks.");
                else Console.WriteLine("The duck cannot quack.");

            }
        }


    }
 
    
}