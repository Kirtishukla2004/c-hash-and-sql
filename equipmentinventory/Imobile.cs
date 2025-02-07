using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentInventory
{
    class Imobile: Equipment
    {
        public int weight { get; set; }
        public Imobile(string name, string description, int weight) : base(name, description, EquipmentType.immobile)
        {
            this.weight = weight;
        }
        public override void Moveby(double distance)
        {
            updatequipment(distance, weight);
        }
        public override void showdwtails()
        {
            base.showdwtails();
            Console.WriteLine($"number of wheels {weight}");
        }
    }

}
