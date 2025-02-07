using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckGame;

namespace duckgame
{
    public class Mallared : IDuck
    {
        public DuckType Type { get; set; }
        public string CanFly { get; set; }
        public string IsQuak { get; set; }
        public double Weight { get; set; }
        public int Wings { get; set; }

        public Mallared(DuckType type, string canFly, string isQuak, double weight, int wings)
        {
            Type = type;
            CanFly = canFly;
            IsQuak = isQuak;
            Weight = weight;
            Wings = wings;
        }

        public void Showdetails(DuckType type, string canFly, string isQuak)
        {
            Console.WriteLine($"Duck Type: {type}, Can Fly: {canFly}, Can Quack: {isQuak}");
        }
    }
}
