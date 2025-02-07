using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EquipmentInventory
{
    class EquipmentManager
    {
        List<Equipment> equipmentlist = new List<Equipment>();
       
        public void CreateEquipemt( string Type)

        {
            Console.WriteLine("Enter equipment name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter equipment description ");
            string description = Console.ReadLine();
           
           
            if (Type == "m") {
                Console.WriteLine("enter the no. of wheels ");
                int noofwheels = int.Parse(Console.ReadLine());
                equipmentlist.Add(new Mobile(name, description, noofwheels));
                
                
              
            }
            else if (Type =="i")
            {
                Console.WriteLine("enter weight ");
                int weight = int.Parse(Console.ReadLine());
                equipmentlist.Add(new Mobile(name, description, weight));
              
            }
            else
            {
                Console.WriteLine("invailed input ");
            }
        }
        
        public void MoveEquipment(string Type)
        {
            Console.WriteLine("enter the equipment name ");
            string name = Console.ReadLine();
            
            Equipment equipmentToMove = equipmentlist.FirstOrDefault(e => e.name.Equals(name, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(equipmentToMove);
            if(equipmentToMove != null)
            {
                if (Type == "m")
                {
                    Console.WriteLine("enter distance ");
                    double distance = double.Parse(Console.ReadLine());
                    equipmentToMove.Moveby(distance);
                    
                }
                
            }
            else
            {
                Console.WriteLine("entered value is invaild");
            }
        }
        public void listallequipment()
        {
            foreach(Equipment eq in equipmentlist)
            {
                Console.WriteLine($"Name : {eq.name}  Description : {eq.description} ");
            }

        }
        public void alldetailsequipment()
        {
            Console.WriteLine("enter the name of equipment ");
            string name = Console.ReadLine();
            Equipment equipment = equipmentlist.FirstOrDefault(e => e.name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if(equipment != null)
            {
                equipment.showdwtails();
            }
            else
            {
                Console.WriteLine("invaild input");
            }

        }
        public void showmobileequipment()
        {
            var mobileequipment = equipmentlist.Where(e => e.type == EquipmentType.mobile).ToList();
            foreach(Equipment eq in mobileequipment)
            {
                Console.WriteLine(eq.name, eq.description);
            }
        }

        public void showimobileequipment()
        {
            var imobileequipment = equipmentlist.Where(e => e.type == EquipmentType.immobile).ToList();
            foreach (Equipment eq in imobileequipment)
            {
                Console.WriteLine(eq.name, eq.description);
            }
        }
      
    }
}
