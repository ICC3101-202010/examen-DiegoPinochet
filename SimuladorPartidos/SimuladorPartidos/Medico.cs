using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    class Medico : IntegrantesEquipo
    {

        private int exp;
        private bool treatingPlayer;
        public Medico(string name, int edad, string nacionalidad, int sueldo, int exp)
        {
            this.name = name;
            this.age = edad;
            this.nacionality = nacionalidad;
            this.salary = sueldo;
            this.exp = exp;
        }

        
        public void OnInjuryNotified(object sender, EventArgs e)
        {
            Console.WriteLine("Player Injured...");
            treatingPlayer = true;

        }
        public void Cure()
        {
            if (treatingPlayer == true)
            {
                Console.WriteLine("Player Cured...");
                treatingPlayer = false;
            }
        }
        public void Treat()
        {
            if (treatingPlayer == true)
            {
                Console.WriteLine("Treating Player...");
            }
        }

        public override string GetInfo()
        {
            return "Name: " + name;
        }
    }
}
