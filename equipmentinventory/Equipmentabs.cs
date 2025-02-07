using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipmentInventory;

namespace EquipmentInventory
{
    public enum EquipmentType
    {
        mobile,
        immobile
    }
    abstract class Equipment
    {
        public string name { get; set; }
        public string description { get; set; }
        public double movetilldate { get; set; }
        public double maintaincecost { get; set; }
        public EquipmentType type { set; get; }
        public Equipment(string name ,string description,EquipmentType type)
        {
            this.name = name;
            this.description = description;
            this.type = type;
        }
        public abstract void Moveby(double distance);
        protected  void updatequipment(double distance,double costfactor)
        {
            movetilldate += distance;
            maintaincecost = distance * costfactor;
            Console.WriteLine("MOVED");
        }
        public virtual void showdwtails()
        {
            Console.WriteLine($"Name {name}");
            Console.WriteLine($"Distance moved till date   {movetilldate}"); ;
            Console.WriteLine($"maintaince cost   {maintaincecost}");
            Console.WriteLine($"Description  {description}");
            Console.WriteLine($"Type  {type}");




        }


    }
}
