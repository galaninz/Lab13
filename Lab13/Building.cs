using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Building
    {
        string adress;
        int length;
        int width;
        int height;

        public string Adress { get; set; }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                    length = 0;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = 0;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = 0;
            }
        }

        public Building(string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Print()
        {
            return $"Здание по адресу: {adress}\nИмеет габариты {length}x{width}x{height}(H)";
        }
    }
}
