using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    sealed class MultiBuilding : Building
    {
        int level;

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value < 1)
                    level = 1;
            }
        }

        public MultiBuilding(string adress, int length, int width, int height, int level)
            : base(adress, length, width, height)
        {
            this.level = level;
        }

        public string Print()
        {
            string result = base.Print();
            result += $"\nЭтажность - {level}";
            return result;
        }
    }
}
