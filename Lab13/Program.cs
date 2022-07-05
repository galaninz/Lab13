using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Ул. Пушкина", 10, 10, 10);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("дом Колотушкина", 5, 5, 6, 2);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
