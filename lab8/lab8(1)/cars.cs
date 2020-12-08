using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Cars
    {
        public string Name { get; }
        public string Color { get; }
        public int Speed { get; }
        public int YearofIssue { get; }

        public Cars() { }
        public Cars(string name, string color, int speed, int yearofIssue)
        {
            Name = name;
            Color = color;
            Speed = speed;
            YearofIssue = yearofIssue;
        }
    }
}