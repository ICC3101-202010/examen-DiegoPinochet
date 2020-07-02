using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    abstract class IntegrantesEquipo
    {
        protected string name;
        protected int age;
        protected string nacionality;
        protected int salary;

        public string Nacionality { get => nacionality; set => nacionality = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public abstract string GetInfo();
        
    }
}
