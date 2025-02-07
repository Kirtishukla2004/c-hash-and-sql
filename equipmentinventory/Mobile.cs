using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipmentInventory;

namespace EquipmentInventory
{
    class Mobile: Equipment
    {
        public int noofwheels { get; set; }
        public Mobile (string name,string description,int noofwheels) : base(name, description, EquipmentType.mobile)
        {
            this.noofwheels = noofwheels;
        }
        public override void Moveby(double distance)
        {
            updatequipment(distance, noofwheels);
        }
        public override void showdwtails()
        {
            base.showdwtails();
            Console.WriteLine($"number of wheels {noofwheels}");
        }
    }
   
}
