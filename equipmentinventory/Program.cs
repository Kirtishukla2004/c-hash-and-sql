using System;
using System.Diagnostics;
namespace EquipmentInventory
{
  
 class Program
    {
        public static void Main(string[] args)

        {
            EquipmentManager eqp = new EquipmentManager();
         

            while (true)
            {
              
         
            Console.WriteLine("Enter the no. according to the shown list and perform operations ");
            Console.WriteLine("1.enter to create an equipment ");
            Console.WriteLine("2. enter to move the equipment ");
            Console.WriteLine("3.enter the no. of see details of equipment");
            Console.WriteLine("4.enter to see all the details of equipment");
            Console.WriteLine("5.enter the no. to see mobile data ");
            Console.WriteLine("6. enter to see the imobile data ");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 1 || choice == 2)
                
                    Console.WriteLine("enter the type of equipment");
                    string Type = Console.ReadLine().ToLower();
                
                switch (choice)
                {
                    case 1:eqp.CreateEquipemt(Type);
                            break;
                    case 2:
                        eqp.MoveEquipment(Type);
                        break;
                    case 3:
                        eqp.listallequipment();
                        break;
                    case 4:
                        eqp.alldetailsequipment();
                        break;
                    case 5:
                        eqp.showmobileequipment();
                        break;
                    case 6:
                        eqp.showimobileequipment();
                        break;
                    default:
                        Console.WriteLine("entered choice is invaild ");
                        break;
                }
                
            }

        }
    }

}






    