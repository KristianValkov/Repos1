using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOlimpiada
{
    internal class Olimpiada:IPrint,IComparable<Olimpiada>
    {
        public string name;
        public int countPoints;
        public Olimpiada(string name, int countPoints)
        {
            this.name = name;
            this.countPoints = countPoints;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int CountPoints
        {
            get { return this.countPoints; }
            set { this.countPoints = value; }
        }

        public int CompareTo(Olimpiada other)
        {
           return countPoints.CompareTo(other.countPoints);
        }

        public void Print()
        {
            Console.WriteLine($"Name {this.name}, Points {this.countPoints}");
        }

    }
}
